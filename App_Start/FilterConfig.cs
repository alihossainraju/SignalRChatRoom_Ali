using System.Web;
using System.Web.Mvc;

namespace SignalRChatRoom_Ali
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
