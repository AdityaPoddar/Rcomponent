using System;

namespace GPL_APP
{
    /// <summary>
    /// Factory class for making all the shapes.
    /// </summary>
    class ShapeFactory
    {
        /// <summary>
        /// Returns the required shape with name of the shape as a string.
        /// </summary>
        /// <param name="shapeType">Name of the shape as a string.</param>
        /// <returns></returns>
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToUpper().Trim(); //you could argue that you want a specific word string to create an object but I'm allowing any case combination


            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            if (shapeType.Equals("RECT"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }
            else if (shapeType.Equals("TRIANGLE"))
            {
                return new Triangle();
            }
            else if(shapeType.Equals("POLYGON"))
            {
                return new Polygon();
            }
            else
            {
                return null;

            }


        }

    }
}
