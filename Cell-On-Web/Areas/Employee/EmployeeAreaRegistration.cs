using System.Web.Mvc;

namespace Cell_On_Web.Areas.Employee
{
    public class EmployeeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Employee";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Employee_default",
                "Employee/{controller}/{action}/{id}",
                new { action = "Index",Controller="Home", id = UrlParameter.Optional },
                namespaces: new[] { "Cell_On_Web.Areas.Employee.Controllers" }
            );
        }
    }
}