using System.Diagnostics;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CMD from Wish 0.0");
            Console.WriteLine("(c) Herr Schmieroel");
            while (true)
            {

                string[] items = {"Black" , "Blue" , "Green" , "Cyan" , "Red" , "Magenta" , "Yellow" ,
                "White"};

                

                static void openedge()
                {
                    try
                    {
                        Console.WriteLine("Type the url you want to visit or type return to skip!");
                        var edge = new ProcessStartInfo("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe");
                        string edgeurl = Console.ReadLine();
                        edge.Arguments = edgeurl;
                        if (edgeurl == "return")
                        {

                        }
                        else
                        {
                            Process.Start(edge);
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Browser was not found!");
                        Console.ResetColor();
                    }
                }

                static void openchrome()
                {
                    try
                    {
                        Console.WriteLine("Type the url you want to visit or type return to skip!");
                        var chrome = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
                        string chromeurl = Console.ReadLine();
                        chrome.Arguments = chromeurl;
                        if (chromeurl == "return")
                        {

                        }
                        else
                        {
                            Process.Start(chrome);
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Browser was not found!");
                        Console.ResetColor();
                    }
                }

                static void openfirefox()
                {
                    try
                    {
                        Console.WriteLine("Type the url you want to visit or type return to skip!");
                        var firefox = new ProcessStartInfo("C:\\Program Files\\Mozilla Firefox\\firefox.exe");
                        string firefoxurl = Console.ReadLine();
                        firefox.Arguments = firefoxurl;
                        if (firefoxurl == "return")
                        {

                        }
                        else
                        {
                            Process.Start(firefox);
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Browser was not found!");
                        Console.ResetColor();
                    }
                }
                
                static void openoperagx()
                {
                    try
                    {
                        Console.WriteLine("Type the url you want to visit or type return to skip!");
                        string username = Environment.UserName;
                        var operagx = new ProcessStartInfo($"C:\\Users\\{username}\\AppData\\Local\\Programs\\Opera GX\\launcher.exe"); //OperaGX path muss ich herausfinden.
                        string operagxurl = Console.ReadLine();
                        operagx.Arguments = operagxurl;
                        if (operagxurl == "return")
                        {

                        }
                        else
                        {
                            Process.Start(operagx);
                        }
                     
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Browser was not found!");
                        Console.ResetColor();
                    }
                }

                static void calculate()
                {
                    Console.WriteLine("Note this calculater only works without comma nums!");
                    Console.WriteLine("");
                    try
                    {
                        Console.WriteLine("Type the first Number");
                        int firstnum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Type the second number!");
                        int secondnum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Type the operator (+ - * /)");
                        string _operator_ = Console.ReadLine();
                        if (_operator_ == "+")
                        {
                            string firstnumstring = Convert.ToString(firstnum);
                            string secondnumstring = Convert.ToString(secondnum);
                            int result = firstnum + secondnum;
                            Console.WriteLine(firstnumstring+ " + " + secondnumstring + " = " + result);
                        }
                        else if (_operator_ == "-")
                        {
                            string firstnumstring = Convert.ToString(firstnum);
                            string secondnumstring = Convert.ToString(secondnum);
                            int result = firstnum - secondnum;
                            Console.WriteLine(firstnumstring + " - " + secondnumstring + " = " + result);
                        }
                        else if (_operator_ == "*")
                        {
                            string firstnumstring = Convert.ToString(firstnum);
                            string secondnumstring = Convert.ToString(secondnum);
                            int result = firstnum * secondnum;
                            Console.WriteLine(firstnumstring + " * " + secondnumstring + " = " + result);
                        }
                        else if (_operator_ == "/")
                        {
                            string firstnumstring = Convert.ToString(firstnum);
                            string secondnumstring = Convert.ToString(secondnum);
                            int result = firstnum / secondnum;
                            Console.WriteLine(firstnumstring + " / " + secondnumstring + " = " + result);
                        }
                        else
                        {
                            Console.WriteLine("No Operator was found!");
                        }
                        

                    }
                    catch (Exception )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Something went wrong try again");
                        Console.ResetColor();
                    }
                        
                }




                Console.WriteLine("");
                Console.WriteLine("Type a command:");
                Console.WriteLine("");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "":
                        break;
                    
                    case "quit":
                        Environment.Exit(0);
                        break;
                    
                    case "exit":
                        Environment.Exit(0);
                        break;

                    case "Linux":
                        Console.WriteLine("Linux is better then Windows!");
                        Console.WriteLine("");
                        break;

                    case "Windows":
                        Console.WriteLine("Windows is better then Linux!");
                        Console.WriteLine("");
                        break;
                    
                    case "calculate":
                        calculate();
                        break;

                    case "chrome_open_link":
                        openchrome();
                        break;

                    case "edge_open_link":
                        openedge();
                        break;
                    
                    case "operagx_open_link":
                        openoperagx();
                        break;
                        

                    case "firefox_open_link":
                        openfirefox();
                        break;

                    

                    case "font-color":
                        Console.WriteLine("");
                        Console.WriteLine("Options:");
                        Console.WriteLine("");
                        for (int i = 0; i < items.Length; i++)
                        {
                            Console.WriteLine($"font-color {i} = {items[i]}");
                            Console.WriteLine("");
                        }
                        break;

                    case "font-color 0":
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;

                    case "font-color 1":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case "font-color 2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case "font-color 3":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;

                    case "font-color 4":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    case "font-color 5":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case "font-color 6":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case "font-color 7":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    default:
                        Console.WriteLine("There is no command named " + answer + "!");
                        Console.WriteLine("");
                        break;
                        
                }
            }
            

        }
    }
}
