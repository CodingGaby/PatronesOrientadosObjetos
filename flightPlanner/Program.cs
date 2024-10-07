using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Flyweight: Crear y reutilizar destinos
            DestinationFactory destinationFactory = new DestinationFactory();
            var newYork = destinationFactory.GetDestination("New York", "USA");
            var london = destinationFactory.GetDestination("London", "UK");

            // Prototype: Crear vuelo y clonar
            Flight flight1 = new Flight("AA100", newYork);
            Flight flight2 = (Flight)flight1.Clone();
            flight2.FlightNumber = "AA101";

            flight1.DisplayFlightInfo();
            flight2.DisplayFlightInfo();

            // Adapter: Adaptar aviones nacionales a vuelos internacionales
            INationalPlane nationalPlane = new NationalPlane();
            IInternationalPlane adaptedPlane = new NationalPlaneAdapter(nationalPlane);

            adaptedPlane.FlyInternational("AA102");

            // Usar avión internacional
            IInternationalPlane internationalPlane = new InternationalPlane();
            internationalPlane.FlyInternational("BA200");

            Console.ReadKey();
        }
    }
}
