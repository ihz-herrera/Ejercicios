using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Transversal.Guards
{
    public static class Guard
    {
        #region Metodos de Extension
        public static string HasValue(this string value, string property)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del Cliente debe contener un valor", property);
            }
            return value;
        }
        public static string GreaterThan(this string value, int min, string property)
        {
            if (value.Length <= min)
            {
                throw new ArgumentException(
                    $"El nombre del Cliente debe ser mayo a {min} caracteres",
                    property);
            }

            return value;
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
