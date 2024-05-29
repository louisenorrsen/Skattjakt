using Newtonsoft.Json;

namespace Skattjakt.Data
{
    public class TreasureMapService
    {
        // List of all treasure maps in the system. Possible to read from a database in the future, or from a local file.
        public List<TreasureMap> Maps { get; set; } = new List<TreasureMap>();

        public TreasureMapService() { }

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

        // Get a specific treasure map by its id
        public TreasureMap GetMapById(int id)
        {
            return Maps.FirstOrDefault(map => map.Id == id);
        }

        public int GetNextId()
        {
            return Maps.Count + 1;
        }

        // Save the treasure maps to a file
        public void SaveMapsToFile()
        {
            // Serialize the list of maps to a file
            string json = JsonConvert.SerializeObject(Maps);
            File.WriteAllText("Data/data.json", json);
        }

        // Load the treasure maps from a file
        public void LoadMapsFromFile()
        {
            // Deserialize the list of maps from a file if it exists
            if (!File.Exists("Data/data.json"))
            {
                return;
            }
            else
            {
                string json = File.ReadAllText("Data/data.json");
                Maps = JsonConvert.DeserializeObject<List<TreasureMap>>(json);
            }
        }
    }
}
