using System.Web.Mvc;

namespace Cell_On_Web.Areas.Customer
{
    public class CustomerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Customer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Customer_default",
                "Customer/{controller}/{action}/{id}",
                new { action = "Index",Controller = "Home", id = UrlParameter.Optional },
                namespaces: new[] { "Cell_On_Web.Areas.Customer.Controllers" }
            );
        }
    }
}