using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hw_01_07_
{
    public class Journal
    {
        public string Title {  get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        private string _date;
        public string Date
        {
            get { return _date; }
            set
            {
                if(RegexDate.IsMatch(value))
                {
                    _date = value;
                }
                else
                {
                    throw new ArgumentException("Date must be: mm.dd.yyyy");
                }
            }
        }
        public Journal()
        {

        }
        public Journal (string title, string publisher, string date, int pages)
        {
            Title = title;
            Publisher = publisher;
            Date = date;
            Pages = pages;
        }

        private static Regex RegexDate = new Regex(@"^\d{2}\.\d{2}\.\d{4}$");
        public override string ToString()
        {
            return $"{Title},{Publisher},{Date},{Pages}";
        }
    }
}
