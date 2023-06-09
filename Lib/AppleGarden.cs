using System;

class AppleGarden : Garden
{
    public string AppleType { get; set; }
    public int WeightOfApples { get; set; }

    public AppleGarden(string appleType)
    {
        AppleType = appleType;
    }

    public AppleGarden()
    {

    }

    public override void Plant(int CountOfPlants)
    {
        Console.WriteLine(String.Format("Посадка {0} яблонь", CountOfPlants));
        this.CountOfPlants += CountOfPlants;
    }

    public override void Harvest()
    {
        Console.WriteLine(String.Format("Собрано {0} кг яблок", WeightOfApples));


    }
    public void FertilizePlants()
    {
        Console.WriteLine(String.Format("Удобрение яблонь"));

    }

    public void CollectApples()
    {
        Console.WriteLine(String.Format("Сбор яблок"));
        WeightOfApples = CountOfPlants * 10;

    }

    public override string ToString()
    {
        return String.Format("Яблочный сад по адресу {0}. Посажено {1} яблонь сорта {2}. Собранный урожай - {3}. Стоимость участка {4}",
             Address, CountOfPlants, AppleType, WeightOfApples, Price);
    }

}

