using System;

namespace FirstCA
{
    class Mountain : GeographycalObject
    {
        private double _peak;

        public double Peak
        {
            get { return _peak; }
            set { _peak = (value >= 0) ? value : 0; }
        }

        // Перевизначення методу для виведення інформації
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The highest point of the {Name} is {Peak} meters");
        }
    }
}
