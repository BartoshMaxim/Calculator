using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace Calculator.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                   "~/Scripts/jquery-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootsrap.css",
                "~/Content/bootsrap.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/bootsrapjs").Include(
                "~/Scripts/bootsrap*"));
            bundles.Add(new ScriptBundle("~/bundles/unobtrusive").Include(
                "~/Scripts/jquery.unobtrusive*"));
        }
    }
}