using System.ComponentModel.Design;

Stack<string> boxes = new Stack<string>();
Queue<string> drivers = new Queue<string>();
while (true)
{
    Console.WriteLine("Oerator Menyusu");
    Console.WriteLine("\n1. Qutu əlavə etmək");
    Console.WriteLine("2. Sürücü əlavə etmək");
    Console.WriteLine("3. Qutu vermək");
    Console.WriteLine("4. Qutuları göstərmək");
    Console.WriteLine("5. Sürücüləri göstərmək");
    Console.WriteLine("6. Çıxış");
    Console.Write("Seçin: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Qutunun nömrəsi: ");
        string box = Console.ReadLine();
        boxes.Push(box);
        Console.WriteLine("Qutu əlavə olundu!");
    }
    else if (choice == "2")
    {
        Console.WriteLine(" Sürücünün adı:");
        string driver = Console.ReadLine();
        drivers.Enqueue(driver);
        Console.WriteLine("Sürücü əlavə olundu!");
    }
    else if (choice == "3")
    {

        if (boxes.Count == 0)
            Console.WriteLine("Qutu yoxdur!");
        else if (drivers.Count == 0)
            Console.WriteLine("Sürücü yoxdur!");
        else
        {
            string box = boxes.Pop();
            string driver = drivers.Dequeue();
            Console.WriteLine($"Verildi: {box} -> {driver}");
        }
    }
    else if (choice == "4")
    {
        if (boxes.Count == 0)
            Console.WriteLine("Qutular yoxdur");
        else
        {
            Console.WriteLine("Qutular:");
            foreach (string box in boxes)
                Console.WriteLine(box);
        }
    }
    else if (choice == "5")
    {
        if (drivers.Count == 0)
            Console.WriteLine("Sürücülər yoxdur");
        else
        {
            Console.WriteLine("Sürücülər:");
            foreach (string driver in drivers)
                Console.WriteLine(driver);
        }
    }
    else if (choice == "6")
        break;
}

