namespace ManksEncrypter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPanelPassword = new System.Windows.Forms.Button();
            this.btnPanelEncrypter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPanelWebsite = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRandomPassword = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblRemove = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btnPanelPassword);
            this.panel1.Controls.Add(this.btnPanelEncrypter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 545);
            this.panel1.TabIndex = 9;
            // 
            // btnPanelPassword
            // 
            this.btnPanelPassword.FlatAppearance.BorderSize = 0;
            this.btnPanelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelPassword.ForeColor = System.Drawing.Color.White;
            this.btnPanelPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelPassword.Image")));
            this.btnPanelPassword.Location = new System.Drawing.Point(0, 174);
            this.btnPanelPassword.Name = "btnPanelPassword";
            this.btnPanelPassword.Size = new System.Drawing.Size(181, 76);
            this.btnPanelPassword.TabIndex = 12;
            this.btnPanelPassword.Text = "Passwords";
            this.btnPanelPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPanelPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPanelPassword.UseVisualStyleBackColor = true;
            this.btnPanelPassword.Click += new System.EventHandler(this.btnPanelPassword_Click);
            // 
            // btnPanelEncrypter
            // 
            this.btnPanelEncrypter.FlatAppearance.BorderSize = 0;
            this.btnPanelEncrypter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelEncrypter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelEncrypter.ForeColor = System.Drawing.Color.White;
            this.btnPanelEncrypter.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelEncrypter.Image")));
            this.btnPanelEncrypter.Location = new System.Drawing.Point(0, 88);
            this.btnPanelEncrypter.Name = "btnPanelEncrypter";
            this.btnPanelEncrypter.Size = new System.Drawing.Size(181, 79);
            this.btnPanelEncrypter.TabIndex = 11;
            this.btnPanelEncrypter.Text = "Encrypter";
            this.btnPanelEncrypter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPanelEncrypter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPanelEncrypter.UseVisualStyleBackColor = true;
            this.btnPanelEncrypter.Click += new System.EventHandler(this.btnPanelEncrypter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnPanelWebsite);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 86);
            this.panel2.TabIndex = 10;
            // 
            // btnPanelWebsite
            // 
            this.btnPanelWebsite.FlatAppearance.BorderSize = 0;
            this.btnPanelWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelWebsite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelWebsite.ForeColor = System.Drawing.Color.White;
            this.btnPanelWebsite.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelWebsite.Image")));
            this.btnPanelWebsite.Location = new System.Drawing.Point(3, 3);
            this.btnPanelWebsite.Name = "btnPanelWebsite";
            this.btnPanelWebsite.Size = new System.Drawing.Size(178, 83);
            this.btnPanelWebsite.TabIndex = 13;
            this.btnPanelWebsite.Text = "Mank.Club";
            this.btnPanelWebsite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPanelWebsite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPanelWebsite.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(263, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 309);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.dataGridView1.Location = new System.Drawing.Point(4, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(10)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(703, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(204, 45);
            this.txtWebsite.Multiline = true;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(157, 32);
            this.txtWebsite.TabIndex = 11;
            // 
            // lblWebsite
            // 
            this.lblWebsite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsite.ForeColor = System.Drawing.Color.White;
            this.lblWebsite.Image = ((System.Drawing.Image)(resources.GetObject("lblWebsite.Image")));
            this.lblWebsite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWebsite.Location = new System.Drawing.Point(200, 10);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(153, 32);
            this.lblWebsite.TabIndex = 12;
            this.lblWebsite.Text = "Website";
            this.lblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Image = ((System.Drawing.Image)(resources.GetObject("lblUserName.Image")));
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Location = new System.Drawing.Point(392, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(153, 32);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(379, 45);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(166, 32);
            this.txtUserName.TabIndex = 14;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Image = ((System.Drawing.Image)(resources.GetObject("lblPassword.Image")));
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.Location = new System.Drawing.Point(551, 10);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(153, 32);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(555, 45);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 32);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(483, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRandomPassword
            // 
            this.btnRandomPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnRandomPassword.FlatAppearance.BorderSize = 0;
            this.btnRandomPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnRandomPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnRandomPassword.Image")));
            this.btnRandomPassword.Location = new System.Drawing.Point(850, 45);
            this.btnRandomPassword.Name = "btnRandomPassword";
            this.btnRandomPassword.Size = new System.Drawing.Size(35, 32);
            this.btnRandomPassword.TabIndex = 18;
            this.btnRandomPassword.UseVisualStyleBackColor = false;
            this.btnRandomPassword.Click += new System.EventHandler(this.btnRandomPassword_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.ForeColor = System.Drawing.Color.White;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPass.Location = new System.Drawing.Point(267, 174);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(120, 36);
            this.btnShowPass.TabIndex = 19;
            this.btnShowPass.Text = "Show";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePass.ForeColor = System.Drawing.Color.White;
            this.btnHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass.Image")));
            this.btnHidePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHidePass.Location = new System.Drawing.Point(267, 174);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(120, 36);
            this.btnHidePass.TabIndex = 20;
            this.btnHidePass.Text = "Hide";
            this.btnHidePass.UseVisualStyleBackColor = true;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(739, 179);
            this.txtRemove.Multiline = true;
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(138, 32);
            this.txtRemove.TabIndex = 21;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(883, 179);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 32);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.ForeColor = System.Drawing.Color.White;
            this.lblRemove.Location = new System.Drawing.Point(583, 179);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(150, 32);
            this.lblRemove.TabIndex = 23;
            this.lblRemove.Text = "Enter Website To Remove";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1090, 545);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.btnHidePass);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnRandomPassword);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Name = "Form1";
            this.Text = "Mank\'s Security";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPanelPassword;
        private System.Windows.Forms.Button btnPanelEncrypter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPanelWebsite;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRandomPassword;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnHidePass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblRemove;
    }
}

