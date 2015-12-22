using System.Collections.Generic;

namespace XmasCodeKata8.Controllers
{
    public class TwelveDaysCarol
    {
        private readonly List<string> _days = new List<string>();

        public TwelveDaysCarol()
        {
            _days.Add("Partridge in a Pear Tree");
            _days.Add("Two Turtle Doves");
            _days.Add("Three French Hens");
            _days.Add("Four 4 Calling Birds");
            _days.Add("Five Gold Rings");
            _days.Add("Six Geese a-Laying");
            _days.Add("Seven Swans a-Swimming");
            _days.Add("Eight Maids a-Milking");

        }
        public string Day(int day)
        {
            if (day < 1 || day > _days.Count)
                return "Nothing";

            return _days[day - 1];
        }
    }
}