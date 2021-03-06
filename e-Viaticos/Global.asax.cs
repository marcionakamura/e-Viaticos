﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace e_Viaticos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //---->Please set chatty values into session variables<------
            //Required Fields

            Session["UserLogin"] = Request.QueryString["UserLogin"];      //cookies.strUserID
            Session["StepName"] = Request.QueryString["StepName"];       //tasks.GetTaskXMLElement("Keywords.StepLabel").ToString
            Session["UltimusNumber"] = Request.QueryString["UltimusNumber"];  //Convert.ToInt32(tasks.GetTaskXMLElement("Keywords.IncidentNumber
            Session["ProcessSummary"] = Request.QueryString["ProcessSummary"]; //tasks.GetTaskXMLElement("Keywords.IncidentSummary").ToString();

        }

    }
}
