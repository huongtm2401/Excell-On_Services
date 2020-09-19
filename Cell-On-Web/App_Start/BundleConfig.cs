using System.Web;
using System.Web.Optimization;

namespace Cell_On_Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            /// ADMIN BOOSTRAP

            bundles.Add(new ScriptBundle("~/bundles/BS_Core_JS").Include(
                      "~/Vendor/Areas/jquery/jquery.min.js",
                      "~/Vendor/Areas/bootstrap/js/bootstrap.bundle.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/Public_Core").Include(
                      "~/Vendor/Areas/jquery-easing/jquery.easing.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/CustomerJS").Include(
                      "~/Scripts/Areas/sb-admin-2.min.js"
                ));

            bundles.Add(new StyleBundle("~/Style/Custom_Fonts").Include(
                      "~/Vendor/Areas/fontawesome-free/css/all.min.css"
                 ));

            bundles.Add(new StyleBundle("~/Style/Custom_Style").Include(
                      "~/Style/Areas/sb-admin-2.min.css"
                 ));
        }
    }
}
