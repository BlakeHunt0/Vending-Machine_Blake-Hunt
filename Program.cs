namespace Vending_Machine_Blake_Hunt
{
    public class Program
    {
        static void Main(string[] args)
        {
            //functions
            //ListMethod.InitData
            //ListMethod.PrintAll
            //ListMethod.PrintOne
            //ListMethod.Add

            //list containing all of the methods
            List<Item> Items = new List<Item>();

            //fill list above with data
            ListMethods.InitData(Items);

            bool on = true;

            while (on)
            {
                bool mainmenu = true;
                bool add = false;
                if (mainmenu)
                {
                    //startup menu
                    Console.Clear();
                    Console.WriteLine("'/add' to add new item");
                    Console.WriteLine();
                    Console.WriteLine("Please Make a Selection");
                    Console.WriteLine();
                    ListMethods.PrintAll(Items);
                    string input = ("" + Console.ReadLine());

                    //input conversion to item number 
                    int itm = (Convert.ToInt32(input));

                    //i don't know why this is causing a problem, ask later
                    int price = Payment.GetItemPrice(Items, itm);
                    Console.WriteLine(price);
                    Console.ReadLine();

                    if (itm > 0 && itm < (Items.Count + 1))
                    {
                        Console.Clear();
                        ListMethods.PrintOne(Items, itm);
                        Console.ReadLine();

                        //log
                        DateTime vendTime = DateTime.Now;
                        string logMsg = "Item choice : " + input + " | " + "Time : " + vendTime;
                        Logger.logToText(logMsg);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please input the ID of an available chip");
                        Console.ReadLine();
                    }

                    if (input == "/add")
                    {
                        mainmenu = false;
                        add = true;
                    }
                }

                if (add)
                {
                    Console.Clear();
                    Console.WriteLine("enter new item name");
                    string name = ("" + Console.ReadLine());

                    ListMethods.Add(Items, name);

                    add = false;
                    mainmenu = true;
                }
            }

        }
    }
}
