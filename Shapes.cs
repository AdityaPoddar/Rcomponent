using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPL_APP
{
    /// <summary>
    /// Interface for the all the shapes.
    /// </summary>
    interface Shapes
    {
        /// <summary>
        /// Seter for the colours, size and positino of shape
        /// </summary>
        /// <param name="colour">Colour of the shape</param>
        /// <param name="list">Size and position of the shape</param>
        void set(Color colour, params int[] list);
        /// <summary>
        /// Set the starting position where it needs to be drawn from.
        /// </summary>
        /// <param name="list"></param>
        void setStartPoint(params int[] list);
        /// <summary>
        /// Pen or brush colour used for drawing the shape
        /// </summary>
        /// <param name="colour"></param>
        void setColour(Color colour);
        /// <summary>
        /// Draw the shape
        /// </summary>
        /// <param name="g">Graphic object where it's drawn</param>
        /// <param name="fill">Fill or no Fill for the shape</param>
        void draw(Graphics g, bool fill);
        double calcArea();
        double calcPerimeter();

        //need to remove setstartPoint, setcolour, and setFill;
    }
}
