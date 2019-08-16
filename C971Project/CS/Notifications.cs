using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace C971Project.CS
{
    public class Notifications
    {
        
        public static void sendNotifcationNow()
        {
            CrossLocalNotifications.Current.Show("WGU Degree Planner", "Test Notification");
            
        }
    }


}
