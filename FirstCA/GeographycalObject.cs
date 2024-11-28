using System;

namespace FirstCA
{
    internal abstract class GeographycalObject
    {
        private string _name = "Unknown";
        private double _x;
        private double _y;
        private string _description = "Description is empty";

        public string Name
        {
            get { return _name; }
            set { if (!string.IsNullOrEmpty(value)) _name = value; }
        }

        public double X
        {
            get { return _x; }
            set { _x = (value >= -90 && value <= 90) ? value : 0; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = (value >= -180 && value <= 180) ? value : 0; }
        }

        public string Description
        {
            get { return _description; }
            set { if (!string.IsNullOrEmpty(value)) _description = value; }
        }

        // Абстрактний метод, який реалізується в нащадках
        public virtual void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Location - x: {X}; y: {Y}");
            Console.WriteLine(Description);
        }
    }
}
