using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Demo.Polymorphism
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }
        public void Func1()
        {
            Console.WriteLine("I'M Base [Parent]");
        }
        public virtual void Func2()
        {
            Console.WriteLine($"A = {A}");
        }
    }

    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        //KeyWord New || Override
        //static binding
        public new void Func1()
        {
            Console.WriteLine("I'M Drived [Child] B");
        }

        // using it but before do any things that will overrided by override keyword
        // must public + virtual in the first 
        //dynamic binding
        public override void Func2()
        {
            Console.WriteLine($"A = {A} , B = {B}");
        }

    }

    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _A, int _B, int _C) : base(_A, _B)
        {
            C = _C;
        }

        public new void Func1()
        {
            Console.WriteLine("I'M Grand [Child] C");
        }

        public override void Func2()
        {
            Console.WriteLine($"A = {A} , B = {B} , C = {C}");
        }

     
    }

    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B, _C)
        {
            D = _D;
        }
        
        public new virtual void Func2()
        {
            Console.WriteLine($"A = {A} , B = {B} , C = {C}, D = {D}");
        }
    }

    internal class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _A, int _B, int _C, int _D, int _E) : base(_A, _B, _C, _D)
        {
            E = _E;
        }
        
        public override void Func2()
        {
            Console.WriteLine($"A = {A} , B = {B} , C = {C}, D = {D}, E = {E}");
        }
    }
}