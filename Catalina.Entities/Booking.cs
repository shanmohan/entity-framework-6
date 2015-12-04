using System.Collections.Generic;

namespace Catalina.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public string BookingNumber { get; set; }
        public List<Segment> Segments { get; set; }
        public List<SSR> ServiceRequests { get; set; }
        public List<OSI> OtherServiceInformation { get; set; }
        public string SkywardsNumber { get; set; }
    }
}
