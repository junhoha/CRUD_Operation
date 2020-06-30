namespace CRUD_Operation
{
    partial class Form1
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
            this.StudentGridview = new System.Windows.Forms.DataGridView();
            this.In = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRollnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGridview
            // 
            this.StudentGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridview.Location = new System.Drawing.Point(13, 306);
            this.StudentGridview.Name = "StudentGridview";
            this.StudentGridview.RowTemplate.Height = 23;
            this.StudentGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGridview.Size = new System.Drawing.Size(617, 163);
            this.StudentGridview.TabIndex = 1;
            this.StudentGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridview_CellClick);
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(13, 251);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(111, 49);
            this.In.TabIndex = 0;
            this.In.Text = "Insert";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 49);
            this.button4.TabIndex = 0;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(519, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 49);
            this.button5.TabIndex = 0;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "S.name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(107, 37);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(184, 21);
            this.txtStudentName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "F.name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(446, 40);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(184, 21);
            this.txtFatherName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Roll No.";
            // 
            // txtRollnumber
            // 
            this.txtRollnumber.Location = new System.Drawing.Point(107, 97);
            this.txtRollnumber.Name = "txtRollnumber";
            this.txtRollnumber.Size = new System.Drawing.Size(184, 21);
            this.txtRollnumber.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mobile";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(446, 97);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(184, 21);
            this.txtMobile.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(107, 165);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(184, 21);
            this.txtAddress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 481);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRollnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentGridview);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.In);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView StudentGridview;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRollnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
    }
}

