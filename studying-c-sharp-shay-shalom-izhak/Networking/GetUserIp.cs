using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Networking
{
    public class GetUserIp
    {
        public static void DemoMain()
        {
            try
            {
                string hostName = Dns.GetHostName();
                Console.WriteLine("Host Name: " + hostName);

                IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);

                Console.WriteLine("IP Addresses:");
                foreach (IPAddress ipAddress in ipAddresses)
                {
                    // Print only IPv4 addresses
                    if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Console.WriteLine(ipAddress.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}
