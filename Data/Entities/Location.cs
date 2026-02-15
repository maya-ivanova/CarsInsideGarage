using CarsInsideGarage.Data.Enums;
using NetTopologySuite; 
using NetTopologySuite.Geometries;

namespace CarsInsideGarage.Data.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public Area Area { get; set; }

         // Spatial point
        public Point ParkingCoordinates { get; set; } = null!;


    }
}
