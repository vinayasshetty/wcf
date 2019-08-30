using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EFDalLib;
namespace WCFLib
{
    
   [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        List<tbl_employee> GetAllEmps();

        [OperationContract]
        tbl_employee GetEmpById(int ecode);

        [OperationContract]
        void AddEmployee(tbl_employee emp);

        [OperationContract]
        void DeleteEmp(int ecode);

        [OperationContract]
        void UpdateEmp(tbl_employee emp);
    }


  
    
}
