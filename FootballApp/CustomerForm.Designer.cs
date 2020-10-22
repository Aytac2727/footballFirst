namespace FootballApp
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBall2 = new System.Windows.Forms.PictureBox();
            this.picBall1 = new System.Windows.Forms.PictureBox();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgNewCustomer = new System.Windows.Forms.DataGridView();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picBall2);
            this.panel1.Controls.Add(this.picBall1);
            this.panel1.Controls.Add(this.btnAddCus);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFirstame);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(408, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 285);
            this.panel1.TabIndex = 0;
            // 
            // picBall2
            // 
            this.picBall2.Image = ((System.Drawing.Image)(resources.GetObject("picBall2.Image")));
            this.picBall2.Location = new System.Drawing.Point(329, 213);
            this.picBall2.Name = "picBall2";
            this.picBall2.Size = new System.Drawing.Size(40, 46);
            this.picBall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBall2.TabIndex = 12;
            this.picBall2.TabStop = false;
            // 
            // picBall1
            // 
            this.picBall1.Image = ((System.Drawing.Image)(resources.GetObject("picBall1.Image")));
            this.picBall1.Location = new System.Drawing.Point(89, 213);
            this.picBall1.Name = "picBall1";
            this.picBall1.Size = new System.Drawing.Size(40, 46);
            this.picBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBall1.TabIndex = 11;
            this.picBall1.TabStop = false;
            // 
            // btnAddCus
            // 
            this.btnAddCus.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddCus.Location = new System.Drawing.Point(135, 213);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(188, 46);
            this.btnAddCus.TabIndex = 10;
            this.btnAddCus.Text = "Add";
            this.btnAddCus.UseVisualStyleBackColor = false;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(247, 154);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 26);
            this.txtAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(247, 70);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(188, 26);
            this.txtLastname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lastname";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(24, 154);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(188, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // txtFirstame
            // 
            this.txtFirstame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstame.Location = new System.Drawing.Point(24, 70);
            this.txtFirstame.Name = "txtFirstame";
            this.txtFirstame.Size = new System.Drawing.Size(188, 26);
            this.txtFirstame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // dtgNewCustomer
            // 
            this.dtgNewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNewCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgNewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dtgNewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNewCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgNewCustomer.GridColor = System.Drawing.Color.DarkGreen;
            this.dtgNewCustomer.Location = new System.Drawing.Point(0, 371);
            this.dtgNewCustomer.Name = "dtgNewCustomer";
            this.dtgNewCustomer.Size = new System.Drawing.Size(1247, 176);
            this.dtgNewCustomer.TabIndex = 1;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.DarkGreen;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(12, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(54, 35);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1247, 547);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.dtgNewCustomer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgNewCustomer;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBall2;
        private System.Windows.Forms.PictureBox picBall1;
        private System.Windows.Forms.PictureBox picExit;
    }
}