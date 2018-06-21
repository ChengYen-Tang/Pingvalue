using System.Web;
using System.Web.Optimization;

namespace Pingvalue
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.easing.1.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.bundle.min.js",
                    "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/sb-admin").Include(
                    "~/Scripts/sb-admin/sb-admin.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                    "~/Scripts/dataTables/dataTables.bootstrap4.js",
                    "~/Scripts/dataTables/jquery.dataTables.js"));

            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                    "~/Scripts/chart.js/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/sb-Admin-chart").Include(
                    "~/Scripts/sb-admin/sb-admin-datatables.min.js",
                    "~/Scripts/sb-admin/sb-admin-charts.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/sb-admin/sb-admin.css",
                      "~/Content/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/dataTables").Include(
                      "~/Content/dataTables/dataTables.bootstrap4.css"));
        }
    }
}
