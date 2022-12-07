using MyApp.Consultorio.Consola.Enums.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Consola.Enums
{
    public class CardType
    : Enumeration
    {


        public static readonly CardType Amex = new(1, nameof(Amex));
        public static readonly CardType Visa = new(2, nameof(Visa));
        public static readonly CardType MasterCard = new(3, nameof(MasterCard));

        public CardType(int id, string name)
            : base(id, name)
        {
        }
    }
}
