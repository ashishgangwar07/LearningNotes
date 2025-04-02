// Ques: In parent child which Constructor fires first
// parent Constructor fires first, then child Constructor

using System;

namespace ConstructorInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Women x = new Women();
        }
    }   
    public  class Human
    {
        int h= 2;
        public Human(){
            Console.WriteLine("Human");
        }
        static Human(){
            Console.WriteLine("static Human");
        }
    }

    public class Women : Human 
    {   
        int w= 10;
        public Women(){
            Console.WriteLine("Women");
        }
        static Women(){
            Console.WriteLine("static Women");
        }
    }
    
    public class Man : Human
    {
        public Man(){
            Console.WriteLine("Man");
        }

    }
}

// Output: Human
//         Women

// Quest: what about initializer
// Ans: child initializer fires first, then parent initializer fires
// Output: w
//         H   
//         Human
//         Women
.

// Quest: what about staic Constructor
// Ans:    staic Constructor child fires
        // staic Constructor parent fires
        // normal Constructor parent fires
        // normal Constructor child fires


    // Ques:when does Static Constructor fires? will fire first, when access anything first time.
 // Ans  Static Constructor fires first, when access anything first time.

        class Program
    {
        static void Main(string[] args)
        {
            Human.M1();
        }
    }   
    public  class Human
    {
        
        public static void M1(){
            Console.WriteLine("Human");
        }
        static Human(){
            Console.WriteLine("static Human");
        }
    }
