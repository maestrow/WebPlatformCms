using System.Web;
using System.Web.Optimization;

namespace WebPlatformCms
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            string rootDir = "~/bower_components/";

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      rootDir + "jquery/dist/jquery.js",
                      rootDir + "jquery.validation/dist/jquery.validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      rootDir + "bootstrap/dist/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      rootDir + "bootstrap/dist/css/bootstrap.css",
                      "~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
