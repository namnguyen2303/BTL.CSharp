using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;
namespace GUI
{
    public partial class FormApplyScheduleChanges : Form
    {
        Schedule_DTO sch_DTO = new Schedule_DTO();
        Schedule_BUS sch_BUS = new Schedule_BUS();
        public FormApplyScheduleChanges()
        {
            InitializeComponent();
        }

        private void FormApplyScheduleChanges_Load(object sender, EventArgs e)
        {

        }

        private void FormApplyScheduleChanges_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManagerFlightSchedules frmManage = new FormManagerFlightSchedules();
            frmManage.Show();
            this.Hide();
        }
        //ham lay AircraptID
        public int getRouteID(int from, int to)
        {
            return sch_BUS.getRouteID(from, to);
        }
        //lay AirportID
        public int getAirportID(string IATACode)
        {
            return sch_BUS.getAirportID(IATACode);
        }
        public int checkToAdd(string date, string flightNumber)
        {
            return sch_BUS.checkToAdd(date, flightNumber);
        }
        public void AddSchedule(Schedule s)
        {
           sch_BUS.AddSchedule(s);
        }
        //ham tim ID cua schedule de sua

        private void btnImport_Click(object sender, EventArgs e)
        {
            int success = 0;
            int duplicate = 0;
            int miss = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection cnn = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + openFileDialog1.FileName + "';Extended Properties=Excel 8.0;");
                txtUrlImport.Text = openFileDialog1.FileName.ToString();

                DataTable table = new DataTable();
                OleDbDataAdapter dap = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", cnn);
                //if(openFileDialog1.Filter == "Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm")
                //{
                    dap.Fill(table);
                //}
                //else
                //{
                //    MessageBox.Show("file không đúng định dạng");
                //}
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        if (row[0].ToString().Equals("") || row[1].ToString().Equals("") || row[2].ToString().Equals("") || row[3].ToString().Equals("") || row[4].ToString().Equals("") || row[5].ToString().Equals("") || row[6].ToString().Equals("") || row[7].ToString().Equals("") || row[8].ToString().Equals(""))
                        {
                            miss++;
                        }
                        else 
                        {
                            //ADD || check row[0] có phải là ADD 
                            if (row[0].ToString().ToUpper().Equals("ADD"))
                            {
                                // check điều kiện nếu chưa tồn tại Schedule thì thêm
                                if (checkToAdd(row[1].ToString(), row[3].ToString()) == 0)
                                {
                                    Schedule sch = new Schedule();
                                    sch.Date = Convert.ToDateTime(row[1].ToString());
                                    sch.Time = TimeSpan.Parse(Convert.ToDateTime(row[2].ToString()).ToString("HH:mm"));
                                    sch.FlightNumber = row[3].ToString();
                                    sch.RouteID = getRouteID(getAirportID(row[4].ToString()), getAirportID(row[5].ToString()));
                                    sch.AircraftID = Convert.ToInt32(row[6].ToString());
                                    sch.EconomyPrice = decimal.Parse(row[7].ToString());
                                    if (row[8].ToString().ToUpper().Equals("OK"))
                                    {
                                        sch.Confirmed = true;
                                    }
                                    else
                                    {
                                        sch.Confirmed = false;
                                    }
                                    AddSchedule(sch);
                                    success++;
                                }
                                // nếu là ADD mà đã tồn tại schedule thì lỗi ++
                                else duplicate++;
                            }
                            //EDIT 
                            else
                            {// nếu là EDIT và thỏa mãn tồn tại Schedule thì sửa
                                //row[0].ToString().ToUpper().Equals("EDIT") && 
                                if (checkToAdd(row[1].ToString(), row[3].ToString()) == 1)
                                {
                                    Schedule sch = new Schedule();
                                    sch.ID = sch_BUS.getIDToEdit(row[1].ToString(), row[3].ToString());
                                    sch.Date = Convert.ToDateTime(row[1].ToString());
                                    sch.Time = TimeSpan.Parse(Convert.ToDateTime(row[2].ToString()).ToString("HH:mm"));
                                    sch.FlightNumber = row[3].ToString();
                                    sch.RouteID = getRouteID(getAirportID(row[4].ToString()), getAirportID(row[5].ToString()));
                                    sch.AircraftID = Convert.ToInt32(row[6].ToString());
                                    sch.EconomyPrice = decimal.Parse(row[7].ToString());
                                    if (row[8].ToString().ToUpper().Equals("OK"))
                                    {
                                        sch.Confirmed = true;
                                    }
                                    else
                                    {
                                        sch.Confirmed = false;
                                    }
                                    sch_BUS.EditSchedule(sch);
                                    success++;
                                }
                                //nếu là EDIT nhưng không thỏa mãn tồn tại Schedule() thì lỗi++
                                else miss++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        miss++;
                        ex.ToString();
                    }
                }
            }
            lblSuccess.Text = Convert.ToString(success);
            lblDuplicate.Text = Convert.ToString(duplicate);
            lblMiss.Text = Convert.ToString(miss);
        }
    }
}
