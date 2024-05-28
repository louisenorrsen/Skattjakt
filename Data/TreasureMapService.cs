namespace Skattjakt.Data
{
    public class TreasureMapService
    {
        // List of all treasure maps in the system. Possible to read from a database in the future, or from a local file.
        public List<TreasureMap> Maps { get; set; } = new List<TreasureMap>();

        public TreasureMapService()
        {
            // Mockup maps for future testing
            Maps.Add(new TreasureMap("Map 1"));
            Maps.Add(new TreasureMap("Map 2"));
            Maps.Add(new TreasureMap("Map 3"));
        }

        // Add a new treasure map to the list in the service
        public void AddMap(TreasureMap newMap)
        {
            Maps.Add(newMap);
        }

        // Get a list of all treasure maps in the service
        public List<TreasureMap> GetMaps()
        {
            return Maps;
        }
    }
}
