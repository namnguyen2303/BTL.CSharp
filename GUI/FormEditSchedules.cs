using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class FormEditSchedules : Form
    {
        public FormManagerFlightSchedules frmManage = new FormManagerFlightSchedules();
        //khoi tao obj controller
        Schedule_BUS sch_BUS = new Schedule_BUS();
        public FormEditSchedules()
        {
            InitializeComponent();
        }
        public FormEditSchedules(int ID, string DepartureAirportName, string ArrivalAirportName, string AircraftName, string Date, string Time, string EconomyPrice ) : this()
        {
            lblID.Text = ID.ToString();
            lblID.Visible = false;

            lblFrom.Text = DepartureAirportName;
            lblTo.Text = ArrivalAirportName;
            lblAircraft.Text = AircraftName;
            txtDateEdit.Text = Date;
            txtTimeEdit.Text = Time;
            txtEconomyEdit.Text = EconomyPrice;
            
        }

        private void FormEditSchedules_Load(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Red;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmManage.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dateEdit;
            TimeSpan timeEdit;
            decimal economyPrice;

            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn sửa lịch trình bay này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (!DateTime.TryParse(txtDateEdit.Text, out dateEdit))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày: 'dd/MM/yyyy'");
                }
                else if (!TimeSpan.TryParse(txtTimeEdit.Text, out timeEdit))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng giờ: 'HH:mm'");
                }
                else if (!decimal.TryParse(txtEconomyEdit.Text, out economyPrice))
                {
                    MessageBox.Show("Giá tiền phải là số!");
                }
                else
                {
                    sch_BUS.UpdateSchedule(lblID.Text, txtDateEdit.Text, txtTimeEdit.Text, txtEconomyEdit.Text);
                    MessageBox.Show("Sửa lịch trình bay thành công!");
                    frmManage.Show();
                    this.Hide();
                }

            }
        }
    }
}
