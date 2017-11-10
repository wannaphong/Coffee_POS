using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_6034102143
{
    public partial class Form1 : Form
    {
        List<Tuple<double, string>> product = new List<Tuple<double, string>>();
        bool ok=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment); // ลบ Payment ออกจาก tabControl1
        }

        private void ok_pay_Click(object sender, EventArgs e)
        {
            if (ok == false) {
                tabControl1.TabPages.Insert(1,Payment); // เพิ่ม Payment
                ok = true;
                tabControl1.SelectedTab = Payment; // กำหนดให้เลือกTab ชื่อ Payment มาแสดงผล
            }
            else tabControl1.SelectedTab = Payment; // กำหนดให้เลือกTab ชื่อ Payment มาแสดงผล
        }
    }
}
