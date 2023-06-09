using System;

abstract class Garden : IPlot
{
    public double Price { get; set; }

    public int CountOfPlants { get; set; } 
    public string Address { get; set; }

    public abstract void Plant(int CountOfPlants);

    public abstract void Harvest();

    public void WaterPlants()
    {
        Console.WriteLine(String.Format("Поливка растений"));
    }

    public void Buy()
    {
        Console.WriteLine(String.Format("Участок куплен за {0}", Price));
    }

    public void Sell()
    {
        Console.WriteLine(String.Format("Участок продан за {0}", Price));

    }

    public override string ToString()
    {
        return String.Format("Cад по адресу {0}. Посажено {1} деревьев. Стоимость участка {2}",
            Address, CountOfPlants, Price);
    }
}