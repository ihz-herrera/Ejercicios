using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Consola
{
    internal static class Extenciones
    {
        public static List<T> WhereTo<T>(this List<T> lista, Func<T, bool> action)
        {
            var resultado = new List<T>();
            foreach (var item in lista)
            {
                if (action(item))
                {
                    resultado.Add(item);    
                }
            }
            return resultado;
        }

        public static CustomIntEnumerator GetEnumerator(this Range range)
        {
            return new CustomIntEnumerator(range);
        }

        public ref struct CustomIntEnumerator
        {
            private int _current;
            private readonly int _end;

            public CustomIntEnumerator(Range range)
            {
                if (range.End.IsFromEnd)
                {
                    throw new NotSupportedException();
                }

                _current = range.Start.Value - 1;
                _end = range.End.Value;
            }

            public int Current => _current;

            public bool MoveNext()
            {
                _current++;
                return _current <= _end;
            }
        }



    }
}
