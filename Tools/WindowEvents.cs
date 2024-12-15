using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXNotification.Tools
{
    public class WindowEvents
    {
        public static void SendToast(string title,string text) 
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText(title)
                .AddText(text)
                .Show();
        }
    }
}
