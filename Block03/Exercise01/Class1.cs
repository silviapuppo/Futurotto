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

                if (!IsFestivity(startDate))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsFestivity(DateTime date)
        {
            int[,] festivity = new int[11, 2];

            festivity[0, 0] = 1;  //Capodanno
            festivity[0, 1] = 1;
            festivity[1, 0] = 6;  //Epifania
            festivity[1, 1] = 1;
            festivity[2, 0] = 25; //Liberazione
            festivity[2, 1] = 4;
            festivity[3, 0] = 1;  //Lavoro
            festivity[3, 1] = 5;
            festivity[4, 0] = 2;  //Repubblica
            festivity[4, 1] = 6;
            festivity[5, 0] = 15; //Ferragosto
            festivity[5, 1] = 8;
            festivity[6, 0] = 1;  //Tutti i Santi
            festivity[6, 1] = 11;
            festivity[7, 0] = 8;  //Immacolata
            festivity[7, 1] = 12;
            festivity[8, 0] = 25; //Natale
            festivity[8, 1] = 12;
            festivity[9, 0] = 26; //Santo Stefano
            festivity[9, 1] = 12;
            festivity[10, 0] = HolyMondayGenerator(date.Year).Day;
            festivity[10, 1] = HolyMondayGenerator(date.Year).Month;

            if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }

            for (int row = 0; row < 11; row++)
            {
                if (date.Day == festivity[row, 0] && date.Month == festivity[row, 1])
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
