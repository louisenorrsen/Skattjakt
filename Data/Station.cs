namespace Skattjakt.Data
{
    public struct LocationCoordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public LocationCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public class Station
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public LocationCoordinate Location { get; set; }
        public Guid PointOnMapGuid { get; set; }
        public string? Assignment { get; set; }
    }
}
