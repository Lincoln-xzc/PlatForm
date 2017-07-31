using System.Web.Optimization;

namespace platform.App_Start
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-1.10.1.min.js",
                  "~/Scripts/cookie.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/respond.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/cheditor").Include(
                  "~/Scripts/cheditor.js"));

      bundles.Add(new ScriptBundle("~/bundles/migrate").Include(
                  "~/Scripts/jquery-migrate-{version}.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/cookie").Include(
                  "~/Scripts/jquery.cookie.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include(
                  "~/Scripts/jquery.slimscroll.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/blockui").Include(
                  "~/Scripts/jquery.blockui.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/uniform").Include(
                  "~/Scripts/jquery.uniform.min.js"));

      bundles.Add(new StyleBundle("~/Content/maincss").Include(
                  "~/Content/css/bootstrap.min.css",
                  "~/Content/css/bootstrap-responsive.min.css",
                  "~/Content/css/font-awesome.min.css",
                  "~/Content/css/style-metro.css",
                  "~/Content/css/style.css",
                  "~/Content/css/style-responsive.css",
                  "~/Content/css/default.css",
                  "~/Content/css/uniform.default.css"));

    }
  }
}