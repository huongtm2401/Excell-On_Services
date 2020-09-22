using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cell_On_Web.Areas.Employee.Model
{
    public class EmployeeLogined
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public int DepartmentId { get; set; }
    }
}