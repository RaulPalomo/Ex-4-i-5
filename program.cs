namespace PP1
{
    public class Menu
    {
        public static void Main()
        {
            const string OddMsg = "a. Validar si un nombre és senar";
            const string PotenciaMsg = "b. Calcular la potència d'un nombre";
            const string RandMsg = "c. Retornar un valor aleatori";
            const string CountMsg = "d. Comptar el nombre de vocals o consonants en un text";
            const string ExitMsg = "e. Sortir";
            string option;

            Console.WriteLine(OddMsg);
            Console.WriteLine(PotenciaMsg);
            Console.WriteLine(RandMsg);
            Console.WriteLine(CountMsg);
            Console.WriteLine(ExitMsg);
            option = Console.ReadLine().ToLower();

            if (option == "a")
            {
                ValidateSenar();
            }
            else if (option == "b")
            {
                CalcPotencia();
            }
            else if (option == "c")
            {
                RandomNum();
            }
            else if(option == "d")
            {
                Count();
            }
            else if (option== "e") 
            {

            }
        }
        public static void ValidateSenar()
        {
            Console.WriteLine("Insereix un número");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "No és senar" : "És senar");
        }
        public static void CalcPotencia()
        {
            int result = 1;
            int num;
            int exp;
            Console.WriteLine("Escriu la base");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
            Console.WriteLine("Escriu l'exponent");
            do
            {
                exp = Convert.ToInt32(Console.ReadLine());
            }while (exp < 0);
            for (int i = 0; i < exp; i++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }

        public static void RandomNum()
        {
            Random rand = new Random();
            int vMax, vMin;
            Console.WriteLine("Valor màxim;");
            do
            {
                vMax= Convert.ToInt32(Console.ReadLine());  
            }while(vMax < 0);
            Console.WriteLine("Valor mínim");
            do
            {
                vMin = Convert.ToInt32(Console.ReadLine());
            } while (vMin < 0);
            Console.WriteLine(rand.Next(vMin,vMax+1));
        }
        public static void Count()
        {
            Console.WriteLine("Escriu un text");
            string text= Console.ReadLine();
            text = text.Replace(" ", "");
            Console.WriteLine(text.Length);
        }
    }
}
