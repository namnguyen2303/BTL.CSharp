using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Windows.Forms;
namespace BUS
{
    public class Schedule_BUS
    {
        Schedule_DAO sch_DAO = new Schedule_DAO();
        public void ShowSchedules(DataGridView dgv)
        {
            sch_DAO.ShowSchedules(dgv);
        }
        public void SortByEconomy(DataGridView dgv)
        {
            sch_DAO.SortByEconomy(dgv);
        }
        public void SortByConfirmed(DataGridView dgv)
        {
            sch_DAO.SortByConfirmed(dgv);
        }
        public void GetIATACode(ComboBox cmb)
        {
            sch_DAO.GetIATACode(cmb);
        }
        public void SearchSchedules(DataGridView dgv, string cmbFrom, string cmbTo, string date, string flightNumber)
        {
            sch_DAO.SearchSchedules(dgv, cmbFrom, cmbTo, date, flightNumber);
        }
        public void ChangeFlight(int IDRowCurrent, bool confirm)
        {
            sch_DAO.ChangeFlight(IDRowCurrent, confirm);
        }
        // Edit Flight
        public void UpdateSchedule(string ID, string Date, string Time, string EconomyPrice)
        {
            sch_DAO.UpdateSchedule(ID, Date, Time, EconomyPrice);
        }
        // Form3
        public int getAirportID(string IATACode)
        {
            return sch_DAO.getAirportID(IATACode);
        }
        public int getRouteID(int from, int to)
        {
            return sch_DAO.getRouteID(from, to);
        }
        public int checkToAdd(string date, string flightNumber)
        {
            return sch_DAO.checkToAdd(date, flightNumber);
        }
        public void AddSchedule(Schedule s)
        {
            sch_DAO.AddSchedule(s);
        }
        //ham tim ID cua schedule de sua
        public int getIDToEdit(string date, string flightNumber)
        {
            return sch_DAO.getIDToEdit(date, flightNumber);
        }
        public void EditSchedule(Schedule s)
        {
            sch_DAO.EditSchedule(s);
        }
        
    }
}
