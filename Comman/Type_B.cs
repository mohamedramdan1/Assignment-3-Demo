using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    public class Type_B:Type_A
    {
        public Type_B()
        {
            //before inhertance
            //Type_A obj = new Type_A();
            //obj.x = 10; // invalid beacouse x is private protected mean it is private in type_A
            //obj.y = 20; // invalid beacouse y is protected mean it is private in type_A
            //obj.z = 30; // valid  beacouse z is internal protected  mean it is intrnal in type_A

            //After inhertance
            //x = 1; // valid becouse inhertance and it is private in type_B
            //y = 2; // valid becouse inhertance and it is private in type_B
            //z = 3;  // valid becouse inhertance and it is intenal in type_B
        }
    }
}
