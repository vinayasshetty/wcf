using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EFDalLib;

namespace WCFLib
{

    public class EmpService : IEmpService
    {
        public void AddEmployee(tbl_employee emp)
        {
            EFDal dal = new EFDal();
            //tbl_employee employee = new tbl_employee();

            dal.AddEmployee(emp);
           
        }

        public void DeleteEmp(int ecode)
        {
            EFDal dal = new EFDal();
            dal.DeleteById(ecode);
        }

        public List<tbl_employee> GetAllEmps()
        {
            EFDal dal = new EFDal();
            return dal.GetAllEmps();
        }

        public tbl_employee GetEmpById(int ecode)
        {
            EFDal dal = new EFDal();
            return dal.GetEmpById(ecode);
        }

        public void UpdateEmp(tbl_employee emp)
        {
            EFDal dal = new EFDal();
            dal.UpdateEmp(emp);
        }
    }
}
