using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Credit_card credit_Card = new Credit_card();
            try
            {
                Console.Write("Введите ФИО: ");
                credit_Card.Name = Console.ReadLine();
                if (credit_Card.Name == "")
                    throw new Exception("Введен неверное ФИО");
                Console.Write("Введите номер карты: ");
                credit_Card.NumCard = Console.ReadLine();
                if (credit_Card.NumCard.Length > 17)
                    throw new Exception("Введен неверный номер карты");
                else if (credit_Card.NumCard.IndexOf(" ") != -1)
                    throw new Exception("Введен неверный номер карты");
                else if (credit_Card.NumCard.Length < 16)
                    throw new Exception("Введен неверный номер карты");
                Console.Write("Введите срок карты (формат MM.YYYY): ");
                credit_Card.Date = Console.ReadLine();
                if (credit_Card.Date.Length < 6 || credit_Card.Date.Length < 7)
                    throw new Exception("Введен неверный срок");
                string month_buf = credit_Card.Date[0].ToString() + credit_Card.Date[1].ToString();
                string year_buf = credit_Card.Date[3].ToString() + credit_Card.Date[4].ToString()
                    + credit_Card.Date[5].ToString() + credit_Card.Date[6].ToString();
                int month = Convert.ToInt32(month_buf);
                int year = Convert.ToInt32(year_buf);
                if (year < DateTime.Now.Year)
                    throw new Exception("карта просрочена");
                else if(month < DateTime.Now.Month)
                    throw new Exception("карта просрочена");
                Console.Write("Введен CVV код: ");
                credit_Card.CVV = Convert.ToInt32(Console.ReadLine());
                if(credit_Card.CVV.ToString().Length > 3 || credit_Card.CVV.ToString().Length < 3)
                    throw new Exception("Введен неверный код");
                Console.WriteLine("\n");
                Console.WriteLine(credit_Card);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }
}
