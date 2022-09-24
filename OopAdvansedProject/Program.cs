namespace OopAdvansedProject
{
    partial class User
    {
        public int Id { get; set; }
    }

    internal class Program
    {
        public static ref int Method(ref int[] array)
        {
            return ref array[0];
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int n = 100;
            //int[] a = new int[3] { 1, 2, 3 };
            //int s = Method(ref a);

            ////MyString myString = new() { Str = "Hello world" };

            //string myString = "Hello world";

            //Console.WriteLine(myString.CountChar('l'));

            //User user = new User() { Id = 123, Name = "Bob" };
            //user.Print();

            var userHobby = new { Id = 123, Name = "Tom", Company = "Yandex" };
            Console.WriteLine(userHobby.GetType());

            var tuple = (123, "qwerty");
            Console.WriteLine(tuple.GetType());

            (int, string) t = (23, "aaaa");

            (int, int, string, float) tt = (id:123, count:456, passw:"qwerty", price:123.456f);
        }
    }
}