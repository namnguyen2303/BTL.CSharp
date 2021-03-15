using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class FormManagerFlightSchedules : Form
    {
        // khoi tao obj controller
        Schedule_BUS sch_BUS = new Schedule_BUS();
        public FormManagerFlightSchedules()
        {
            InitializeComponent();
        }
        // form load
        private void FormManagerFlightSchedules_Load(object sender, EventArgs e)
        {
            // hien thi danh sach lich trinh bay
            sch_BUS.ShowSchedules(dgvSchedules);
            // hide nhung dong k can thiet
            dgvSchedules.Columns["ID"].Visible = false;
            dgvSchedules.Columns["Confirmed"].Visible = false;
            dgvSchedules.Columns["AircraftName"].Visible = false;
            // set gia tri mac dinh cho combobox sort
            cmbSort.SelectedItem = "Date-time";
            // goi ham doi mau
            ChangeColor(dgvSchedules);
            // hien thi danh sach san bay From len combobox
            sch_BUS.GetIATACode(cmbFrom);
            // hien thi danh sach san bay To len combobox
            sch_BUS.GetIATACode(cmbTo);
            
        }
        // combobox sap xep
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.Text.Equals("Date-time"))
            {
                sch_BUS.ShowSchedules(dgvSchedules);
            }
            else if (cmbSort.Text.Equals("EconomyPrice"))
            {
                sch_BUS.SortByEconomy(dgvSchedules);
            }
            else if (cmbSort.Text.Equals("Confirmed"))
            {
                sch_BUS.SortByConfirmed(dgvSchedules);
            }
            ChangeColor(dgvSchedules);

        }
        // Tim kiem 
        private void btnApply_Click(object sender, EventArgs e)
        {
            DateTime dateEdit;
            if (cmbFrom.Text == cmbTo.Text && cmbFrom.Text != "")
            {
                MessageBox.Show("Sân bay đến và sân bay đi không thể giống nhau! Vui lòng chọn lại");
            }
            else if (!DateTime.TryParse(txtDate.Text, out dateEdit) && txtDate.Text != "") 
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày: 'dd/MM/yyyy'");
            }
            else
            {
                sch_BUS.SearchSchedules(dgvSchedules, cmbFrom.Text, cmbTo.Text, txtDate.Text, txtFlightNumber.Text);
                ChangeColor(dgvSchedules);
            }
        }
        // ham thay doi mau row
        public void ChangeColor(DataGridView dgv)
        {
            for(int i = 0; i< dgv.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv.Rows[i].Cells["Confirmed"].Value) == false)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = default;
                }
            }
        }
        // Huy & Xac nhan chuyen bay
        private void btnCancelFlight_Click(object sender, EventArgs e)
        {
            // get vi tri dong hien tai
            int i = dgvSchedules.CurrentCell.RowIndex;
            // get id cua dong hien tai
            int IDRowCurrent = Convert.ToInt32(dgvSchedules.Rows[i].Cells["ID"].Value);
            // get confirm cua dong hien tai
            bool confirm = Convert.ToBoolean(dgvSchedules.Rows[i].Cells["Confirmed"].Value);
            //huy chuyen bay
            if (confirm == true)
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn hủy chuyến bay", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    sch_BUS.ChangeFlight(IDRowCurrent, confirm);
                    sch_BUS.ShowSchedules(dgvSchedules);
                    ChangeColor(dgvSchedules);
                    MessageBox.Show("Hủy chuyến bay thành công!");
                }
            }
            //xac nhan chuyen bay
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xác nhận chuyến bay", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    sch_BUS.ChangeFlight(IDRowCurrent, confirm);
                    sch_BUS.ShowSchedules(dgvSchedules);
                    ChangeColor(dgvSchedules);
                    MessageBox.Show("Xác nhận chuyến bay thành công!");
                }
            }
        }
        private void dgvSchedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                //cmbFrom.Text = dgvSchedules.Rows[i].Cells["DepartureAirportName"].Value.ToString();
                //cmbTo.Text = dgvSchedules.Rows[i].Cells["ArrivalAirportName"].Value.ToString();
                //txtDate.Text = Convert.ToDateTime(dgvSchedules.Rows[i].Cells["Date"].Value).ToString("dd/MM/yyyy");
                //txtFlightNumber.Text = dgvSchedules.Rows[i].Cells["FlightNumber"].Value.ToString();
                if (Convert.ToBoolean(dgvSchedules.Rows[i].Cells["Confirmed"].Value) == true)
                {
                    btnCancelFlight.Text = "Cancel Flight";
                    btnCancelFlight.BackColor = Color.Red;
                }
                else
                {
                    btnCancelFlight.Text = "Confirm Flight";
                    btnCancelFlight.BackColor = Color.GreenYellow;

                }
            }
            catch(Exception ex)
            {
                ChangeColor(dgvSchedules);
                ex.ToString();
            }
        }
        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            //get vi tri cua row hien tai
            int i = dgvSchedules.CurrentCell.RowIndex;

            int ID = Convert.ToInt32(dgvSchedules.Rows[i].Cells["ID"].Value);
            string DepartureAirportName = dgvSchedules.Rows[i].Cells["DepartureAirportName"].Value.ToString();
            string ArrivalAirportName = dgvSchedules.Rows[i].Cells["ArrivalAirportName"].Value.ToString();
            string AircraftName = dgvSchedules.Rows[i].Cells["AircraftName"].Value.ToString();
            string Date = Convert.ToDateTime(dgvSchedules.Rows[i].Cells["Date"].Value).ToString("dd/MM/yyyy");
            string Time = dgvSchedules.Rows[i].Cells["Time"].Value.ToString();
            string EconomyPrice = dgvSchedules.Rows[i].Cells["EconomyPrice"].Value.ToString();

            FormEditSchedules frmEdit = new FormEditSchedules(ID, DepartureAirportName, ArrivalAirportName,AircraftName, Date, Time, EconomyPrice);
            frmEdit.Show();
            this.Hide();
        }

        private void btnImportChanges_Click(object sender, EventArgs e)
        {
            FormApplyScheduleChanges frmImport = new FormApplyScheduleChanges();
            frmImport.Show();
            this.Hide();
        }

        private void dgvSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
