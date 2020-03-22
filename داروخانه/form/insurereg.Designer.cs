namespace داروخانه
{
    partial class insurereg
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label40 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.namesazman = new System.Windows.Forms.TextBox();
            this.darsadepardakhti = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 28);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "خصوصی";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 28);
            this.radioButton1.TabIndex = 40;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "دولتی";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(101, 48);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(54, 24);
            this.label40.TabIndex = 39;
            this.label40.Text = "نوع بیمه";
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 133);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(122, 38);
            this.button16.TabIndex = 38;
            this.button16.Text = "بازگشت";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(134, 133);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(122, 38);
            this.button15.TabIndex = 37;
            this.button15.Text = "ثبت";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // namesazman
            // 
            this.namesazman.Location = new System.Drawing.Point(177, 28);
            this.namesazman.Multiline = true;
            this.namesazman.Name = "namesazman";
            this.namesazman.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.namesazman.Size = new System.Drawing.Size(213, 25);
            this.namesazman.TabIndex = 36;
            // 
            // darsadepardakhti
            // 
            this.darsadepardakhti.Location = new System.Drawing.Point(177, 79);
            this.darsadepardakhti.Multiline = true;
            this.darsadepardakhti.Name = "darsadepardakhti";
            this.darsadepardakhti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.darsadepardakhti.Size = new System.Drawing.Size(213, 25);
            this.darsadepardakhti.TabIndex = 35;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(433, 79);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(49, 24);
            this.label99.TabIndex = 34;
            this.label99.Text = "تعهدات";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(396, 31);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(86, 24);
            this.label93.TabIndex = 33;
            this.label93.Text = "نام شرکت بیمه";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.namesazman);
            this.groupBox1.Controls.Add(this.darsadepardakhti);
            this.groupBox1.Controls.Add(this.label99);
            this.groupBox1.Controls.Add(this.label93);
            this.groupBox1.Font = new System.Drawing.Font("2  Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 177);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // insurereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 201);
            this.Controls.Add(this.groupBox1);
            this.Name = "insurereg";
            this.Text = "ثبت شرکت بیمه";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox namesazman;
        private System.Windows.Forms.TextBox darsadepardakhti;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}