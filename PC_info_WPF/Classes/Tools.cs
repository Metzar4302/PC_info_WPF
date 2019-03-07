using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace PC_info_WPF.Classes
{
    public static class Tools
    {
        public static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                Console.WriteLine($"METHOD: {ex.TargetSite}");
                Console.WriteLine($"STACK TRACE: {ex.StackTrace}");
            }

            return result;
        }

        public static void OutputResult(string info, List<string> result)
        {
            if (info.Length > 0)
                Console.WriteLine(info);

            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; ++i)
                    Console.WriteLine(result[i]);
            }
        }

        public static string ListToString(List<string> ts)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in ts)
            {
                result.AppendLine(item);
            }

            return result.ToString().Substring(0, result.Length - 2);  // Delete last '\n'
        }
    }
}
