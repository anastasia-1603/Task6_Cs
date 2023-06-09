using System;

class PearGarden : Garden
{
    public string PearType { get; set; }
    public int WeightOfPears { get; set; }

    public PearGarden(string pearType)
    {
        PearType = pearType;
    }

    public PearGarden()
    {
    }

    public override void Plant(int CountOfPlants)
    {
        Console.WriteLine(String.Format("Посадка {0} груш", CountOfPlants));
        this.CountOfPlants += CountOfPlants;
    }

    public override void Harvest()
    {
        Console.WriteLine(String.Format("Собрано {0} кг груш", WeightOfPears));


    }
    public void FertilizePlants()
    {
        Console.WriteLine(String.Format("Удобрение груш"));

    }

    public void CollectPears()
    {
        Console.WriteLine(String.Format("Сбор груш"));
        WeightOfPears = CountOfPlants * 10;

    }

    public override string ToString()
    {
        return String.Format("Грушевый сад по адресу {0}. Посажено {1} груш сорта {2}. Собранный урожай - {3}. Стоимость участка {4}",
             Address, CountOfPlants, PearType, WeightOfPears, Price);
    }

}

