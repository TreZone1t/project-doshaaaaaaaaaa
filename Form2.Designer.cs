namespace project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonDeleteMobile = new System.Windows.Forms.Button();
            this.buttonSearchMobile = new System.Windows.Forms.Button();
            this.buttonAddMobile = new System.Windows.Forms.Button();
            this.buttonViewMobiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteMobile
            // 
            this.buttonDeleteMobile.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteMobile.FlatAppearance.BorderSize = 0;
            this.buttonDeleteMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMobile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonDeleteMobile.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteMobile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteMobile.Location = new System.Drawing.Point(46, 447);
            this.buttonDeleteMobile.Name = "buttonDeleteMobile";
            this.buttonDeleteMobile.Size = new System.Drawing.Size(374, 80);
            this.buttonDeleteMobile.TabIndex = 17;
            this.buttonDeleteMobile.Text = "Delete Mobile";
            this.buttonDeleteMobile.UseVisualStyleBackColor = false;
            this.buttonDeleteMobile.Click += new System.EventHandler(this.buttonDeleteMobile_Click);
            // 
            // buttonSearchMobile
            // 
            this.buttonSearchMobile.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearchMobile.FlatAppearance.BorderSize = 0;
            this.buttonSearchMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMobile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonSearchMobile.ForeColor = System.Drawing.Color.White;
            this.buttonSearchMobile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearchMobile.Location = new System.Drawing.Point(46, 214);
            this.buttonSearchMobile.Name = "buttonSearchMobile";
            this.buttonSearchMobile.Size = new System.Drawing.Size(374, 80);
            this.buttonSearchMobile.TabIndex = 18;
            this.buttonSearchMobile.Text = "Search Mobile";
            this.buttonSearchMobile.UseVisualStyleBackColor = false;
            this.buttonSearchMobile.Click += new System.EventHandler(this.buttonSearchMobile_Click);
            // 
            // buttonAddMobile
            // 
            this.buttonAddMobile.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddMobile.FlatAppearance.BorderSize = 0;
            this.buttonAddMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMobile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonAddMobile.ForeColor = System.Drawing.Color.White;
            this.buttonAddMobile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddMobile.Location = new System.Drawing.Point(46, 105);
            this.buttonAddMobile.Name = "buttonAddMobile";
            this.buttonAddMobile.Size = new System.Drawing.Size(374, 80);
            this.buttonAddMobile.TabIndex = 19;
            this.buttonAddMobile.Text = "Add Mobile";
            this.buttonAddMobile.UseVisualStyleBackColor = false;
            this.buttonAddMobile.Click += new System.EventHandler(this.buttonAddMobile_Click);
            // 
            // buttonViewMobiles
            // 
            this.buttonViewMobiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonViewMobiles.FlatAppearance.BorderSize = 0;
            this.buttonViewMobiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewMobiles.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonViewMobiles.ForeColor = System.Drawing.Color.White;
            this.buttonViewMobiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonViewMobiles.Location = new System.Drawing.Point(46, 331);
            this.buttonViewMobiles.Name = "buttonViewMobiles";
            this.buttonViewMobiles.Size = new System.Drawing.Size(374, 80);
            this.buttonViewMobiles.TabIndex = 20;
            this.buttonViewMobiles.Text = "View Mobiles";
            this.buttonViewMobiles.UseVisualStyleBackColor = false;
            this.buttonViewMobiles.Click += new System.EventHandler(this.buttonViewMobiles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 617);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 617);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonViewMobiles);
            this.Controls.Add(this.buttonAddMobile);
            this.Controls.Add(this.buttonSearchMobile);
            this.Controls.Add(this.buttonDeleteMobile);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteMobile;
        private System.Windows.Forms.Button buttonSearchMobile;
        private System.Windows.Forms.Button buttonAddMobile;
        private System.Windows.Forms.Button buttonViewMobiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}