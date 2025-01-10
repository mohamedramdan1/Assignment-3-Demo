using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Demo.Inhertance
{
    internal class child:Parent
    {
        #region property 
        public int Z { get; set; }
        // note here are child inhertance from parent mean child have 3 property 
        // int X
        // int Y
        // int z >> new
        #endregion

        #region Constructor
        //by defult child constructor channing on paramter less constructor that in parent 
        // to solve this probleb use channing constructor use base
        public child(int _x, int _y, int _z) : base(_x, _y)
        {
            Z = _z;
        }
        #endregion

        #region Methods
        
        public override string ToString()// virtual
        {
            return  $"{X}, {Y} , {Z}";
        }

        public new int product()
        {
            return base.product() * Z;// base.product == X * Y in class parent in method product()
        }

        #endregion
    }
}
