namespace DependencyInjectionPropertyAndMethod
{
    public class EmployeeBL
    { 
     
        // method
            public IEmployeeDAL employeeDAL;
            public List<Employee> GetAllEmployees(IEmployeeDAL _employeeDAL)
             {
                 employeeDAL = _employeeDAL;
                 return employeeDAL.SelectAllEmployees();
             }
            
        // // property
     
       // private IEmployeeDAL employeeDAL;
       //public IEmployeeDAL employeeDataObject
        //{
           // set
           // {
           //     this.employeeDAL = value;
           // }
           // get
           // {
           //     if (employeeDataObject == null)
           //      {
          //           throw new Exception("Employee is not initialized");
          //       }
          //        else
          //        {
          //             return employeeDAL;
         //         }
         //      }
        //  }
        //   public List<Employee> GetAllEmployees()
       //   {
       //       return employeeDAL.SelectAllEmployees();
      //    }
      // }
      
      
      //constractor
      
      //public IEmployeeDAL employeeDAL;
      //public EmployeeBL(IEmployeeDAL employeeDAL)
      // {
      //    this.employeeDAL = employeeDAL;
     // }
     // public List<Employee> GetAllEmployees()
     // {
     //     return employeeDAL.SelectAllEmployees();
   }
}