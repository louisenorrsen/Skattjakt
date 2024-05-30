using static System.Math;
namespace Skattjakt.Data
{
    public class HaversineDistance
    {
        /// <summary>
        /// Calculates the Haversine distance between two geographical points.
        /// </summary>
        /// <param name="from">The starting geographical point with latitude and longitude.</param>
        /// <param name="to">The ending geographical point with latitude and longitude.</param>
        /// <returns>The distance in meters as an integer.</returns>
        /// <remarks>
        /// The Haversine formula is used to determine the great-circle distance between two points
        /// on a sphere given their longitudes and latitudes. This is particularly useful in navigation.
        /// This implementation takes two GeoPoint objects and returns the distance between them in meters.
        /// Earth's radius is approximated at 6371 kilometers.
        /// </remarks>
        public static int CalculateHaversineDistance(LocationCoordinate from, LocationCoordinate to)
        {
            double lat1 = from.Latitude;
            double lon1 = from.Longitude;
            double lat2 = to.Latitude;
            double lon2 = to.Longitude;

            double dLat = PI / 180 * (lat2 - lat1);
            double dLon = PI / 180 * (lon2 - lon1);

            double a = Sin(dLat / 2) * Sin(dLat / 2) +
                       Cos(PI / 180 * lat1) * Cos(PI / 180 * lat2) *
                       Sin(dLon / 2) * Sin(dLon / 2);

            double c = 2 * Atan2(Sqrt(a), Sqrt(1 - a)); // Haversine distance in radians
            double d = c * 6371 * 1000; // Earth's radius in meters;
            return (int)d;
        }
    }
}