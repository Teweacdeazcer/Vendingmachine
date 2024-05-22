using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
            InitializeForm();
        }
        private int ordermoney = 0;
        public void InitializeForm()
        {
            ordermoney = 0;
            listBox1.Items.Clear();
            pricelbl.Text = ordermoney.ToString();
        }
        private void BurgerBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("햄버거 : 4500원");
            listBox1.Items.Add("햄버거");
            ordermoney += 4500;
            pricelbl.Text = ordermoney.ToString();
        }
        private void colaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("콜라 : 1500원");
            listBox1.Items.Add("콜라");
            ordermoney += 1500;
            pricelbl.Text = ordermoney.ToString();
        }
        private void setmenuBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("세트메뉴 : 7200원");
            listBox1.Items.Add("세트메뉴");
            ordermoney += 7200;
            pricelbl.Text = ordermoney.ToString();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();
                MessageBox.Show(selectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // 삭제된 아이템의 가격을 현재 금액에서 빼기
                switch (selectedItem)
                {
                    case "햄버거":
                        ordermoney -= 4500;
                        break;
                    case "콜라":
                        ordermoney -= 1500;
                        break;
                    case "세트메뉴":
                        ordermoney -= 7200;
                        break;
                }

                // 빼고 난 후의 금액을 pricelbl에 반영
                pricelbl.Text = ordermoney.ToString();
            }
        }
        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                PaymentForm child = new PaymentForm(listBox1.Items.Cast<string>().ToList());
                child.ShowDialog();
            } else MessageBox.Show("음식을 선택하세요.");
        }
    }
}
