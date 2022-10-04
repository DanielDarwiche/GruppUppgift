using System;

namespace GruppUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            //HallandsPostNummer(31178);



            string[,] userArray = new string[,]
            {
                {
                    "Anna","skånegatan","199512121212", "0734343434","dasdjai@dasid.se"
                },
                {
                    "Hanna","Västgatan","199512121212", "0734343434","dasdjai@dasid.se"
                },
                {
                    "Banna","Västgatan","199512121212", "0734343434","dasdjai@dasid.se"
                },
                {
                    "Sanna","Västgatan","199512121212", "0734343434","dasdjai@dasid.se"
                }
            }; 
            foreach (var item in userArray)
            {
                Console.WriteLine(item);
            }
            TaBortUser(userArray,"Banna");
            foreach (var item in userArray)
            {
                Console.WriteLine(item);
            }
        }
        static void HallandsPostNummer(int postnummer)
        {
            
            switch (postnummer)
            {
                case 31178:
                    Console.WriteLine("Falkenberg");
                    break;
                case 43265:
                    Console.WriteLine("Väröbacka");
                    break;
                case 30104:
                    Console.WriteLine("Halmstad");
                    break;
                case 43230:
                    Console.WriteLine("Kungsbacka");
                    break;
                case 43235:
                    Console.WriteLine("Varberg");
                    break;
                default:
                    Console.WriteLine("Ogilitigt postnummer.");
                    break;

            }

        }
        static void TaBortUser(string [,] userArray, string user )
        {
            int rownum = userArray.GetUpperBound(0) + 1;
            for (int i = 0; i < rownum; i++)
            {
                if (userArray[i,0] == user)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        userArray[i, j] = "";
                    }
                }
            }

        }

    }
}
