using System;

namespace PropertyApp.cs
{
    class Rectangle
    {
        private double width;
        private double height;
        public double Area()
        {
            return width * height;
        }
        //public Rectangle(double width, double height) // 생성자
        //{
        // this.width = width; this.height = height;
        //}
        // Getter
        public double GetWidth()
        {
            return width;
        }
        public double GetHeight()
        {
            return height;
        }

    }
    public double Width { get; set; } // Width 속성
    public double Height { get; set; } // Height
    class RectWithPropFull

    {
        private double width;
        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { if (value >= 0) height = value; }
        }
    }
}