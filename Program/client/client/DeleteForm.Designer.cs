namespace client
{
    partial class DeleteForm
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAddFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openUpdateFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScannerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
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
            this.openUpdateFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openAddFormToolStripMenuItem
            // 
            this.openAddFormToolStripMenuItem.Name = "openAddFormToolStripMenuItem";
            this.openAddFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openAddFormToolStripMenuItem.Text = "Open Add Form";
            this.openAddFormToolStripMenuItem.Click += new System.EventHandler(this.openAddFormToolStripMenuItem_Click);
            // 
            // openUpdateFormToolStripMenuItem
            // 
            this.openUpdateFormToolStripMenuItem.Name = "openUpdateFormToolStripMenuItem";
            this.openUpdateFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openUpdateFormToolStripMenuItem.Text = "Open Update Form";
            this.openUpdateFormToolStripMenuItem.Click += new System.EventHandler(this.openUpdateFormToolStripMenuItem_Click);
            // 
            // openScannerFormToolStripMenuItem
            // 
            this.openScannerFormToolStripMenuItem.Name = "openScannerFormToolStripMenuItem";
            this.openScannerFormToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.openScannerFormToolStripMenuItem.Text = "Open Scanner Form";
            this.openScannerFormToolStripMenuItem.Click += new System.EventHandler(this.openScannerFormToolStripMenuItem_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValue.Location = new System.Drawing.Point(120, 149);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(60, 20);
            this.lblValue.TabIndex = 20;
            this.lblValue.Text = "Value:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(460, 216);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "None";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(398, 216);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 20);
            this.label.TabIndex = 17;
            this.label.Text = "Status:";
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbValue.Location = new System.Drawing.Point(180, 146);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(424, 26);
            this.tbValue.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(280, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd.Location = new System.Drawing.Point(241, 90);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(284, 26);
            this.lblAdd.TabIndex = 12;
            this.lblAdd.Text = "Delete a hash value here:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheck.Location = new System.Drawing.Point(180, 201);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 46);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAddFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openUpdateFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScannerFormToolStripMenuItem;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnCheck;
    }
}