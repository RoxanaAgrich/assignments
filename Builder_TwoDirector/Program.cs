using Builder_TwoDirector;
House Woodenhouse  = Director.Construct(new StoneHouseBuilder());
        //IHouseBuilder objectwood = new WoodHouseBuilder();
        //House Woddenhouse = Director.Construct(objectwood);
Console.WriteLine($"Constructed House: {Woodenhouse.Walls}, {Woodenhouse.Doors}, {Woodenhouse.Windows}");

