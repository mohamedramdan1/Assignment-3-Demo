using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comman;

namespace Assignment_3_Demo
{
    internal class Type_C:Type_A
    {
        public Type_C()
        {
            //before inhertance
            //Type_A obj = new Type_A();
            //obj.x = 1;//invalid => x is private protected mean it is private in type_A
            //obj.y = 1;//invalid => y is  protected  mean it is private in type_A
            //obj.z = 1;//invalid => z is internal protected  mean it is intrnal in type_A

            //After inhertance
            //x = 1; // not valid [x is privat protected] 
            //y = 2; // valid private in type_C
            //z = 10; // valid private in type_C
        }
    }
}
