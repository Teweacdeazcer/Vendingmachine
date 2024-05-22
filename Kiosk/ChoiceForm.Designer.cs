namespace Kiosk
{
    partial class ChoiceForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.colaBtn = new System.Windows.Forms.Button();
            this.BurgerBtn = new System.Windows.Forms.Button();
            this.setmenuBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colaBtn
            // 
            this.colaBtn.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.colaBtn.Location = new System.Drawing.Point(142, 32);
            this.colaBtn.Name = "colaBtn";
            this.colaBtn.Size = new System.Drawing.Size(101, 64);
            this.colaBtn.TabIndex = 0;
            this.colaBtn.Text = "콜라";
            this.colaBtn.UseVisualStyleBackColor = true;
            this.colaBtn.Click += new System.EventHandler(this.colaBtn_Click);
            // 
            // BurgerBtn
            // 
            this.BurgerBtn.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.BurgerBtn.Location = new System.Drawing.Point(35, 32);
            this.BurgerBtn.Name = "BurgerBtn";
            this.BurgerBtn.Size = new System.Drawing.Size(101, 64);
            this.BurgerBtn.TabIndex = 1;
            this.BurgerBtn.Text = "햄버거";
            this.BurgerBtn.UseVisualStyleBackColor = true;
            this.BurgerBtn.Click += new System.EventHandler(this.BurgerBtn_Click);
            // 
            // setmenuBtn
            // 
            this.setmenuBtn.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.setmenuBtn.Location = new System.Drawing.Point(35, 115);
            this.setmenuBtn.Name = "setmenuBtn";
            this.setmenuBtn.Size = new System.Drawing.Size(101, 64);
            this.setmenuBtn.TabIndex = 2;
            this.setmenuBtn.Text = "세트메뉴";
            this.setmenuBtn.UseVisualStyleBackColor = true;
            this.setmenuBtn.Click += new System.EventHandler(this.setmenuBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(251, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(83, 148);
            this.listBox1.TabIndex = 3;
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.orderBtn.Location = new System.Drawing.Point(142, 186);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(101, 27);
            this.orderBtn.TabIndex = 4;
            this.orderBtn.Text = "주문하기";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.deleteBtn.Location = new System.Drawing.Point(251, 186);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(83, 27);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "선택삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(157, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "주문금액";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pricelbl.Location = new System.Drawing.Point(174, 148);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(32, 20);
            this.pricelbl.TabIndex = 7;
            this.pricelbl.Text = "0원";
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 236);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.setmenuBtn);
            this.Controls.Add(this.BurgerBtn);
            this.Controls.Add(this.colaBtn);
            this.Name = "ChoiceForm";
            this.Text = "주문하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colaBtn;
        private System.Windows.Forms.Button BurgerBtn;
        private System.Windows.Forms.Button setmenuBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pricelbl;
    }
}

