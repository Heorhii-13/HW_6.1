using System;

class Shop : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Type { get; set; }

    public Shop(string name, string address, string type)
    {
        Name = name;
        Address = address;
        Type = type;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Магазин: {Name}, Адреса: {Address}, Тип: {Type}");
    }

    public void Dispose()
    {
        Console.WriteLine($"Магазин {Name} закрито");
    }

    ~Shop()
    {
        Console.WriteLine($"Магазин {Name} знищено");
    }
}

class Program
{
    static void Main()
    {
        // Тестування класу "Магазин" з деструктором
        using (Shop shop = new Shop("Продукти24", "вул. Центральна, 10", "Продовольчий"))
        {
            shop.ShowInfo();
        } // Тут автоматично викликається Dispose
    }
}