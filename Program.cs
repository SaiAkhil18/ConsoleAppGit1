namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Akhil\\file.txt";
            FileStream f1 = new FileStream(filename, FileMode.OpenOrCreate);
            using (StreamWriter s1 = new StreamWriter(f1))
            {
                s1.WriteLine("Hello, how are you?");
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}