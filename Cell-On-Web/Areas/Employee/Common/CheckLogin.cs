using Cell_On_Web.Areas.Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cell_On_Web.Areas.Employee.Common
{
    public class CheckLogin
    {
        private static EmployeeLogined E_Login;

        public static void SetEmployeeLogin(EmployeeLogined e)
        {
            E_Login = e;
        }

        public static EmployeeLogined GetEmployeeLogin()
        {
            return E_Login;
        }
    }
}