namespace Builder_TwoDirector
{
    public  class WoodHouseBuilder : IHouseBuilder
    {
        private readonly House house;
        public WoodHouseBuilder() /*=> house = new();*/
        {
            house = new House();
        }
        public void BuildWalls() => house.Walls = "wooden walls";
        public void BuildDoors() => house.Doors = "Wooden Doors";
        public void BuildWindows() => house.Windows = "Wooden Windows";
        public House getHouse() => house;

    }
}
