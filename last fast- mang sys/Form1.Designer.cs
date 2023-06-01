namespace last_fast__mang_sys
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navUser = new System.Windows.Forms.Button();
            this.navAdmin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.RegSubmit = new System.Windows.Forms.Button();
            this.navBut = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.match = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.navAdmin);
            this.splitContainer1.Panel1.Controls.Add(this.navUser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.splitContainer1.Panel2.BackgroundImage = global::last_fast__mang_sys.Properties.Resources.hp_bg1;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.match);
            this.splitContainer1.Panel2.Controls.Add(this.navBut);
            this.splitContainer1.Panel2.Controls.Add(this.RegSubmit);
            this.splitContainer1.Panel2.Controls.Add(this.EmailTxt);
            this.splitContainer1.Panel2.Controls.Add(this.confirmPass);
            this.splitContainer1.Panel2.Controls.Add(this.PasswordTxt);
            this.splitContainer1.Panel2.Controls.Add(this.fullnameTxt);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 738);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // navUser
            // 
            this.navUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navUser.Location = new System.Drawing.Point(43, 232);
            this.navUser.Name = "navUser";
            this.navUser.Size = new System.Drawing.Size(206, 66);
            this.navUser.TabIndex = 0;
            this.navUser.Text = "User";
            this.navUser.UseVisualStyleBackColor = true;
            this.navUser.Click += new System.EventHandler(this.navUser_Click);
            // 
            // navAdmin
            // 
            this.navAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navAdmin.Location = new System.Drawing.Point(43, 341);
            this.navAdmin.Name = "navAdmin";
            this.navAdmin.Size = new System.Drawing.Size(206, 66);
            this.navAdmin.TabIndex = 1;
            this.navAdmin.Text = "Admin";
            this.navAdmin.UseVisualStyleBackColor = true;
            this.navAdmin.Click += new System.EventHandler(this.navAdmin_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(43, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(74, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "FULL NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(74, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "CONFIRM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(74, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "PASSWORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(74, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "EMAIL";
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTxt.Location = new System.Drawing.Point(332, 208);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(300, 39);
            this.fullnameTxt.TabIndex = 6;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(332, 361);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(300, 39);
            this.PasswordTxt.TabIndex = 7;
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.Location = new System.Drawing.Point(332, 440);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(300, 39);
            this.confirmPass.TabIndex = 8;
            this.confirmPass.TextChanged += new System.EventHandler(this.confirmPass_TextChanged);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(332, 282);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(300, 39);
            this.EmailTxt.TabIndex = 9;
            // 
            // RegSubmit
            // 
            this.RegSubmit.Enabled = false;
            this.RegSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegSubmit.Location = new System.Drawing.Point(231, 570);
            this.RegSubmit.Name = "RegSubmit";
            this.RegSubmit.Size = new System.Drawing.Size(206, 66);
            this.RegSubmit.TabIndex = 10;
            this.RegSubmit.Text = "submit";
            this.RegSubmit.UseVisualStyleBackColor = true;
            this.RegSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // navBut
            // 
            this.navBut.AutoSize = true;
            this.navBut.BackColor = System.Drawing.Color.Transparent;
            this.navBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navBut.Location = new System.Drawing.Point(272, 86);
            this.navBut.Name = "navBut";
            this.navBut.Size = new System.Drawing.Size(104, 37);
            this.navBut.TabIndex = 11;
            this.navBut.Text = "USER";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(67, 589);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 30);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "OR LOGIN";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // match
            // 
            this.match.AutoSize = true;
            this.match.BackColor = System.Drawing.Color.Transparent;
            this.match.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match.ForeColor = System.Drawing.Color.Red;
            this.match.Location = new System.Drawing.Point(406, 492);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(44, 37);
            this.match.TabIndex = 12;
            this.match.Text = "...";
            this.match.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 738);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button navAdmin;
        private System.Windows.Forms.Button navUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label navBut;
        private System.Windows.Forms.Button RegSubmit;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox fullnameTxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label match;
    }
}

