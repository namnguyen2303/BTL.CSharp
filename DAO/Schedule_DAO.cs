using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
namespace DAO
{
    public class Schedule_DAO
    {
        //Ket noi database
        dbDataContext cnn = new dbDataContext();
        //Hien thi du lieu va sap xep mac dinh theo Date-time

        public void ShowSchedules(DataGridView dgv)
        {
            try
            {
                var query = (from sch in cnn.Schedules
                             join ac in cnn.Aircrafts on sch.AircraftID equals ac.ID
                             join rou in cnn.Routes on sch.RouteID equals rou.ID
                             join apd in cnn.Airports on rou.DepartureAirportID equals apd.ID
                             join apa in cnn.Airports on rou.ArrivalAirportID equals apa.ID
                             orderby sch.Date descending, sch.Time descending
                             select new
                             {
                                 ID = sch.ID,
                                 Date = sch.Date,
                                 Time = sch.Time,
                                 DepartureAirportName = apd.IATACode,
                                 ArrivalAirportName = apa.IATACode,
                                 AircraftName = ac.Name,
                                 FlightNumber = sch.FlightNumber,
                                 EconomyPrice = String.Format("{0:0.}", sch.EconomyPrice),
                                 BussinessPrice = String.Format("{0:0.}", (sch.EconomyPrice) * (decimal)1.35),
                                 FirstClassPrice = String.Format("{0:0.}", (sch.EconomyPrice) * (decimal)(1.35 * 1.3)),
                                 //BussinessPrice = ((sch.EconomyPrice) * (decimal)1.35),
                                 //FirstClassPrice = (sch.EconomyPrice) * (decimal)(1.35 * 1.3),
                                 Confirmed = sch.Confirmed
                             });
                if (query != null && query.Count() > 0)
                {
                    dgv.DataSource = query;
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        // sap xep theo EconomyPrice
        public void SortByEconomy(DataGridView dgv)
        {
            try
            {
                var query = (from sch in cnn.Schedules
                             join ac in cnn.Aircrafts on sch.AircraftID equals ac.ID
                             join rou in cnn.Routes on sch.RouteID equals rou.ID
                             join apd in cnn.Airports on rou.DepartureAirportID equals apd.ID
                             join apa in cnn.Airports on rou.ArrivalAirportID equals apa.ID
                             orderby sch.EconomyPrice descending
                             select new
                             {
                                 ID = sch.ID,
                                 Date = sch.Date,
                                 Time = sch.Time,
                                 DepartureAirportName = apd.IATACode,
                                 ArrivalAirportName = apa.IATACode,
                                 AircraftName = ac.Name,
                                 FlightNumber = sch.FlightNumber,
                                 EconomyPrice = sch.EconomyPrice,
                                 BussinessPrice = (sch.EconomyPrice) * (decimal)1.35,
                                 FirstClassPrice = (sch.EconomyPrice) * (decimal)(1.35 * 1.3),
                                 Confirmed = sch.Confirmed
                             });
                dgv.DataSource = query;
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        // sap xep theo confirmed
        public void SortByConfirmed(DataGridView dgv)
        {
            try
            {
                var query = (from sch in cnn.Schedules
                             join ac in cnn.Aircrafts on sch.AircraftID equals ac.ID
                             join rou in cnn.Routes on sch.RouteID equals rou.ID
                             join apd in cnn.Airports on rou.DepartureAirportID equals apd.ID
                             join apa in cnn.Airports on rou.ArrivalAirportID equals apa.ID
                             orderby sch.Confirmed descending
                             select new
                             {
                                 ID = sch.ID,
                                 Date = sch.Date,
                                 Time = sch.Time,
                                 DepartureAirportName = apd.IATACode,
                                 ArrivalAirportName = apa.IATACode,
                                 AircraftName = ac.Name,
                                 FlightNumber = sch.FlightNumber,
                                 EconomyPrice = sch.EconomyPrice,
                                 BussinessPrice = (sch.EconomyPrice) * (decimal)1.35,
                                 FirstClassPrice = (sch.EconomyPrice) * (decimal)(1.35 * 1.3),
                                 Confirmed = sch.Confirmed
                             });
                dgv.DataSource = query;
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        // do dl ra combobox
        public void GetIATACode(ComboBox cmb)
        {
            try
            {
                var query = (from ap in cnn.Airports
                             select ap.IATACode).Distinct().ToList();
                cmb.DataSource = query;
                cmb.DisplayMember = "IATACode";
                cmb.ValueMember = "ID";
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        // tim kiem
        public void SearchSchedules(DataGridView dgv, string cmbFrom, string cmbTo, string date, string flightNumber)
        {
            try
            {
                var queryable = (from sch in cnn.Schedules
                                 join ac in cnn.Aircrafts on sch.AircraftID equals ac.ID
                                 join rou in cnn.Routes on sch.RouteID equals rou.ID
                                 join apd in cnn.Airports on rou.DepartureAirportID equals apd.ID
                                 join apa in cnn.Airports on rou.ArrivalAirportID equals apa.ID
                                 select new
                                 {
                                     ID = sch.ID,
                                     Date = sch.Date,
                                     Time = sch.Time,
                                     DepartureAirportName = apd.IATACode,
                                     ArrivalAirportName = apa.IATACode,
                                     AircraftName = ac.Name,
                                     FlightNumber = sch.FlightNumber,
                                     EconomyPrice = String.Format("{0:0.##}", sch.EconomyPrice),
                                     BussinessPrice = (sch.EconomyPrice) * (decimal)1.35,
                                     FirstClassPrice = (sch.EconomyPrice) * (decimal)(1.35 * 1.3),
                                     Confirmed = sch.Confirmed
                                 }).ToList();
                if (cmbFrom != null && cmbFrom != "")
                {
                    queryable = queryable.Where(u => u.DepartureAirportName.Equals(cmbFrom)).ToList();
                }
                if (cmbTo != null && cmbTo != "")
                {
                    queryable = queryable.Where(u => u.ArrivalAirportName.Equals(cmbTo)).ToList();
                }
                if (date != null && date != "")
                {
                    queryable = queryable.Where(u => u.Date.Equals(Convert.ToDateTime(date))).ToList();
                }
                if (flightNumber != null && flightNumber != "")
                {
                    queryable = queryable.Where(u => u.FlightNumber.Equals(flightNumber)).ToList();
                }
                //kiem tra du lieu null hay khong
                if (queryable != null && queryable.Count() > 0)
                {
                    dgv.DataSource = queryable;
                }
                else
                {
                    dgv.DataSource = null;
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        // Thay doi trang thai cua chuyen bay
        public void ChangeFlight(int IDRowCurrent, bool confirm)
        {
            var query = cnn.Schedules.SingleOrDefault(u => u.ID.Equals(IDRowCurrent));
            if (confirm == true)
            {
                query.Confirmed = false;
                cnn.SubmitChanges();
            }
            else
            {
                query.Confirmed = true;
                cnn.SubmitChanges();
            }
        }
        // Sua lich trinh bay
        public void UpdateSchedule(string ID, string Date, string Time, string EconomyPrice)
        {
            var query = cnn.Schedules.SingleOrDefault(u => u.ID.Equals(ID));
            if (query != null)
            {
                query.Date = Convert.ToDateTime(Date);
                query.Time = TimeSpan.Parse(Time);
                query.EconomyPrice = Decimal.Parse(EconomyPrice);
                cnn.SubmitChanges();
            }
        }

        //Acess FORM 3
        public int getAirportID(string IATACode)
        {
            var query = cnn.Airports.SingleOrDefault(u => u.IATACode.Equals(IATACode));
            return query.ID;
        }
        public int getRouteID(int from, int to)
        {
            var query = cnn.Routes.SingleOrDefault(u => u.DepartureAirportID.Equals(from) && u.ArrivalAirportID.Equals(to));
            return query.ID;
        }

        //check to add
        public int checkToAdd(string date, string flightNumber)
        {
            var query = cnn.Schedules.SingleOrDefault(u => u.Date.Equals(Convert.ToDateTime(date)) && u.FlightNumber.Equals(flightNumber));
            if (query == null)
            {
                return 0;
            }
            else return 1;
        }
        public void AddSchedule(Schedule s)
        {
            try
            {
                Schedule sch = new Schedule();
                sch.Date = s.Date;
                sch.Time = s.Time;
                sch.FlightNumber = s.FlightNumber;
                sch.RouteID = s.RouteID;
                sch.AircraftID = s.AircraftID;
                sch.Confirmed = s.Confirmed;
                sch.EconomyPrice = s.EconomyPrice;
                cnn.Schedules.InsertOnSubmit(sch);
                cnn.SubmitChanges();
            }
            catch(Exception e)
            {
                e.ToString();
            }

        }
        public int getIDToEdit(string date, string flightNumber)
        {
                var query = cnn.Schedules.SingleOrDefault(u => u.Date.Equals(Convert.ToDateTime(date)) && u.FlightNumber.Equals(flightNumber));
                return query.ID;
               
        }
        public void EditSchedule(Schedule s)
        {
            try
            {
                var query = cnn.Schedules.SingleOrDefault(u => u.ID.Equals(s.ID));
                if (query != null)
                {
                    query.ID = s.ID;
                    query.RouteID = s.RouteID;
                    query.AircraftID = s.AircraftID;
                    query.Date = s.Date;
                    query.Time = s.Time;
                    query.EconomyPrice = s.EconomyPrice;
                    cnn.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch(Exception e)
            {
                e.ToString();
            }

        }
    }
}
