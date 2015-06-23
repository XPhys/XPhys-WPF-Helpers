using System;
using System.Net.NetworkInformation;

namespace XPhys.Common.Helpers.Hardwares
{
    public class MACAddress
    {
        /// <summary>
        /// OBJECTIVE: Get MAC address of network card
        /// REFERENCE: http://stackoverflow.com/questions/850650/reliable-method-to-get-machines-mac-address-in-c-sharp
        /// </summary>
        /// <returns></returns>
        public static string GetMacAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

    }
}
