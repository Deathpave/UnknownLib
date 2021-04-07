using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using UnknownLib.NetworkTools;

namespace UnknownLib.Managers
{
    public class NetworkManager
    {
        private Connectivity _connectivity = new Connectivity();
        private DHCP _dhcp = new DHCP();
        private DNS _dns = new DNS();

        #region Connectivity
        public string LocalPing()
        {
            return _connectivity.LocalPing(new StringBuilder(), new Ping());
        }

        public string TraceRoute(string ipaddress)
        {
            return _connectivity.Traceroute(ipaddress, new StringBuilder());
        }
        #endregion
        #region DHCP
        public string DisplayDhcpServerAddresses()
        {
            return _dhcp.DisplayDhcpServerAddresses(new StringBuilder());
        }
        #endregion
        #region DNS
        public string GetIpFromHostname(string url)
        {
            return _dns.GetIpFromHostname(url);
        }

        public string GetHostnameFromIp(string ip)
        {
            return _dns.GetHostnameFromIp(ip);
        }
        #endregion
    }
}
