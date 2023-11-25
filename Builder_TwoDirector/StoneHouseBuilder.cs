namespace Builder_TwoDirector
{
    public class StoneHouseBuilder : IHouseBuilder
    {
        private readonly House house;
        public StoneHouseBuilder() => house = new();
        public void BuildWalls() => house.Walls = "Stone Walls";
        public void BuildDoors() => house.Doors = "Stone Doors";
        public void BuildWindows() => house.Windows = "Stone Windows";
        public House getHouse() => house;// return house;
    }
}
