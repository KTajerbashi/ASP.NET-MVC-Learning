﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Pro_1_MVC_Learning
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("HomeIndex", "", new { controller = "Home", action = "Index" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("HomeIndex1", "Index1", new { controller = "Home", action = "Index1" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("HomeNews", "News", new { controller = "Home", action = "News" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("HomeBlog", "Blogs", new { controller = "Home", action = "Blog" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("HomeAbout", "About", new { controller = "Home", action = "About" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("HomePanel", "Panel", new { controller = "Home", action = "Panel" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("HomeLogin", "Login", new { controller = "Home", action = "Login" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("FileIndex", "File/Index", new { controller = "File", action = "Index" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("FileRead", "FileRead", new { controller = "File", action = "Read" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("FileDownload", "FileDownload", new { controller = "File", action = "Download" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("FileUpload", "FileUpload", new { controller = "File", action = "Upload" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("IndexDB", "IndexDB", new { controller = "File", action = "IndexDB" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("UploadDB", "UploadDB", new { controller = "File", action = "UploadDB" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("DownloadDB", "DownloadDB", new { controller = "File", action = "DownloadDB" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });
            routes.MapRoute("DeleteDB", "DeleteDB", new { controller = "File", action = "DeleteDB" }, namespaces: new[] { "Pro_1_MVC_Learning.Controllers" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "Pro_1_MVC_Learning.Controllers" }
            //    );
            //  Admin Area
        }
    }
}
