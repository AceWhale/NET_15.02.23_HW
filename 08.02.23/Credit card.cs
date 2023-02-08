using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02._23
{
    internal class Credit_card
    {
        public string NumCard { get; set; } = null;
        public string Name { get; set; } = null;
        public int? CVV { get; set; } = null;
        public string Date { get; set; } = null;
        public Credit_card() { }
        public Credit_card(string numCard, string name, int? cVV, string date)
        {
            NumCard = numCard;
            Name = name;
            CVV = cVV;
            Date = date;
        }

        public override string ToString()
        {
            return $"Fullname: {Name}\nCard number: {NumCard}\nDate: {Date}\nCVV{CVV}\n";
        }
    }
}
