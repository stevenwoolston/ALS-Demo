using System.Web;
using System.Web.Optimization;

namespace Demo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //  =================================
            //  Scripts
            bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.validate.js"));

            //  Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include(
                        "~/js/bootstrap*"));

            //  Controls
            bundles.Add(new ScriptBundle("~/bundles/js/controls").Include(
                        "~/js/jquery.dataTables.js",
                        "~/js/DataTables.js",
                        "~/js/ColReorder.js",
                        "~/js/ColVis.js",
                        "~/Scripts/toastr.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/js/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //  =================================
            //  =================================
            //  Styles

            //  Bootstrap
            bundles.Add(new StyleBundle("~/bundles/css/bootstrap").Include(
                        "~/css/bootstrap*",
                        "~/css/font-awesome*",
                        "~/css/ColReorder.css",
                        "~/css/ColVis.css",
                        "~/Content/toastr.css"));

            //  JQuery
            bundles.Add(new StyleBundle("~/bundles/css/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/bundles/css/site").Include(
                        "~/css/global.css",
                        "~/css/webtrieve.css"));

        }
    }
}