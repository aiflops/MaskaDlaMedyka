﻿using System.Web.Optimization;

namespace MDMProject
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/scripts/main")
                .Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/modernizr-*"
                ));

            bundles.Add(
                new ScriptBundle("~/scripts/validation")
                .Include(
                    "~/Scripts/jquery.validate*"
                ));

            bundles.Add(
                new StyleBundle("~/css/main")
                .Include(
                    "~/Content/bootstrap.css",
                    "~/Content/bootstrap-theme.css",
                    "~/Content/style.css"
                ));
        }
    }
}