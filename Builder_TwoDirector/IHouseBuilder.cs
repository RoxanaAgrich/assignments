namespace Builder_TwoDirector
{
    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildDoors();
        void BuildWindows();
        House getHouse();

    }
}
