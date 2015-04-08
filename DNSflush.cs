using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DNSFlusher
{
    class DNSFlush
    {
        [DllImport("dnsapi.dll",EntryPoint="DnsFlushResolverCache")]
        private static extern UInt32 DnsFlushResolverCache ();

        public static void Flush() //This can be named whatever name you want and is the function you will call
        {
            UInt32 result = DnsFlushResolverCache();
            System.Console.WriteLine(result);
        }
            }
}
