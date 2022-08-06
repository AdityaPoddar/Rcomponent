using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPL_APP
{
    class Triangle : Shape
    {
        int width, height;
        public Triangle() : base()
        {
            Console.WriteLine("rect obj created");
            width = 100;
            height = 100;
        }
        public Triangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.width = width; //the only thing that is different from shape
            this.height = height;
        }

        /// <summary>
        /// Seter for the colours, size and positino of shape triangle
        /// </summary>
        /// <param name="colour">Colour of the shape as an object of Color class</param>
        /// <param name="list">Size and position of the shape</param>
        public override void set(Color colour, params int[] list)
        {

            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.height = list[3];

        }

        /// <summary>
        /// Draw the shape
        /// </summary>
        /// <param name="g">Graphic object where it's drawn</param>
        /// <param name="fill">Fill or no Fill for the shape</param>
        override
        public void draw(Graphics g, bool fill)
        {
            Pen p = new Pen(base.colour, 2);
            SolidBrush b = new SolidBrush(base.colour);
            int xPos = x - width / 2;
            int yPos = y + height / 2;

            if(fill)
                g.FillPolygon(b, new Point[] { new Point(xPos, yPos), new Point(x + width/2, yPos), new Point(x, y - height / 2) });
            else
                g.DrawPolygon(p, new Point[] { new Point(xPos, yPos), new Point(x + width / 2, yPos), new Point(x, y - height / 2) });

            Console.WriteLine("this is the base colour" + base.colour);
        }

        override
        public double calcArea()
        {
            return width * height;
        }

        override
        public double calcPerimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}
