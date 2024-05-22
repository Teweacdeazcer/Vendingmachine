namespace Kiosk
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderlbl = new System.Windows.Forms.Label();
            this.moneylbl = new System.Windows.Forms.Label();
            this.money_1000Btn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.money_10000Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(140, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(101, 100);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(63, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문 금액 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(63, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "투입 금액 :";
            // 
            // orderlbl
            // 
            this.orderlbl.AutoSize = true;
            this.orderlbl.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderlbl.Location = new System.Drawing.Point(151, 131);
            this.orderlbl.Name = "orderlbl";
            this.orderlbl.Size = new System.Drawing.Size(32, 20);
            this.orderlbl.TabIndex = 3;
            this.orderlbl.Text = "0원";
            // 
            // moneylbl
            // 
            this.moneylbl.AutoSize = true;
            this.moneylbl.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.moneylbl.Location = new System.Drawing.Point(151, 165);
            this.moneylbl.Name = "moneylbl";
            this.moneylbl.Size = new System.Drawing.Size(32, 20);
            this.moneylbl.TabIndex = 4;
            this.moneylbl.Text = "0원";
            // 
            // money_1000Btn
            // 
            this.money_1000Btn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.money_1000Btn.Location = new System.Drawing.Point(210, 161);
            this.money_1000Btn.Name = "money_1000Btn";
            this.money_1000Btn.Size = new System.Drawing.Size(88, 31);
            this.money_1000Btn.TabIndex = 5;
            this.money_1000Btn.Text = "천원투입";
            this.money_1000Btn.UseVisualStyleBackColor = true;
            this.money_1000Btn.Click += new System.EventHandler(this.money_1000Btn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBtn.Location = new System.Drawing.Point(210, 198);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(88, 29);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "결제확인";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // money_10000Btn
            // 
            this.money_10000Btn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.money_10000Btn.Location = new System.Drawing.Point(210, 127);
            this.money_10000Btn.Name = "money_10000Btn";
            this.money_10000Btn.Size = new System.Drawing.Size(88, 31);
            this.money_10000Btn.TabIndex = 7;
            this.money_10000Btn.Text = "만원투입";
            this.money_10000Btn.UseVisualStyleBackColor = true;
            this.money_10000Btn.Click += new System.EventHandler(this.money_10000Btn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 248);
            this.Controls.Add(this.money_10000Btn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.money_1000Btn);
            this.Controls.Add(this.moneylbl);
            this.Controls.Add(this.orderlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "PaymentForm";
            this.Text = "결제하기";
            this.Click += new System.EventHandler(this.checkBtn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orderlbl;
        private System.Windows.Forms.Label moneylbl;
        private System.Windows.Forms.Button money_1000Btn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button money_10000Btn;
    }
}