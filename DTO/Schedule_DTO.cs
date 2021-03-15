using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class Schedule_DTO
    {
        private int _ID;
        private DateTime _Date;
        private TimeSpan _Time;
        private string _AircraftName;
        private int _RouteID;
        private string _FlightNumber;
        private decimal _EconomyPrice;
        private bool _Confirmed;
        private string _DepartureAirportName;
        private string _ArrivalAirportName;
        private decimal _BussinessPrice;
        private decimal _FirstClassPrice;

        public int ID { get => _ID; set => _ID = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public TimeSpan Time { get => _Time; set => _Time = value; }
        public string DepartureAirportName { get => _DepartureAirportName; set => _DepartureAirportName = value; }
        public string ArrivalAirportName { get => _ArrivalAirportName; set => _ArrivalAirportName = value; }
        public string AircraftName { get => _AircraftName; set => _AircraftName = value; }
        public int RouteID { get => _RouteID; set => _RouteID = value; }
        public string FlightNumber { get => _FlightNumber; set => _FlightNumber = value; }
        public decimal EconomyPrice { get => _EconomyPrice; set => _EconomyPrice = value; }
        public decimal BussinessPrice { get => _BussinessPrice; set => _BussinessPrice = value; }
        public decimal FirstClassPrice { get => _FirstClassPrice; set => _FirstClassPrice = value; }
        public bool Confirmed { get => _Confirmed; set => _Confirmed = value; }


        public Schedule_DTO()
        {

        }
        public Schedule_DTO( int Id, DateTime date, TimeSpan time, string aircraftName, int routeId, string flightNumber, decimal economyPrice, bool confirmed)
        {
            this.ID = Id;
            this.Date = date;
            this.Time = time;
            this.AircraftName = aircraftName;
            this.RouteID = routeId;
            this.FlightNumber = flightNumber;
            this.EconomyPrice = economyPrice;
            this.Confirmed = confirmed;
        }
    }
}
