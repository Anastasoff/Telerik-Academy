﻿namespace ForumSystem.Web
{
    using System.Web;
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/voting").Include(
                      "~/Scripts/Voting/vote.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                      "~/Scripts/Kendo/kendo.all.min.js",
                      "~/Scripts/Kendo/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.cosmo.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Kendo").Include(
                      "~/Content/Kendo/kendo.common.min.css",
                      "~/Content/Kendo/kendo.common-bootstrap.min.css",
                      "~/Content/Kendo/kendo.black.min.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
