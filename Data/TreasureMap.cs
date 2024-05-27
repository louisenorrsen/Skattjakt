namespace Skattjakt.Data
{
    public class TreasureMap
    {
        public string Name { get; set; }
        public List<Station> Stations { get; set; }

        public TreasureMap(string name)
        {
            Name = name;
        }
    }
}
