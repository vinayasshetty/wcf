using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;
public partial class client : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //protected void btnCall_Click(object sender, EventArgs e)
    //{
    //    EmpServiceClient proxy = new EmpServiceClient();
    //    string msg = proxy.GetMsg();
    //    lblMsg.Text = "WCF Messsage:" + msg;
    //}

    //protected void btn_tcp_Click(object sender, EventArgs e)
    //{
    //    EmpServiceClient proxy = new EmpServiceClient();
    //    string msg = proxy.GetMsg();
    //    lblMsg.Text = "WCF Messsage:" + msg;
    //}

    protected void btnGetAllEmps_Click(object sender, EventArgs e)
    {
        EmpServiceClient proxy = new EmpServiceClient("BasicHttpBinding_IEmpService");
        var result = proxy.GetAllEmps().ToList();
        GridView1.DataSource = result;
        GridView1.DataBind();

    }



    protected void btninsert_Click(object sender, EventArgs e)
    {
        EmpServiceClient proxy = new EmpServiceClient("BasicHttpBinding_IEmpService");
       
        var result = new tbl_employee
        {
            Ecode = int.Parse(txtecode.Text),
            Ename = txtename.Text,
            salary=int.Parse(txtsalary.Text),
            deptid=int.Parse(txtdeptid.Text)

        };
        proxy.AddEmployee(result);
        GridView1.DataSource = proxy.GetAllEmps().ToList();
        GridView1.DataBind();
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        EmpServiceClient proxy = new EmpServiceClient("BasicHttpBinding_IEmpService");
        var Ecode = int.Parse(txtecode.Text);
        proxy.DeleteEmp(Ecode);
        GridView1.DataSource = proxy.GetAllEmps().ToList();
        GridView1.DataBind();

    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        EmpServiceClient proxy = new EmpServiceClient("BasicHttpBinding_IEmpService");
        var result = new tbl_employee
        {
            Ecode = int.Parse(txtecode.Text),
            salary = int.Parse(txtsalary.Text)
        };
        proxy.UpdateEmp(result);
        GridView1.DataSource = proxy.GetAllEmps().ToList();
        GridView1.DataBind();

    }

    protected void btnemployeebyid_Click(object sender, EventArgs e)
    {
        EmpServiceClient proxy = new EmpServiceClient("BasicHttpBinding_IEmpService");
        var Ecode = int.Parse(txtecode.Text);
        var a=proxy.GetEmpById(Ecode);
        txtename.Text = a.Ename.ToString();
        txtsalary.Text = a.salary.ToString();
        txtdeptid.Text = a.deptid.ToString();
        GridView1.DataSource = proxy.GetAllEmps().ToList();
        GridView1.DataBind();

    }
}