using ConsoleApp1;



string[] cakeFlavors = { "Шоколадный", "Ванильный", "Фруктовый" };
int[] cakeMoney = { 150, 300, 400 };
string[] creamFlavors = { "Сливочный", "Шоколадный", "Фруктовый" };
int[] creamMoney = { 50, 100, 150 };
string[] toppings = { "Орехи", "Шоколадные крошки", "Фрукты" };
int[] toppingsMoney = { 100, 150, 200 };


int sum;


int selectedCakeFlavor = 0;
int selectedCreamFlavor = 0;
int[] selectedToppings = new int[2];

bool exit = false;
while (!exit)
{



    Console.WriteLine(" Добро пожаловать в кондитерскую!");

    Console.WriteLine("\nМеню:");
            Console.WriteLine("  1.Выбрать вкус торта");
            Console.WriteLine("  2.Выбрать вкус крема");
            Console.WriteLine("  3.Выбрать топпинги");
            Console.WriteLine("  4.Заказать торт");
    Console.WriteLine("  5.Сохранить в txt");
    Console.WriteLine("  6.Выход");
    Menu menu = new Menu();
    menu.minStrel = 3;
    menu.maxStrel = 8;
    int pos = menu.Show();
    Console.Clear();

            switch (pos-2)
            {
            
            

                case 1:
                    selectedCakeFlavor = ShowSubMenu(cakeFlavors, "Выберите вкус торта:");
                    Console.WriteLine("Выбран вкус торта: " + cakeFlavors[selectedCakeFlavor] + " " + cakeMoney[selectedCakeFlavor]);

            Console.Clear();
            break;
                case 2:
                    selectedCreamFlavor = ShowSubMenu(creamFlavors, "Выберите вкус крема:");
                    Console.WriteLine("Выбран вкус крема: " + creamFlavors[selectedCreamFlavor] + " " + creamMoney[selectedCreamFlavor]);
            Console.Clear();
            break;
                case 3:
                    Console.WriteLine("Выберите 2 топпинга из списка:");
                    selectedToppings[0] = ShowSubMenu(toppings, "1-й топпинг:");
                    selectedToppings[1] = ShowSubMenu(toppings, "2-й топпинг:");
                    Console.WriteLine("Выбраны топпинги: " + toppings[selectedToppings[0]] + " " + toppingsMoney[selectedToppings[0]] + ", " + toppings[selectedToppings[1]] + " " + toppingsMoney[selectedToppings[1]]);
            Console.Clear();
            break;
                case 4:
                    Console.WriteLine("Ваш заказ:");
                    Console.WriteLine("Торт: " + cakeFlavors[selectedCakeFlavor] + " " + cakeMoney[selectedCakeFlavor]);
                    Console.WriteLine("Крем: " + creamFlavors[selectedCreamFlavor] + " " + creamMoney[selectedCakeFlavor]);
            Console.WriteLine("Топпинги: " + toppings[selectedToppings[0]] + " " + toppingsMoney[selectedToppings[0]] + ", " + toppings[selectedToppings[1]] + " " + toppingsMoney[selectedToppings[1]]);
            sum = cakeMoney[selectedCakeFlavor] + creamMoney[selectedCakeFlavor] + toppingsMoney[selectedToppings[0]] + toppingsMoney[selectedToppings[1]];
            Console.WriteLine("Цена: " + sum + " руб");

            
            break;
            case 5:
            File.AppendAllText("MyTortik.txt", "Торт: " + cakeFlavors[selectedCakeFlavor] + " " + cakeMoney[selectedCakeFlavor] + " ");
            File.AppendAllText("MyTortik.txt", "Крем: " + creamFlavors[selectedCreamFlavor] + " " + creamMoney[selectedCakeFlavor] + " ");
            File.AppendAllText("MyTortik.txt", "Топпинги: " + toppings[selectedToppings[0]] + " " + toppingsMoney[selectedToppings[0]] + ", " + toppings[selectedToppings[1]] + " " + toppingsMoney[selectedToppings[1]] + " ");
            sum = cakeMoney[selectedCakeFlavor] + creamMoney[selectedCakeFlavor] + toppingsMoney[selectedToppings[0]] + +toppingsMoney[selectedToppings[1]];
            File.AppendAllText("MyTortik.txt", "Цена: " + sum + " руб" + "            ");
            break;
        case 6:
                    exit = true;
            Console.Clear();
            break;
                
            }
        }


// Функция для отображения подменю и выбора пункта
static int ShowSubMenu(string[] menuItems, string submenuTitle)
    {
        Console.WriteLine("\n" + submenuTitle);
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + menuItems[i]);

        }
        Console.Write("Введите номер выбранного пункта: ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

       



        return choice;
    }


