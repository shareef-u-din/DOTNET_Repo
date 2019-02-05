using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograms
{
    static class GetIntegerValue
    {
        public static int ParseInt(this string value, int defaultIntValue = Int32.MinValue)
        {

            int parseInt;
            if(int.TryParse(value,out parseInt))
            {
                return parseInt;
            }
            return defaultIntValue;
        }
        public static int? ParseNullableInt(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            return value.ParseInt();
        }

    }
}
