using System;
using GoogleAnalyticsTracker.WebAPI2;

namespace cooqies.googlan_filter.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
        Inherited = true, AllowMultiple = true)]
    public class GooglAnFilterAttribute : ActionTrackingAttribute
    {
        public GooglAnFilterAttribute() : base("UA-113333252-1")
        { }
    }
}
