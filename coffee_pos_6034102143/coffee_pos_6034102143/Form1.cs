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
        List<Tuple<string, string>> product = new List<Tuple<string, string>>();
        //ListViewItem foundItem;
        //string[] itemInList = new string[] { listView1.Items.ToString()
        bool ok=false,click=false;
        double price;
        public string[] getview()
        {
            price = 0;
            string[] stopWordArray = new string[listView1.Items.Count];
            int itemCount = listView1.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                price += double.Parse(listView1.Items[i].SubItems[1].Text); // 1 ดึงราคา
                stopWordArray[i] = listView1.Items[i].SubItems[0].Text.ToString(); // 0 ดึงชื่อรายการ
            }
            p_txt.Text = price.ToString()+ " Baht";
            return stopWordArray;
        }
        public void a()
        {
            product = new List<Tuple<string, string>>();
            if (listView1.SelectedItems.Count == 0)
                return;
            for(int i=0;i< listView1.Items.Count; i++) {
                ListViewItem item0 = listView1.SelectedItems[i];
                product.Add(new Tuple<string, string> (item0.SubItems[0].Text.ToString(), item0.SubItems[1].Text.ToString() ));
            }
        }
        public void showlist(string bath,string product)
        {
            if (click == false)
            {
                listView1.Enabled = true;
                click = true;
            }
            string[] row = { product,bath};
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            var items = listView1.Items;
            //ListViewItem[] itemsa = new ListViewItem[listView1.Items.Count];
            //string[] rrr = new string[listView1.Items.Count];
            //ListViewItem item = new ListViewItem(rrr);
            //listView1.Items.CopyTo(itemsa, 0);
            //a();
            //string[] s = product.Select((t) => t.Value).ToArray();
            //var strings = product[0];
            //Console.WriteLine(strings);
            //string[] items = listView1.Items.Select(x => x.Text).ToArray();
            /*foreach (var value in getview())
            {
                Console.WriteLine(value);
            }*/
            getview();
            }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment); // ลบ Payment ออกจาก tabControl1
            listView1.Enabled = false;
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

        private void Esspresso_hot_Click(object sender, EventArgs e)
        {
            showlist("35", "Esspresso (hot)");
        }

        private void Esspresso_ice_Click(object sender, EventArgs e)
        {
            showlist("45", "Esspresso (Ice)");
        }

        private void Esspresso_frappe_Click(object sender, EventArgs e)
        {
            showlist("50", "Esspresso (Frappe)");
        }

        private void Americano_hot_Click(object sender, EventArgs e)
        {
            showlist("35", "Americano (Hot)");
        }

        private void Latte_hot_Click(object sender, EventArgs e)
        {
            showlist("35", "Latte (Hot)");
        }

        private void Latte_ice_Click(object sender, EventArgs e)
        {
            showlist("45", "Latte (Ice)");
        }

        private void Latte_frappe_Click(object sender, EventArgs e)
        {
            showlist("50", "Latte (Frappe)");
        }

        private void Mocha_hot_Click(object sender, EventArgs e)
        {
            showlist("35", "Mocha (Hot)");
        }

        private void Mocha_ice_Click(object sender, EventArgs e)
        {
            showlist("45", "Mocha (Ice)");
        }

        private void Mocha_frappe_Click(object sender, EventArgs e)
        {
            showlist("50", "Mocha (Frappe)");
        }

        private void Cappuccino_hot_Click(object sender, EventArgs e)
        {
            showlist("35", "Cappuccino (Hot)");
        }

        private void Cappuccino_ice_Click(object sender, EventArgs e)
        {
            showlist("45", "Cappuccino (Ice)");
        }

        private void Cappuccino_frappe_Click(object sender, EventArgs e)
        {
            showlist("50", "Cappuccino (Frappe)");
        }

        private void GreenIce_hot_Click(object sender, EventArgs e)
        {
            showlist("20", "GreenIce (Hot)");
        }

        private void GreenIce_ice_Click(object sender, EventArgs e)
        {
            showlist("25", "GreenIce (Ice)");
        }

        private void GreenIce_frappe_Click(object sender, EventArgs e)
        {
            showlist("30", "GreenIce (Frappe)");
        }

        private void Thai_Tea_hot_Click(object sender, EventArgs e)
        {
            showlist("20", "Thai Tea (Hot)");
        }

        private void Thai_Tea_ice_Click(object sender, EventArgs e)
        {
            showlist("25", "Thai Tea (Ice)");
        }

        private void Thai_Tea_frappe_Click(object sender, EventArgs e)
        {
            showlist("30", "Thai Tea (Frappe)");
        }

        private void CoCoa_hot_Click(object sender, EventArgs e)
        {
            showlist("20", "CoCoa (Hot)");
        }

        private void CoCoa_ice_Click(object sender, EventArgs e)
        {
            showlist("25", "CoCoa (Ice)");
        }

        private void CoCoa_frappe_Click(object sender, EventArgs e)
        {
            showlist("30", "CoCoa (Frappe)");
        }

        private void Milk_hot_Click(object sender, EventArgs e)
        {
            showlist("20", "Milk (Hot)");
        }

        private void Milk_ice_Click(object sender, EventArgs e)
        {
            showlist("25", "Milk (Ice)");
        }

        private void milk_tea_ice_Click(object sender, EventArgs e)
        {
            showlist("25", "Milk Tea (Ice)");
        }

        private void milk_tea_frappe_Click(object sender, EventArgs e)
        {
            showlist("30", "Milk Tea (Frappe)");
        }

        private void lemon_tea_Click(object sender, EventArgs e)
        {
            showlist("25", "Lemon Tea (Ice)");
        }

        private void lemon_tea2_Click(object sender, EventArgs e)
        {
            showlist("30", "Lemon Tea (Frappe)");
        }

        private void milo1_Click(object sender, EventArgs e)
        {
            showlist("20", "Milo (Hot)");
        }

        private void Milk2_Click(object sender, EventArgs e) // Milo
        {
            showlist("25", "Milo (Ice)");
        }

        private void button39_Click(object sender, EventArgs e) // Milo
        {
            showlist("30", "Milo (Frappe)");
        }

        private void nescafe1_Click(object sender, EventArgs e)
        {
            showlist("20", "Nescafe (Hot)");
        }

        private void Nescafe2_Click(object sender, EventArgs e)
        {
            showlist("25", "Nescafe (Ice)");
        }

        private void Nescafe3_Click(object sender, EventArgs e)
        {
            showlist("30", "Nescafe (Frappe)");
        }

        private void nestca_tea_Click(object sender, EventArgs e)
        {
            showlist("25", "Nestca Tea (Ice)");
        }

        private void nestca_tea_2_Click(object sender, EventArgs e)
        {
            showlist("30", "Nestca Tea (Ice)");
        }

        private void ls_Click(object sender, EventArgs e)
        {
            showlist("25", "Ltalian Soda (Ice)");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            showlist("25", "Red lime Soda (Ice)");
        }

        private void honey_lime_soda_Click(object sender, EventArgs e)
        {
            showlist("25", "Honey lime Soda (Ice)");
        }

        private void Americano_ice_Click(object sender, EventArgs e)
        {
            showlist("45", "Americano (Ice)");
        }
    }
}
