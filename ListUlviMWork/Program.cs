using ListUlviMWork.Moduls;

namespace ListUlviMWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList list = new IntArrayList();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(6);

            list.GetInfo();
            Console.WriteLine("");

            Console.WriteLine(list.ToString());
            Console.WriteLine("");
            list.IndexOf(3);
            list.IndexOf(8);

            Console.WriteLine("");

            list.LastIndexOf(2);
            list.LastIndexOf(8);
            Console.WriteLine("");

            list.RemoveAt(0);
            list.RemoveAt(1);
            list.RemoveAt(3);
            list.GetInfo();




        }
    }
}
