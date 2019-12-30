using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StarterKit.Common
{
    public class CommonUtils
    {

        public string GetCurrentDateString(string outputDateFormat)
        {
            return DateTime.Now.ToString(outputDateFormat);
        }

        public string ConvertDateFormat(string inputDate, string inputDateFormat, string outputDateFormat)
        {
            if (inputDate == null || inputDate.Length == 0) return "";

            try
            {
                return DateTime.ParseExact(inputDate, inputDateFormat, CultureInfo.InvariantCulture).ToString(outputDateFormat);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return "";
            }
        }

        public string ConvertTimeStampToDate(string strDatetimestamp, string outputDateFormat)
        {
            if (strDatetimestamp == null && strDatetimestamp.Length == 0) return "";

            try
            {
                long datetimestamp = Convert.ToInt64(strDatetimestamp);

                DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(datetimestamp);
                return dt.ToString(outputDateFormat);
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
