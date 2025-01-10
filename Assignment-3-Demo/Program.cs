
using Assignment_3_Demo.Inhertance;
using Assignment_3_Demo.Polymorphism;

namespace Assignment_3_Demo
{
    #region Binding EX01
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Func1()
        {
            Console.WriteLine("I'm Employee");
        }

        public virtual void Func2()
        {
            Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}");

        }

    }
    internal class FullTimeEmployee : Employee
    {
        public int Salary { get; set; }

        public new void Func1()
        {
            Console.WriteLine("A'M FullTime Employee");
        }

        public override void Func2()
        {
            Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}, Salary {Salary}");
        }
    }
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountoFHours { get; set; }

        public new void Func1()
        {
            Console.WriteLine("A'M PartTime Employee");
        }
        
        public override void Func2()
        {
            Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}, CountoFHours = {CountoFHours} , HourRate = {HourRate} ");
        }
    }
    #endregion
    internal class Program
    {
        #region method overloading
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static double sum(double x, double y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y + z;
        }
        #endregion

        public static void ProccessEmpolyee(Employee emp)
        {
            if (emp is not null)
            {
                emp.Func1();
                emp.Func2();
            }
        }
        static void Main(string[] args)
        {
            #region Demo
            #region Inhertance
            //C# have consep single inheretance not muiltiblr inhertance 
            // if we wanr multiple inheretace use interface
            // 1. To make inhertance use >>>  : 
            // 2. To inhertance attrbute(proprty) use base in constructor to refer to parent
            // 3. to make inheret the method
            // 3.1 use override but should parent have vertiual
            // 3.2 or using new keyword before method 

            //Parent p = new Parent(5, 2);
            //Console.WriteLine(p);
            //Console.WriteLine(p.product());

            //child ch = new child(1,2,3);
            //Console.WriteLine(ch);
            //Console.WriteLine(ch.product());
            #endregion

            #region Relationip between Classes
            // 1. Inhertace : IS A [ Fulltime Employee is A Employee , child is a parent]
            // 2. Association : Has A [Room Has a Chairs , Department has a employee]
            // and do not have inhertance between classes ملهمش علاقه ببعض classes عباره عن علاقه بين اتنين  oop ال pillar مش من 
            // 2.1. Association Composition : [Mandatory relationship] لازم تكون موجوده العلاقه
            //ex : Room has a Walls
            // 2.2. Association Aggregation : [Partial relationship] مش لازم تكون موجوده العلاقه
            //ex : Room has a Chairs


            #endregion

            #region Access modifier using in inhertance
            // 1.Private Protected
            // 2.Protected
            // 3.Protected Internal 
            // show class Type_A.cs , Type_B.cs , Type_C.cs to know the diffrence between them
            // before inhertance and after inhertance
            #endregion

            #region Polymarphism
            #region overloading 
            //مختلفه paramter  تكرار الحاجه اكتر من مره بس  ب 
            // مختلفه وهكذا dataype  او ب
            // او تترتيب ال باراميتر مختلفه
            // method overloading
            // conctructor overloading
            // indexer overloading
            // operator overloading
            // casting operator overloading
            //Console.WriteLine(); // WriteLine() have 18 overloading
            #endregion

            #region override
            // override using in inhertance with class only not strucut using it by two keywords
            // 1.new >>>> make a new implemntation in function using new keyword in child and hide the funstion in parent
            // 2.override >>>> using it but before do any things that will overrided by override keyword
            //must public + virtual

            //TypeA typeA = new TypeA(1);
            //typeA.A = 5;
            //typeA.Func1();
            //typeA.Func2();

            //TypeB typeB = new TypeB(1, 2);
            //typeB.Func1();//IM child becouse override using new keyword
            //typeB.Func2();
            #endregion
            #endregion

            #region What is Binding
            //Refrence from Parent refer to object from child

            //TypeA typeA = new TypeB(1, 2);

            ////for property
            //typeA.A = 1;//valid becouse A in parent
            //typeA.B = 2; // invalid becouse  B not in parentand typeA --> parent

            //Static  Binding [Early Binding]
            //Compiler => Will Bind Method Call Based on Refrence type not object type
            // at compilation time
            //typeA.Func1();// function take new overide in child the o/p will be fun1() in parent
            //                // becouse new keyword cut السلسه

            //Dynamic Binding [Late Binding]
            //ClR => Will Bind Method Call Based on Object type not refence type
            // at Runtime 
            //typeA.Func2();//function take override keyword ovveride in child the o/p will be fun2() in child
            //                // becouse override keyword do not cut السلسله
            #endregion

            #region Not Binding
            // we cant make refrence from child refer to object from parent ,
            // we can do it using castiong opertator but it not binding
            // animal = dog // valid binding
            // dog =(dog) animal //not binding do iy by explicit casting
            //TypeA refBase;
            //refBase = new TypeA(1);// valid refrence of parent refer to object in parent
            //////refBase = new TypeB(1, 2); // valid it is binding

            //TypeB refchild = (TypeB) new TypeA(1);// not binding
            //refchild.A = 1;//valid
            //refchild.B = 2;  //valid



            #endregion

            #region Binding Ex01
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //fullTimeEmployee.Salary = 5000;
            //ProccessEmpolyee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.HourRate = 1000;
            //ProccessEmpolyee(partTimeEmployee);
            #endregion

            #region Binding Ex02
            //TypeC typec = new TypeC(1,2,3);

            //TypeA typeA = new TypeC(1,2,3);//Refrence from indirect Parent
            //typeA.A = 10;//valid     Refrence only هتشوف الى عند ال 
            //typeA.B = 20;//invalid
            //typeA.C = 30;//invalid
            //typeA.Func1();//I'M Base [Parent]  بتقطع السلسه new   علشان ال  
            //typeA.Func2();// last override  >>> A B C

            //TypeB typeB = new TypeC(1,2,3);// TypeB have prop A , B
            //////typeB.A = 1;//valid
            //////typeB.B = 20;//valid
            //////typeB.C =10,//invalid
            //typeB.Func1();// I'M Drived [Child] B   بتقطع السلسه new   علشان ال   
            //typeB.Func2();// last override  >>> A B C

            //TypeA typeA = new TypeD(1, 2, 3, 4);//indirect parent
            //TypeB typeb = new TypeD(1, 2, 3, 4);//indirect parent
            //TypeC typec = new TypeD(1, 2, 3, 4);//direct parent

            ////if func2 override keyword A B C D
            ////if func2 new keyword A B C 
            //typeA.Func2();// A B C
            //typeb.Func2();// A B C
            //typec.Func2();// A B C

            //TypeD typeD = new TypeD(1, 2, 3, 4);
            //typeD.Func2();

            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);//indirect parent
            //TypeB typeb = new TypeE(1, 2, 3, 4, 5);//indirect parent
            //TypeC typec = new TypeE(1, 2, 3, 4, 5);//indirect parent
            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);//direct parent
            //typeA.Func2();// A B C
            //typeb.Func2();// A B C
            //typec.Func2();// A B C
            //typeD.Func2();// A B C D E
            #endregion
            #endregion 
        }
    }
}

