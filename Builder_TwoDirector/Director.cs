namespace Builder_TwoDirector
{
    public static class Director
    {
        public static House Construct (IHouseBuilder house)
        {
            house.BuildWalls();
            house.BuildDoors();
            house.BuildWindows();
            return house.getHouse();
        }
    }
}
