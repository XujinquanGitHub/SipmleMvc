﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipmleMvc.Routing
{
    public class RouteData
    {
        public RouteData()
        {
            RouteValues = new Dictionary<string, object>();
        }
        public IRouteHandler RouteHandler { get; set; }

        public Dictionary<string, object> RouteValues { get; set; }
    }
}
