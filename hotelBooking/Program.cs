using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso del patrón Bridge
            IReservation creditCard = new CreditCardReservation();
            Room singleRoom = new SingleRoom(creditCard);
            singleRoom.BookRoom();

            // Uso del patrón Proxy
            IRoomBooking bookingProxy = new RoomBookingProxy(isAuthenticated: true);
            bookingProxy.Book("Double Room");

            // Uso del patrón Strategy
            RoomPriceContext priceContext = new RoomPriceContext(new SeasonalDiscountStrategy());
            decimal finalPrice = priceContext.ApplyDiscount(200m);
            Console.WriteLine($"Final room price after discount: {finalPrice}");

            Console.ReadKey();
        }
    }

}
