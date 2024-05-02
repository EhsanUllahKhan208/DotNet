namespace overloading
{
     class Program
    {
        void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void sum(float a,float b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.sum(1,2);
            Console.ReadLine();
            Dog tommy = new Dog();
            tommy.eat();
            Console.ReadLine();
        }
    }
    class Animal
    {
        public void eat()
            {
            Console.WriteLine("Animal is eating.");
        }

    }
    class Dog : Animal
    {
        public void eat()
        {
            Console.WriteLine("Dog is eating.");
        }
    }
}
