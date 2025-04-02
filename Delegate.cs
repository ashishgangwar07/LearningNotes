using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        // Events uses Delegates
        // Delegates are for callbacks , not encapsulated 
        // Events publisher subscriber model , encapsulated
        static void Main(string[] args)
        {
            MyFileSearch x = new MyFileSearch();
            // publisher -- subcriber
            // observable -- observer
            x.publisher += Subscriber1;
            x.publisher += Subscriber2;
            //x.SendData = null;
            Console.WriteLine("File Search started....");
            Task.Run(() => x.Search("E:\\shivprasad data")); // non blocking call
            //x.Search("E:\\shivprasad data"); // blocking call
            Console.WriteLine("Continue executing main function....");
            Console.ReadLine();
        }
        static void Subscriber1(string filename)
        {
            Console.WriteLine(filename);
        }
        static void Subscriber2(string filename)
        {
            Console.WriteLine(filename);
        }
    }
    public class MyFileSearch
    {
        public delegate void searchMethod(string search);
        public event  searchMethod publisher = null; 
        public void Search(string dir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(dir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        publisher(f); 
                    }
                   
                    
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}












//Task.Run(()=>x.DirSearch("E:\\shivprasad data"));
//    Task.Run(() => MethodWithParameter(param));
