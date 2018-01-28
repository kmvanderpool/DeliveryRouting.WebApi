using GeocodeSharp.Google;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryRouting.Logic
{
    public class Router
    {

        public async Task DoRouting() {
            var address = "Routing address here";
            var client = new GeocodeClient();
            var response = await client.GeocodeAddress(address);
            if (response.Status == GeocodeStatus.Ok)
            {
                var firstResult = response.Results.First();
                var location = firstResult.Geometry.Location;
                var lat = location.Latitude;
                var lng = location.Longitude;
                Console.Write($"{lat} ${lng}");
            }
        } 

    }
}
