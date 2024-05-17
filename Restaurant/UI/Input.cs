using System.Globalization;
class input{
    public static int menuItemsCounter = 0;
    public static IList<Menu> menuList = new List<Menu>();
    public static IDictionary<string, int> menuDict= new Dictionary<string, int>();
    public static IList<string> order = new List<string>();
    
    public static void inputData()
    {
        while(true)
        {
            string input = Console.ReadLine();
            string[] splitInputs = input.Split(", ");
            if(int.TryParse(splitInputs[0], out int TableNumber))
            {
                System.Console.WriteLine("Order");
                string[] splitInputsNoTableNumber = new string[splitInputs.Length - 1];
                for(int i = 1; i < splitInputs.Length;i++)
                {
                    splitInputsNoTableNumber[i-1] = splitInputs[i];
                }
                foreach(var a in splitInputsNoTableNumber)
                {
                    if(menuDict.ContainsKey(a))
                    {

                    } else{
                        System.Console.WriteLine($"Error 100: {a} doesn't exist in the menu.");
                    }
                }
            }
            else if(input.ToLower() == "продажби")
            {
                System.Console.WriteLine("sales");

            }
            else if(splitInputs[0].ToLower() == "инфо")
            {
                int index = menuDict[splitInputs[1]];
                System.Console.WriteLine(menuList[index].GetType());
                //if(menuList[index].GetType()){}
                System.Console.WriteLine("Информация за продукт: " + menuList[index].Name);
                System.Console.WriteLine("");
            }
            else if(splitInputs[0].ToLower() == "салата" || splitInputs[0].ToLower() == "супа" || splitInputs[0].ToLower() == "основно ястие" || splitInputs[0].ToLower() == "десерт" ||splitInputs[0].ToLower() == "напитка")
            {
                System.Console.WriteLine("Menu add");
                int _volume = int.Parse(splitInputs[2]);
                double _price = double.Parse(splitInputs[3].Replace('.', ','), CultureInfo.InvariantCulture);
                switch(splitInputs[0].ToLower())
                {
                    case "салата":
                        Salad salad = new Salad(splitInputs[1], _volume, _price);
                        menuList.Add(salad);
                        break;
                    case "супа":
                        Soup soup = new Soup(splitInputs[1], _volume, _price);
                        menuList.Add(soup);
                        break;
                    case "основно ястие":
                        MainCourse mainCourse = new MainCourse(splitInputs[1], _volume, _price);
                        menuList.Add(mainCourse);
                        break;
                    case "десерт":
                        Dessert dessert = new Dessert(splitInputs[1], _volume, _price);
                        menuList.Add(dessert);
                        break;
                    case "напитка":
                        Drinks drinks = new Drinks(splitInputs[1], _volume, _price);
                        menuList.Add(drinks);
                        break;
                    default:
                        Console.WriteLine("Error ???");
                        break;
                }
                menuDict.Add(splitInputs[1], menuItemsCounter);
                menuItemsCounter++;             
            }
            else
            {
                Console.WriteLine("Error Wrong Input");
            }
        }
    }
}