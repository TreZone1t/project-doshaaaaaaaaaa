namespace project
{
    partial class Form5
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelID = new System.Windows.Forms.Label();
            this.txtid3 = new System.Windows.Forms.TextBox();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.labelID);
            this.flowLayoutPanel1.Controls.Add(this.txtid3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(263, 153);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 59);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Black;
            this.labelID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelID.Location = new System.Drawing.Point(3, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(83, 23);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Enter ID";
            // 
            // txtid3
            // 
            this.txtid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtid3.Location = new System.Drawing.Point(3, 26);
            this.txtid3.Name = "txtid3";
            this.txtid3.Size = new System.Drawing.Size(395, 25);
            this.txtid3.TabIndex = 1;
            this.txtid3.TextChanged += new System.EventHandler(this.textBoxEnterID_TextChanged);
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.BackColor = System.Drawing.Color.Red;
            this.buttonDelete2.FlatAppearance.BorderSize = 0;
            this.buttonDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonDelete2.ForeColor = System.Drawing.Color.White;
            this.buttonDelete2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDelete2.Location = new System.Drawing.Point(263, 247);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(399, 56);
            this.buttonDelete2.TabIndex = 16;
            this.buttonDelete2.Text = "Delete";
            this.buttonDelete2.UseVisualStyleBackColor = false;
            this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBack.Location = new System.Drawing.Point(263, 322);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(399, 56);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 617);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtid3;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.Button buttonBack;
    }
}