using System;

class CherryGarden : Garden
{
    public string CherryType { get; set; }
    public int WeightOfCherrys { get; set; }

    public CherryGarden(string cherryType)
    {
        CherryType = cherryType;
    }
    public CherryGarden()
    {
    }

    public override void Plant(int CountOfPlants)
    {
        Console.WriteLine(String.Format("Посадка {0} вишен", CountOfPlants));
        this.CountOfPlants += CountOfPlants;
    }

    public override void Harvest()
    {
        Console.WriteLine(String.Format("Собрано {0} кг вишен", WeightOfCherrys));


    }
    public void FertilizePlants()
    {
        Console.WriteLine(String.Format("Удобрение вишен"));

    }

    public void CollectCherrys()
    {
        Console.WriteLine(String.Format("Сбор вишен"));
        WeightOfCherrys = CountOfPlants * 10;

    }

    public override string ToString()
    {
        return String.Format("Вишневый сад по адресу {0}. Посажено {1} вишен сорта {2}. Собранный урожай - {3}. Стоимость участка {4}",
             Address, CountOfPlants, CherryType, WeightOfCherrys, Price);
    }

}

