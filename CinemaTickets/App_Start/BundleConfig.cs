using System.Web.Optimization;

namespace Cinema.Tickets
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/knockout.js")
                .Include("~/Scripts/knockout-{version}.js"));
        }
    }
}