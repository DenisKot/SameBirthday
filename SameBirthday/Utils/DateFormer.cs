using System;
using System.Globalization;

namespace SameBirthday.Utils
{
    public static class DateFormer
    {
        public static string Get(int day, int month, int year)
        {
            var date = new DateTime(year, month, day);
            return $"{date.ToString("dd MMMM yyyy", new CultureInfo("ru-RU"))} года";
        }
    }
}