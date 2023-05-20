namespace client
{
    partial class AddForm
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
            this.openUpdateFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbHashValue = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.openDeleteFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.openUpdateFormToolStripMenuItem,
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
            // openUpdateFormToolStripMenuItem
            // 
            this.openUpdateFormToolStripMenuItem.Name = "openUpdateFormToolStripMenuItem";
            this.openUpdateFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openUpdateFormToolStripMenuItem.Text = "Open Update Form";
            this.openUpdateFormToolStripMenuItem.Click += new System.EventHandler(this.openUpdateFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd.Location = new System.Drawing.Point(225, 80);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(307, 26);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "Add a new hash value here:";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(170, 188);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 46);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbHashValue
            // 
            this.tbHashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHashValue.Location = new System.Drawing.Point(170, 134);
            this.tbHashValue.Name = "tbHashValue";
            this.tbHashValue.Size = new System.Drawing.Size(424, 26);
            this.tbHashValue.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(289, 203);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 20);
            this.label.TabIndex = 4;
            this.label.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(354, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "None";
            // 
            // openDeleteFormToolStripMenuItem
            // 
            this.openDeleteFormToolStripMenuItem.Name = "openDeleteFormToolStripMenuItem";
            this.openDeleteFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openDeleteFormToolStripMenuItem.Text = "Open Delete Form";
            this.openDeleteFormToolStripMenuItem.Click += new System.EventHandler(this.openDeleteFormToolStripMenuItem_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbHashValue);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddForm";
            this.Text = "Add Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScannerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbHashValue;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem openUpdateFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDeleteFormToolStripMenuItem;
    }
}