namespace Skattjakt.Data
{
    public struct LocationCoordinates
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LocationCoordinates Location { get; set; }
        public string Assignment { get; set; }
    }
}
