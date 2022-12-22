using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Transversal.Guards
{
    public static class Guard
    {
        #region Metodos de Extension
        public static string HasValue(this string value, [CallerArgumentExpression("value")] string property="")
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del Cliente debe contener un valor", property);
            }
            return value;
        }
        public static string GreaterThan(this string value, int min, [CallerArgumentExpression("value")] string property = "")
        {
            if (value.Length <= min)
            {
                throw new ArgumentException(
                    $"El nombre del Cliente debe ser mayo a {min} caracteres",
                    property);
            }

            return value;
        }

        public static string IsId(this string value, [CallerArgumentExpression("value")] string property = "")
        {
            if(value.Length != Guid.NewGuid().ToString().Length)
                throw new ArgumentException("Id invalido", property);


            return value;
        }

        public static int Between(this int value,int min, int max, [CallerArgumentExpression("value")] string property = "")
        {
            if (value>= min && value <= max)
                throw new ArgumentException("Valor no permitido", property);


            return value;
        }

        public static DateTime HourBetween(this DateTime value, int min, int max, [CallerArgumentExpression("value")] string property = "")
        {
            if (value.Hour >= min && value.Hour <= max)
                throw new ArgumentException("Valor no permitido", property);


            return value;
        }


        public static DateTime? NotNull(this DateTime? value, [CallerArgumentExpression("value")] string property = "")
        {
            if (value is null)
                throw new ArgumentException("La fecha debe contener un valor",property);

            return value;
        }

        public static DateTime LaborDays(this DateTime value,bool includeSaturday=true, [CallerArgumentExpression("value")] string property = "")
        {
            if (value.DayOfWeek == DayOfWeek.Sunday || (value.DayOfWeek == DayOfWeek.Saturday && includeSaturday))
                throw new ArgumentException("La fecha fuera de horario laboral", property);

            return value;
        }

        public static DateTime AfterNow(this DateTime value,Period periodo = Period.Hour, [CallerArgumentExpression("value")] string property = "")
        {
            var newDate = periodo switch
            {
                Period.Hour  => value.AddHours(1),
                Period.Day => value.AddDays(1),
                Period.Month => value.AddMonths(1),
                Period.Year => value.AddYears(1),
                _ => throw new ArgumentException("Opción fuera del indice",nameof(periodo))
            };

            if (newDate >= DateTime.Now)
                throw new ArgumentException("Fecha fuera del intervalo", property);

            return value;


        }


        public enum Period
        {
            Hour,Day,Month,Year
        }

        #endregion

        #region Metodos Estaticos
        public static class Against
        {
            public static string NotNull(string value, string property)
            {
                if (String.IsNullOrWhiteSpace(value) && value.Length > 2)
                {
                    throw new ArgumentException("El nombre del Cliente debe contener un valor",property);
                }
                return value;
            }
            public static string GreaterThan(string value,int min, string property)
            {
                if (value.Length < min)
                {
                    throw new ArgumentException(
                        $"El nombre del Cliente debe ser mayo a {min} caracteres",
                        property);
                }
                return value;
            }
        }
        #endregion
    }
}
