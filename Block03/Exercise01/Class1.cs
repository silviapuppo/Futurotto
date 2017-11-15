using System;

namespace Exercise01
{
    public class Class1
    {

        public static int CountWorkDaysTill(DateTime startDate, DateTime endDate)
        {
            int count = 0;

            while ((startDate.Year != endDate.Year) || (startDate.Month != endDate.Month) || (startDate.Day != endDate.Day))
            {
                startDate = startDate.AddDays(1);

                if (!IsHoliday(startDate))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsHoliday(DateTime date)
        {
            int[,] holidays = new int[11, 2];

            holidays[0, 0] = 1;  //Capodanno
            holidays[0, 1] = 1;
            holidays[1, 0] = 6;  //Epifania
            holidays[1, 1] = 1;
            holidays[2, 0] = 25; //Liberazione
            holidays[2, 1] = 4;
            holidays[3, 0] = 1;  //Lavoro
            holidays[3, 1] = 5;
            holidays[4, 0] = 2;  //Repubblica
            holidays[4, 1] = 6;
            holidays[5, 0] = 15; //Ferragosto
            holidays[5, 1] = 8;
            holidays[6, 0] = 1;  //Tutti i Santi
            holidays[6, 1] = 11;
            holidays[7, 0] = 8;  //Immacolata
            holidays[7, 1] = 12;
            holidays[8, 0] = 25; //Natale
            holidays[8, 1] = 12;
            holidays[9, 0] = 26; //Santo Stefano
            holidays[9, 1] = 12;
            holidays[10, 0] = HolyMondayGenerator(date.Year).Day;
            holidays[10, 1] = HolyMondayGenerator(date.Year).Month;

            if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }

            for (int row = 0; row < 11; row++)
            {
                if (date.Day == holidays[row, 0] && date.Month == holidays[row, 1])
                {
                    return true;
                }
            }

            return false;
        }

        private static DateTime HolyMondayGenerator(int year)
        {
            //Easter calculator
            int day = 0;
            int month = 0;

            int g = year % 19;
            int c = year / 100;
            int h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25) + 19 * g + 15) % 30;
            int i = h - (int)(h / 28) * (1 - (int)(h / 28) * (int)(29 / (h + 1)) * (int)((21 - g) / 11));

            day = i - ((year + (int)(year / 4) + i + 2 - c + (int)(c / 4)) % 7) + 28;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            //Add one day to obtain
            return new DateTime(year, month, day).AddDays(1);

        }

    }
}
