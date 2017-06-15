using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WMS
{
    class GetUserLogInfo
    {
        public static string hostName = Dns.GetHostName();
        public static string GetMacAddress()
        {
            // Reference - Add Reference - Framework - System.Management
            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("Select * FROM Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMOS.Get();
            string macAddress = String.Empty;
            foreach (ManagementObject objMO in objMOC)
            {
                object tempMacAddrObj = objMO["MacAddress"];
                if (tempMacAddrObj == null)
                {
                    continue;
                }
                if (macAddress == String.Empty)
                {
                    macAddress = tempMacAddrObj.ToString();
                }
                objMO.Dispose();
            }
            macAddress = macAddress.Replace(":", "");
            return macAddress;
        }

        public static string GetLocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        public static string GetRealIPAddress()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        public static int Company()
        {
            int CompanyID = 0;

            if (GetUserLogInfo.GetMacAddress() == "408D5C3D4380")
            {
               CompanyID = 100;        // Kamrul-PC
            }
            else if (GetUserLogInfo.GetMacAddress() == "408D5C3D42D4")
            {
               CompanyID = 101;        // Kamrul-PC
            }
            else if (GetUserLogInfo.GetMacAddress() == "1C1B0DA84A7E")
            {
               CompanyID = 102;        // China-PC
            }
            else if (GetUserLogInfo.GetMacAddress() == "C4346B49882E")
            {
                CompanyID = 103;        // MOHON-PC home
            }
            else if(GetUserLogInfo.GetMacAddress() == "DC4A3E548431")
            {
                CompanyID = 104;
            }
            else
            {
                CompanyID = 420;        // Un authorized pc
            }
            // int CompanyID = 5;        // SERVER
            // int CompanyID = 29;       // Front/Sales PC
            // int CompanyID = 14;       // VAT PC
            // int CompanyID = 23;       // Spears Parts
            // int CompanyID = 61;       //
            return CompanyID;
        }
    }
}