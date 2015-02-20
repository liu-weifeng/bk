using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace bk
{
    
    class DiskManger
    {

        public static int Main(string[] args)
        {
            SelectQuery selectQuery = new SelectQuery("Win32_LogicalDisk");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);

            foreach (ManagementObject disk in searcher.Get())
            {
                Console.WriteLine(disk.ToString());
            }
            Console.ReadLine();
            return 0;
        }
    }
}
