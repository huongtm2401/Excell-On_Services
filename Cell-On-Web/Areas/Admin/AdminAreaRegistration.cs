using System.Web.Mvc;

namespace Cell_On_Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index",Controller="Home", id = UrlParameter.Optional },
                namespaces: new[] { "Cell_On_Web.Areas.Admin.Controllers" }
            );
        }
    }
}