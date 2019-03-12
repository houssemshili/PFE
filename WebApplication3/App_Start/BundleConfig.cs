using System.Web;
using System.Web.Optimization;

namespace WebApplication3
{
	public class BundleConfig
	{
		// Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Content/js/*.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/*.css"));
		}
	}
}
