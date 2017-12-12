using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Koobas
    {
        public static void Kooba()
        {
            //-esimene suuna valik
            Console.WriteLine("Kas soovite minna vasakule või paremale?");
            string suund = Console.ReadLine();
            if (suund == "vasakule")

            {
                
                Console.WriteLine("Kas soovite minna vasakule või paremale?");
                string suund2 = Console.ReadLine();
                if (suund2 == "vasakule")
                {
                    

                    //politsei - KRISTEL
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund4 = Console.ReadLine();
                    if (suund4 == "vasakule")
                    {
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund6 = Console.ReadLine();
                        if (suund6 == "vasakule")
                        {
                            //toit
                            //VÄLJAS
                        }
                        else if (suund6 == "paremale")
                        {
                            //puhkeala
                            Console.WriteLine("Kas soovite minna vasakule või paremale?");
                            string suund8 = Console.ReadLine();
                            if (suund8 == "vasakule")
                            {
                                //rott
                                //puhkeala
                            
                            }
                            else if (suund8 == "paremale")
                            {
                                //toit
                                //VÄLJAS
                            }
                        }

                    }

                    else if (suund4 == "paremale")
                    {
                        //toit

                    }
                }
                else if (suund2 == "paremale")
                {
                   
                    //vanemate elajate ründamine - KRISTEL
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund5 = Console.ReadLine();
                    if (suund5 == "vasakule")
                    {
                        //toit
                        //puhkeala
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund8 = Console.ReadLine();
                        if (suund8 == "vasakule")
                        {
                            //rott
                            //puhkeala

                        }
                        else if (suund8 == "paremale")
                        {
                            //toit
                            //VÄLJAS
                        }
                    }
                    else if (suund5 == "paremale")
                    {
                        //puhkeala
                        //toit
                        

                    

                    }
                }
            }

            else if (suund == "paremale")
            {
                
                //vanemate elajate ründamine - KRISTEL

                Console.WriteLine("Kas soovite minna vasakule või paremale?");
                string suund3 = Console.ReadLine();
                if (suund3 == "vasakule")
                {

                    //vanemate elajate ründamine - KRISTEL
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund5 = Console.ReadLine();
                    if (suund5 == "vasakule")
                    {
                        //toit
                        //puhkeala
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund8 = Console.ReadLine();
                        if (suund8 == "vasakule")
                        {
                            //toit
                            //VÄLJAS

                        }
                        else if (suund8 == "paremale")
                        {//rott aitab välja
                         //puhkeala 
                         //VÄLJAS
                        }
                    }
                    else if (suund5 == "paremale")
                    {
                        //rott aitab välja
                        //puhkeala 
                        //VÄLJAS

                    }

                }

                else if (suund3 == "paremale")
                {
                    //šokolaadi tk.
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund7 = Console.ReadLine();
                    if (suund7 == "vasakule")
                    {
                        //rott
                        //puhkeala
                        //toit
                        //VÄLJAS
                    }
                    else if (suund7 == "paremale")
                    {

                        //politsei- KRISTEL
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund9 = Console.ReadLine();
                        if (suund9 == "vasakule")
                        {
                            //rott
                            //puhkeala
                            //VÄLJAS
                        }
                        else if (suund9 == "paremale")
                        {
                            Console.WriteLine("Tuleb kiiresti välja saada!");
                            //VÄLJAS

                        }
                    }
                }


            }

        }


    }
}
