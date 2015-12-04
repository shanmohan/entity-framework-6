using System;

namespace Catalina.Entities
{
    public class Segment
    {
        public int Id { get; set; }
        public String From { get; set; }
        public String To { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int InfantCount { get; set; }
    }
}