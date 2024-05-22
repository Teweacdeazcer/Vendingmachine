using Kiosk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk
{
    public partial class ChangeForm : Form
    {
        private int change;
        public ChangeForm(int change)
        {
            InitializeComponent();
            this.change = change;
            changelbl.Text = change.ToString();
        }
        public void CalculateChange(List<string> items)
        {
            foreach (string item in items)
            {
                listBox1.Items.Add(item);
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            // 현재 열린 모든 폼을 탐색하여 ChoiceForm만 남기고 닫기
            ChoiceForm Initialform = null;

            // 먼저 ChoiceForm을 찾기.
            foreach (Form form in Application.OpenForms)
            {
                if (form is ChoiceForm)
                {
                    Initialform = (ChoiceForm)form;
                    break;
                }
            }

            // ChoiceForm이 이미 열려 있다면 초기화하고 보이도록 설정.
            if (Initialform != null)
            {
                Initialform.InitializeForm();
                Initialform.Show();
            }
            else
            {
                // ChoiceForm이 열려있지 않다면 새로 생성.
                Initialform = new ChoiceForm();
                Initialform.Show();
            }

            // 현재 열린 폼들 중 ChoiceForm을 제외한 나머지 폼 닫기.
            var formsToClose = Application.OpenForms.Cast<Form>().Where(f => f != Initialform).ToList();
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }
    }
}
