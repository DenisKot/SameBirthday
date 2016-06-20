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

        public static string GetMonth(int month)
        {
            switch (month)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";

                default: return null;
            }
        }

        public static string GetMonthTitle(int month)
        {
            switch (month)
            {
                case 1: return "января";
                case 2: return "февраля";
                case 3: return "марта";
                case 4: return "апреля";
                case 5: return "мая";
                case 6: return "июня";
                case 7: return "июля";
                case 8: return "августа";
                case 9: return "сентября";
                case 10: return "октября";
                case 11: return "ноября";
                case 12: return "декабря";

                default: return null;
            }
        }
    }
}