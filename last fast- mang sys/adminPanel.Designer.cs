namespace last_fast__mang_sys
{
    partial class adminPanel
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
            this.itemsMenu = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBtn = new System.Windows.Forms.Button();
            this.navBut = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsMenu)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.navAdmin);
            this.splitContainer1.Panel1.Controls.Add(this.navUser);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.itemsMenu);
            this.splitContainer1.Panel2.Controls.Add(this.orderBtn);
            this.splitContainer1.Panel2.Controls.Add(this.navBut);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 611);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(39, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 66);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // navAdmin
            // 
            this.navAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navAdmin.Location = new System.Drawing.Point(39, 259);
            this.navAdmin.Name = "navAdmin";
            this.navAdmin.Size = new System.Drawing.Size(206, 66);
            this.navAdmin.TabIndex = 8;
            this.navAdmin.Text = "Place Order";
            this.navAdmin.UseVisualStyleBackColor = true;
            // 
            // navUser
            // 
            this.navUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navUser.Location = new System.Drawing.Point(39, 150);
            this.navUser.Name = "navUser";
            this.navUser.Size = new System.Drawing.Size(206, 66);
            this.navUser.TabIndex = 7;
            this.navUser.Text = "Items";
            this.navUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin panel";
            // 
            // itemsMenu
            // 
            this.itemsMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.category,
            this.price,
            this.Discription});
            this.itemsMenu.Location = new System.Drawing.Point(46, 101);
            this.itemsMenu.Name = "itemsMenu";
            this.itemsMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.itemsMenu.RowTemplate.Height = 28;
            this.itemsMenu.Size = new System.Drawing.Size(620, 368);
            this.itemsMenu.TabIndex = 18;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name.Width = 150;
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.Name = "category";
            this.category.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.Width = 150;
            // 
            // Discription
            // 
            this.Discription.HeaderText = "Discription";
            this.Discription.Name = "Discription";
            this.Discription.ReadOnly = true;
            this.Discription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Discription.Width = 150;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(184, 492);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(97, 39);
            this.orderBtn.TabIndex = 17;
            this.orderBtn.Text = "Add +";
            this.orderBtn.UseVisualStyleBackColor = true;
            // 
            // navBut
            // 
            this.navBut.AutoSize = true;
            this.navBut.BackColor = System.Drawing.Color.Transparent;
            this.navBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navBut.Location = new System.Drawing.Point(257, 24);
            this.navBut.Name = "navBut";
            this.navBut.Size = new System.Drawing.Size(113, 37);
            this.navBut.TabIndex = 16;
            this.navBut.Text = "ITEMS";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit +";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 492);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "Delete - ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 611);
            this.Controls.Add(this.splitContainer1);
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button navAdmin;
        private System.Windows.Forms.Button navUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView itemsMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label navBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}