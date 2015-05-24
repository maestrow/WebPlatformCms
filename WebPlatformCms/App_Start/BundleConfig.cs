using System.Web;
using System.Web.Optimization;

namespace WebPlatformCms
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            string bower = "~/client/bower_components/";
            string vendor = "~/client/vendor/";

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      bower + "jquery/dist/jquery.js",
                      bower + "jquery.validation/dist/jquery.validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      bower + "bootstrap/dist/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                vendor + "jqwidgets/styles/jqx.base.css",
                vendor + "jqwidgets/styles/jqx.arctic.css",
                vendor + "jqwidgets/styles/jqx.black.css",
                vendor + "jqwidgets/styles/jqx.bootstrap.css",
                vendor + "jqwidgets/styles/jqx.classic.css",
                vendor + "jqwidgets/styles/jqx.darkblue.css",
                vendor + "jqwidgets/styles/jqx.energyblue.css",
                vendor + "jqwidgets/styles/jqx.fresh.css",
                vendor + "jqwidgets/styles/jqx.highcontrast.css",
                vendor + "jqwidgets/styles/jqx.metro.css",
                vendor + "jqwidgets/styles/jqx.metrodark.css",
                vendor + "jqwidgets/styles/jqx.office.css",
                vendor + "jqwidgets/styles/jqx.orange.css",
                vendor + "jqwidgets/styles/jqx.shinyblack.css",
                vendor + "jqwidgets/styles/jqx.summer.css",
                vendor + "jqwidgets/styles/jqx.web.css",
                vendor + "jqwidgets/styles/jqx.ui-darkness.css",
                vendor + "jqwidgets/styles/jqx.ui-lightness.css",
                vendor + "jqwidgets/styles/jqx.ui-le-frog.css",
                vendor + "jqwidgets/styles/jqx.ui-overcast.css",
                vendor + "jqwidgets/styles/jqx.ui-redmond.css",
                vendor + "jqwidgets/styles/jqx.ui-smoothness.css",
                vendor + "jqwidgets/styles/jqx.ui-start.css",
                vendor + "jqwidgets/styles/jqx.ui-sunny.css",      
                bower + "bootstrap/dist/css/bootstrap.css",
                "~/client/css/site.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqwidgets").Include(
                vendor + "jqwidgets/jqxcore.js",
                vendor + "jqwidgets/jqxdata.js",
                vendor + "jqwidgets/jqxgrid.js",
                vendor + "jqwidgets/jqxgrid.selection.js",
                vendor + "jqwidgets/jqxgrid.pager.js",
                vendor + "jqwidgets/jqxlistbox.js",
                vendor + "jqwidgets/jqxbuttons.js",
                vendor + "jqwidgets/jqxscrollbar.js",
                vendor + "jqwidgets/jqxdatatable.js",
                vendor + "jqwidgets/jqxtreegrid.js",
                vendor + "jqwidgets/jqxmenu.js",
                vendor + "jqwidgets/jqxcalendar.js",
                vendor + "jqwidgets/jqxgrid.sort.js",
                vendor + "jqwidgets/jqxgrid.filter.js",
                vendor + "jqwidgets/jqxdatetimeinput.js",
                vendor + "jqwidgets/jqxdropdownlist.js",
                vendor + "jqwidgets/jqxslider.js",
                vendor + "jqwidgets/jqxeditor.js",
                vendor + "jqwidgets/jqxinput.js",
                vendor + "jqwidgets/jqxdraw.js",
                vendor + "jqwidgets/jqxchart.core.js",
                vendor + "jqwidgets/jqxchart.rangeselector.js",
                vendor + "jqwidgets/jqxtree.js",
                vendor + "jqwidgets/globalize.js",
                vendor + "jqwidgets/jqxbulletchart.js",
                vendor + "jqwidgets/jqxcheckbox.js",
                vendor + "jqwidgets/jqxradiobutton.js",
                vendor + "jqwidgets/jqxvalidator.js",
                vendor + "jqwidgets/jqxpanel.js",
                vendor + "jqwidgets/jqxpasswordinput.js",
                vendor + "jqwidgets/jqxnumberinput.js",
                vendor + "jqwidgets/jqxcombobox.js"
                ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
