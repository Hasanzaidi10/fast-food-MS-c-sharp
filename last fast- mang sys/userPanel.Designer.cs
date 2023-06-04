namespace last_fast__mang_sys
{
    partial class userPanel
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
            this.button3 = new System.Windows.Forms.Button();
            this.navAdmin = new System.Windows.Forms.Button();
            this.navUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.navBut = new System.Windows.Forms.Label();
            this.userItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userItems)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.navAdmin);
            this.splitContainer1.Panel1.Controls.Add(this.navUser);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::last_fast__mang_sys.Properties.Resources.hp_bg1;
            this.splitContainer1.Panel2.Controls.Add(this.userItems);
            this.splitContainer1.Panel2.Controls.Add(this.orderBtn);
            this.splitContainer1.Panel2.Controls.Add(this.navBut);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 598);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(66, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 66);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // navAdmin
            // 
            this.navAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navAdmin.Location = new System.Drawing.Point(66, 303);
            this.navAdmin.Name = "navAdmin";
            this.navAdmin.Size = new System.Drawing.Size(206, 66);
            this.navAdmin.TabIndex = 4;
            this.navAdmin.Text = "Order History";
            this.navAdmin.UseVisualStyleBackColor = true;
            this.navAdmin.Click += new System.EventHandler(this.navAdmin_Click);
            // 
            // navUser
            // 
            this.navUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navUser.Location = new System.Drawing.Point(66, 194);
            this.navUser.Name = "navUser";
            this.navUser.Size = new System.Drawing.Size(206, 66);
            this.navUser.TabIndex = 3;
            this.navUser.Text = "Order Items";
            this.navUser.UseVisualStyleBackColor = true;
            this.navUser.Click += new System.EventHandler(this.navUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "user panel";
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(281, 507);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(121, 37);
            this.orderBtn.TabIndex = 14;
            this.orderBtn.Text = "order +";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // navBut
            // 
            this.navBut.AutoSize = true;
            this.navBut.BackColor = System.Drawing.Color.Transparent;
            this.navBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navBut.Location = new System.Drawing.Point(310, 57);
            this.navBut.Name = "navBut";
            this.navBut.Size = new System.Drawing.Size(113, 37);
            this.navBut.TabIndex = 12;
            this.navBut.Text = "ITEMS";
            // 
            // userItems
            // 
            this.userItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userItems.Location = new System.Drawing.Point(18, 119);
            this.userItems.Name = "userItems";
            this.userItems.RowTemplate.Height = 28;
            this.userItems.Size = new System.Drawing.Size(645, 336);
            this.userItems.TabIndex = 15;
            // 
            // userPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 598);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userPanel";
            this.Text = "userPanel";
            this.Load += new System.EventHandler(this.userPanel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button navAdmin;
        private System.Windows.Forms.Button navUser;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label navBut;
        private System.Windows.Forms.DataGridView userItems;
    }
}