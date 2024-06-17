using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_dangkimonhoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxnienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cldmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            rad1.Checked = true;
            cldmonhoc.Items.Add("LT WIN", CheckState.Checked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 2020; i <= 2025; i++)
            {
                cbxnienkhoa.Items.Add(i.ToString());
            }
            cbxlop.Items.Add("Ưng dụng phần mềm 1");
            cbxlop.Items.Add("Ưng dụng phần mềm 2");
            cbxlop.Items.Add("Ưng dụng phần mềm 3");
            cbxlop.Items.Add("thiết kế đồ họa");
            cbxlop.Items.Add("quán lý mạng");
        }

        private void BTNdangky_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã số sinh viên: " + txtMSSV.Text;
            thongtin = "\nHọ và tên: " + txtHOVATEN.Text;
            thongtin += "\nNiên khóa: " + cbxnienkhoa.SelectedItem;
            thongtin += "\nLớp: " + cbxlop.SelectedItem;

            string hocky = "";
            if (rad1.Checked)
            {
                hocky = rad1.Text;
            }
            else if (rad2.Checked)
            {
                hocky = rad2.Text;
            }
            else if (rad3.Checked)
            {
                hocky = rad3.Text;
            }
            else if (rad4.Checked)
            {
                hocky = rad4.Text;
            }
            thongtin += "\nĐã đăng ký học Học Kỳ " + hocky + " các môn học sau:";

            int stt = 1;
            foreach (var Item in cldmonhoc.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + Item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthoat_Clic(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
