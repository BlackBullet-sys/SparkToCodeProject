namespace session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loops

            //for loop
            List<string> names = ["Ali", "Osama", "Salim"];

            for(int i = 0; i<=2; i++)
            {
                Console.WriteLine(names[i]);
            }

            //while
            int num = 1;
            while (num <= 5)
            {
                Console.WriteLine(num);
                num++;
            }

            //do while
            int counter = 0;
            do
            {
                Console.WriteLine(names[counter]);
                counter++;
            }
            while (counter <= 2);

            //////////////////////////////

            /*
            bool exit = false;
            int count = 1;
            while(!exit)
            {
                Console.WriteLine("Print Number " + count);
                count++;
                Console.WriteLine("do you want to exit? (y,n)");
                string disicion = Console.ReadLine();
                if(disicion == "y")
                {
                    exit = true;
                }
                
            }
            */


            try
            {
                Console.Write("type a number: ");
                int number = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("The input only accepts integer Numbers...");
            }

            Console.WriteLine("Program Done!!!");

        }
    }
}
