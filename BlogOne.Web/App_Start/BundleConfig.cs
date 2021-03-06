﻿using System.Web;
using System.Web.Optimization;

namespace BlogOne.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/editor").Include(
                      "~/Scripts/rangy/rangy-core.js",
                      "~/Scripts/rangy/rangy-cssclassapplier.js",
                      "~/Scripts/rangy/rangy-highlighter.js",
                      "~/Scripts/rangy/rangy-selectionsaverestore.js",
                      "~/Scripts/rangy/rangy-serializerjs",
                      "~/Scripts/rangy/rangy-textrange.js",
                      "~/Scripts/undo.js",
                      "~/Scripts/medium.js",
                      "~/Scripts/xmedium.js",
                      "~/Scripts/popover.js",
                      "~/Scripts/drafting.js",
                      "~/Scripts/editing.js"
                      ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/site.css",
                      "~/Content/setup.css"));
            bundles.Add(new StyleBundle("~/bundles/edtorcss").Include(
                      "~/Content/medium.css"));
        }
    }
}
