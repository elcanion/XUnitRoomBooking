using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBookingApp.Core.Tests
{
    public class RoomBookingRequestProcessorTest
    {
        public object RoomBookingResut { get; private set; }

        [Fact]
        public void Should_Return_Room_Booking_Response_With_Request_Values()
        {
            // Arrange
            var bookingRequest = new RoomBookingRequest
            {
                FullName = "TestName",
                Email = "test@request.com",
                DateOnly = new DateTime(2021, 10, 20)
            };
            var processor = new RoomBookingRequestProcessor();

            RoomBookingResut = processor.BookRoom(bookingRequest);
        }
    }
}
