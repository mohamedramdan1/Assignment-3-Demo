using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Demo.Inhertance
{
    internal class Parent
    {
        #region property
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        public Parent(int _x, int _y)
        {
            X = _x;
            Y = _y;
        } 
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        public int product()
        {
            return X * Y;
        } 
        #endregion

    }
}
