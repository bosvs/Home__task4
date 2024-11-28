using System;

namespace FirstCA
{
    class River : GeographycalObject
    {
        private double _flowSpeed;
        private double _length;

        public double FlowSpeed
        {
            get { return _flowSpeed; }
            set { _flowSpeed = (value >= 0 && value <= 500) ? value : 0; }
        }

        public double Length
        {
            get { return _length; }
            set { _length = (value >= 20) ? value : 20; }
        }

        // Перевизначення методу для виведення інформації
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Flow speed of the river is {FlowSpeed} cm/s");
            Console.WriteLine($"{Name} total length is {Length} meters");
        }
    }
}
