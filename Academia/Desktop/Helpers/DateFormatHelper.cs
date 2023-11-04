using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Helpers
{
    public static class DateFormatHelper
    {
        public static int? ParseInput(string inputText, DateInputType dateInputType) {
            if (!int.TryParse(inputText, out _)) return null;

            var number = int.Parse(inputText);
            switch (dateInputType)
            {
                case DateInputType.Day: return (number >= 1 && number <= 31) ? number : null;
                case DateInputType.Month: return (number >= 1 && number <= 12) ? number : null;
                case DateInputType.Year: return (number >= 1900 && number <= DateTime.Now.Year) ? number : null;
                default: return null;
            }
        }

        public static bool IsValidDate(string day, string month, string year) {
            return ParseInput(day, DateInputType.Day) is not null
                && ParseInput(month, DateInputType.Month) is not null
                && ParseInput(year, DateInputType.Year) is not null;
        }
    }

    public enum DateInputType {
        Day,
        Month,
        Year,
    }
}
