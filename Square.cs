using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPL_APP
{
    /// <summary>
    /// Class for making square shapes.
    /// </summary>
    class Square : Shape
    {
        int width;
        public Square() : base()
        {
            width = 100;

        }

        /// <summary>
        /// Initializes Positions and colour of the instance variables.
        /// </summary>
        public Square(Color colour, int x, int y, int width) : base(colour, x, y)
        {

            this.width = width; //the only thing that is different from shape
        }

        /// <summary>
        /// Seter for the colours, size and positino of shape
        /// </summary>
        /// <param name="colour">Colour of the shape as an object of Color class</param>
        /// <param name="list">Size and position of the shape</param>
        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1]);
            this.width = list[2];

        }

        /// <summary>
        /// Draw the shape
        /// </summary>
        /// <param name="g">Graphic object where it's drawn</param>
        /// <param name="fill">Fill or no Fill for the shape</param>
        override
        public void draw(Graphics g, bool fill)
        {
            Pen p = new Pen(colour);
            SolidBrush b = new SolidBrush(colour);

            if (fill) g.FillRectangle(b, (x - width / 2), (y - width / 2), width, width);
            else g.DrawRectangle(p, (x - width / 2), (y - width / 2), width, width);


        }

        override
        public double calcArea()
        {
            return width * width;
        }

        override
        public double calcPerimeter()
        {
            return 2 * width + 2 * width;
        }
    }
}
