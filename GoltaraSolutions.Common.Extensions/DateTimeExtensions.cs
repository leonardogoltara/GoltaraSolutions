using System;

namespace GoltaraSolutions.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime FirstHourOfDay(this DateTime d)
        {
            DateTime dRtn = d;
            dRtn = new DateTime(dRtn.Year, dRtn.Month, dRtn.Day);
            return dRtn;
        }
        public static DateTime FirstDayOfMonth(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, 1);
        }
        public static DateTime DateHourMinute(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, 0);
        }
        public static DateTime LastHourOfDay(this DateTime d)
        {
            DateTime dRtn = d;
            dRtn = dRtn.AddHours(23 - dRtn.Hour).AddMinutes(59 - dRtn.Minute).AddSeconds(59 - dRtn.Second).AddMilliseconds(997 - dRtn.Millisecond);
            return dRtn;
        }
        public static DateTime LastDayOfMonth(this DateTime d)
        {
            DateTime dRtn = new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month));
            return dRtn.LastHourOfDay();
        }
        public static DateTime AddWorkingDays(this DateTime d, int Days)
        {
            //Cria variável contador de dias uteis passados...            
            int i = 0;

            //laço de repetição pra todos os dias, no caso 3
            while (i < Days)
            {
                //Verifica qual é o dia da semana da variável date
                switch (d.DayOfWeek)
                {
                    //se for sábado, pula 2 dias, ou seja, para segunda e continua a contagem do while.
                    case DayOfWeek.Saturday:
                        d = d.AddDays(2);
                        break;
                    //se for domingo, pula 1 dia, ou seja, para segunda e continua a contagem do while.
                    case DayOfWeek.Sunday:
                        d = d.AddDays(1);
                        break;
                    //caso seja qualquer dia diferente de sabado e domingo,  pula 1 dia e adiciona 1 na variável i que representa os dias úteis pulados                   
                    default:
                        d = d.AddDays(1);
                        i++;
                        break;
                }
            }
            //exibe a data.
            return d;
        }
        public static int GetWorkingDaysDiff(this DateTime initialDate, DateTime finalDate)
        {
            int days = 0;
            int daysCount = 0;
            days = initialDate.Subtract(finalDate).Days;

            //Módulo
            if (days < 0)
                days = days * -1;
            for (int i = 1; i <= days; i++)
            {
                initialDate = initialDate.AddDays(1);
                //Conta apenas dias da semana.
                if (initialDate.DayOfWeek != DayOfWeek.Sunday &&
                    initialDate.DayOfWeek != DayOfWeek.Saturday)
                    daysCount++;
            }
            return daysCount;
        }
        public static bool HasValue(this DateTime d)
        {
            if (d != null && d.Year > 1800)
                return true;

            return false;
        }
    }
}
