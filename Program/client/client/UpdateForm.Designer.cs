namespace client
{
    partial class UpdateForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScannerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAddFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDeleteFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tbOld = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblOld = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScannerFormToolStripMenuItem,
            this.openAddFormToolStripMenuItem,
            this.openDeleteFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openScannerFormToolStripMenuItem
            // 
            this.openScannerFormToolStripMenuItem.Name = "openScannerFormToolStripMenuItem";
            this.openScannerFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openScannerFormToolStripMenuItem.Text = "Open Scanner Form";
            this.openScannerFormToolStripMenuItem.Click += new System.EventHandler(this.openScannerFormToolStripMenuItem_Click);
            // 
            // openAddFormToolStripMenuItem
            // 
            this.openAddFormToolStripMenuItem.Name = "openAddFormToolStripMenuItem";
            this.openAddFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openAddFormToolStripMenuItem.Text = "Open Add Form";
            this.openAddFormToolStripMenuItem.Click += new System.EventHandler(this.openAddFormToolStripMenuItem_Click);
            // 
            // openDeleteFormToolStripMenuItem
            // 
            this.openDeleteFormToolStripMenuItem.Name = "openDeleteFormToolStripMenuItem";
            this.openDeleteFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openDeleteFormToolStripMenuItem.Text = "Open Delete Form";
            this.openDeleteFormToolStripMenuItem.Click += new System.EventHandler(this.openDeleteFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(476, 255);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "None";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(414, 255);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 20);
            this.label.TabIndex = 9;
            this.label.Text = "Status:";
            // 
            // tbOld
            // 
            this.tbOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOld.Location = new System.Drawing.Point(184, 142);
            this.tbOld.Name = "tbOld";
            this.tbOld.Size = new System.Drawing.Size(424, 26);
            this.tbOld.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(184, 240);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 46);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Get";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd.Location = new System.Drawing.Point(245, 86);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(291, 26);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Update a hash value here:";
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOld.Location = new System.Drawing.Point(137, 145);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(41, 20);
            this.lblOld.TabIndex = 11;
            this.lblOld.Text = "Old:";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNew.Location = new System.Drawing.Point(137, 196);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(48, 20);
            this.lblNew.TabIndex = 11;
            this.lblNew.Text = "New:";
            // 
            // tbNew
            // 
            this.tbNew.Enabled = false;
            this.tbNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNew.Location = new System.Drawing.Point(184, 193);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(424, 26);
            this.tbNew.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(296, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 46);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.tbOld);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScannerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAddFormToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbOld;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem openDeleteFormToolStripMenuItem;
    }
}