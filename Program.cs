namespace Vending_Machine_Blake_Hunt
{
    //functions
    //ListMethod.InitData
    //ListMethod.PrintAll
    //ListMethod.PrintOne
    //ListMethod.Add
    public class Program
    {
        static void Main(string[] args)
        {
            //list containing all of the methods
            List<Item> Items = new List<Item>();

            //fill list above with data
            ListMethods.InitData(Items);

            //while the vending machine is on
            bool on = true;
            while (on)
            {
                //bools for choosing menu
                bool mainmenu = true;
                bool add = false;

                if (mainmenu)
                {
                    //startup menu
                    Console.Clear();
                    Console.WriteLine("'/add' to add new item\n");
                    Console.WriteLine("Please Make a Selection\n");
                    ListMethods.PrintAll(Items);
                    string input = ("" + Console.ReadLine());

                    //input conversion to item number 
                    int itm = (Convert.ToInt32(input));

                    //if input is valid item number
                    if (itm > 0 && itm < (Items.Count + 1))
                    {
                        //TODO: this code will have to be moved into an if statement which acctivates when the user drops in enough money
                        Console.Clear();
                        ListMethods.VendOne(Items, itm);
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

                    Console.Clear();
                    Console.WriteLine("enter new item price");
                    double price = (Convert.ToDouble(Console.ReadLine()));

                    Console.Clear();
                    Console.WriteLine("enter new item inventory number");
                    int inventoryNum = (Convert.ToInt32(Console.ReadLine()));

                    //Items is the list of items
                    ListMethods.Add(Items, name, price, inventoryNum);

                    add = false;
                    mainmenu = true;
                }
            }

        }
    }
}
