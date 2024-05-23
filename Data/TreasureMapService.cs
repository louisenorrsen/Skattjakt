namespace Skattjakt.Data
{
    public class TreasureMapService
    {
        public List<TreasureMap> Maps { get; set; } = new List<TreasureMap>();

        public TreasureMapService()
        {
            Maps.Add(new TreasureMap("Map 1"));
            Maps.Add(new TreasureMap("Map 2"));
            Maps.Add(new TreasureMap("Map 3"));
        }

        public void AddMap(TreasureMap newMap)
        {
            Maps.Add(newMap);
        }

        public List<TreasureMap> GetMaps()
        {
            return Maps;
        }
    }
}
