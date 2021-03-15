using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Route_DTO
    {
        private int _ID;
        private int _DepartureAirportID;
        private int _ArrivalAirportID;
        private int _Distance;
        private DateTime _FlightTime;
        public int ID { get => _ID; set => _ID = value; }
        public int DepartureAirportID { get => _DepartureAirportID; set => _DepartureAirportID = value; }
        public int ArrivalAirportID { get => _ArrivalAirportID; set => _ArrivalAirportID = value; }
        public int Distance { get => _Distance; set => _Distance = value; }
        public DateTime FlightTime { get => _FlightTime; set => _FlightTime = value; }
            
        public Route_DTO()
        {

        }
        public Route_DTO(int Id, int departureAirportId, int arrivalAirportID, int distance, DateTime flihgtTime)
        {
            this.ID = Id;
            this.DepartureAirportID = departureAirportId;
            this.ArrivalAirportID = arrivalAirportID;
            this.Distance = distance;
            this.FlightTime = flihgtTime;
        }

    }
}
