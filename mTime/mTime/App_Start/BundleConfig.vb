﻿Imports System.Web.Optimization

Public Module BundleConfig

    ' For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                   "~/Scripts/bootstrap-datepicker3.js",
                  "~/Scripts/srs.js"))
                  
        bundles.Add(New ScriptBundle("~/bundles/tokenize").Include(
                  "~/Scripts/tokenize2.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/bootstrap.min.css",
                  "~/Content/bootstrap-datepicker3.css",
                  "~/Content/font-awesome.css",
                  "~/Content/other_style.css",
                  "~/Content/style.css",
                  "~/Content/tokenize2.css"))
    End Sub

End Module