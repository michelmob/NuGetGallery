// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#pragma warning disable 0618
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace NuGetGallery {
    public partial class PagesController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected PagesController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PagesController Actions { get { return MVC.Pages; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Pages";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Contact = "Contact";
            public readonly string Terms = "Terms";
            public readonly string Privacy = "Privacy";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Contact = "~/Views/Pages/Contact.cshtml";
            public readonly string Home = "~/Views/Pages/Home.cshtml";
            public readonly string Privacy = "~/Views/Pages/Privacy.cshtml";
            public readonly string Terms = "~/Views/Pages/Terms.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_PagesController: NuGetGallery.PagesController {
        public T4MVC_PagesController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Contact() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Contact);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Terms() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Terms);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Privacy() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Privacy);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
#pragma warning restore 0618
