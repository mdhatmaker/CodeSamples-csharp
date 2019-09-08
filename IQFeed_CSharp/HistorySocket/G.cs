using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistorySocket
{
    enum MonthCodes { F = 1, G, H, J, K, M, N, Q, U, V, X, Z }          // CME month codes
    enum Interval { Minute = 60, Hour = 3600, Day = 86400 }             // IQFeed requires the Interval to be in seconds


    public static class G
    {
        public static string GetmYY(int m, int y)
        {
            string mc = ((MonthCodes)m).ToString();
            string ystr = y.ToString();
            int len = ystr.Length;
            return mc + ystr.Substring(len - 2);
        }

        public static string GetIQDate(DateTime dt)
        {
            return dt.ToString("yyyyMMdd");
        }

        public static string GetIQDateTime(DateTime dt)
        {
            return dt.ToString("yyyyMMdd HHmmss");
        }

    } // end of class
} // end of namespace
