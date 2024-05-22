using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class PaymentForm : Form
    {
        private int inputmoney = 0;
        public PaymentForm()
        {
            InitializeComponent();
            
        }
        public PaymentForm(List<string> items)
        {
            InitializeComponent();

            // 부모 폼의 리스트박스 항목을 자식 폼의 리스트박스에 추가
            foreach (string item in items)
            {
                listBox1.Items.Add(item);
            }
            // 주문 금액 계산 및 표시
            int orderMoney = CalculateMoney(items);
            orderlbl.Text = orderMoney.ToString();
        }
        private int CalculateMoney(List<string> items)
        {
            int orderMoney = 0;
            foreach (string item in items)
            {
                switch (item)
                {
                    case "햄버거":
                        orderMoney += 4500;
                        break;
                    case "콜라":
                        orderMoney += 1500;
                        break;
                    case "세트메뉴":
                        orderMoney += 7200;
                        break; 
                }
            }
            return orderMoney;
        }
        private void money_10000Btn_Click(object sender, EventArgs e)
        {
            inputmoney += 10000;
            moneylbl.Text = inputmoney.ToString();
        }
        private void money_1000Btn_Click(object sender, EventArgs e)
        {
            inputmoney += 1000;
            moneylbl.Text = inputmoney.ToString();
        }
        private void checkBtn_Click(object sender, EventArgs e)
        {
            int Input = int.Parse(moneylbl.Text);
            int Order = int.Parse(orderlbl.Text);
            int change = Input - Order;

            if (change >= 0)  
            {
                CompleteForm changeForm = new CompleteForm(change);
                changeForm.CalculateChange(listBox1.Items.Cast<string>().ToList());
                changeForm.ShowDialog();
            }else MessageBox.Show("투입한 금액이 부족합니다.");
        }
    }
}
