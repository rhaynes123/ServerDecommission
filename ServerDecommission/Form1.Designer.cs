namespace ServerDecommission
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameEntered = new System.Windows.Forms.TextBox();
            this.incidentNumberEntered = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.make_server_backup = new System.Windows.Forms.Button();
            this.stopScheduledTasks = new System.Windows.Forms.Button();
            this.ScanForServerIP = new System.Windows.Forms.Button();
            this.final_restart_server = new System.Windows.Forms.Button();
            this.renamebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Decommission Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name";
            // 
            // nameEntered
            // 
            this.nameEntered.AccessibleName = "nameEntered";
            this.nameEntered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameEntered.Location = new System.Drawing.Point(116, 84);
            this.nameEntered.Name = "nameEntered";
            this.nameEntered.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nameEntered.Size = new System.Drawing.Size(100, 22);
            this.nameEntered.TabIndex = 5;
            this.nameEntered.TextChanged += new System.EventHandler(this.nameEntered_TextChanged);
            // 
            // incidentNumberEntered
            // 
            this.incidentNumberEntered.AccessibleName = "incidentEntered";
            this.incidentNumberEntered.Location = new System.Drawing.Point(464, 84);
            this.incidentNumberEntered.Name = "incidentNumberEntered";
            this.incidentNumberEntered.Size = new System.Drawing.Size(100, 22);
            this.incidentNumberEntered.TabIndex = 6;
            this.incidentNumberEntered.TextChanged += new System.EventHandler(this.incidentNumberEntered_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Incident Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Open Services";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // make_server_backup
            // 
            this.make_server_backup.AccessibleName = "backupbutton";
            this.make_server_backup.Location = new System.Drawing.Point(179, 143);
            this.make_server_backup.Name = "make_server_backup";
            this.make_server_backup.Size = new System.Drawing.Size(200, 23);
            this.make_server_backup.TabIndex = 10;
            this.make_server_backup.Text = "Backup Server";
            this.make_server_backup.UseVisualStyleBackColor = true;
            this.make_server_backup.Click += new System.EventHandler(this.make_server_backup_Click);
            // 
            // stopScheduledTasks
            // 
            this.stopScheduledTasks.Location = new System.Drawing.Point(179, 252);
            this.stopScheduledTasks.Name = "stopScheduledTasks";
            this.stopScheduledTasks.Size = new System.Drawing.Size(200, 23);
            this.stopScheduledTasks.TabIndex = 12;
            this.stopScheduledTasks.Text = "Open Scheuled Tasks";
            this.stopScheduledTasks.UseVisualStyleBackColor = true;
            this.stopScheduledTasks.Click += new System.EventHandler(this.stopScheduledTasks_Click);
            // 
            // ScanForServerIP
            // 
            this.ScanForServerIP.Location = new System.Drawing.Point(179, 301);
            this.ScanForServerIP.Name = "ScanForServerIP";
            this.ScanForServerIP.Size = new System.Drawing.Size(200, 23);
            this.ScanForServerIP.TabIndex = 14;
            this.ScanForServerIP.Text = "Scan For Server IP";
            this.ScanForServerIP.UseVisualStyleBackColor = true;
            this.ScanForServerIP.Click += new System.EventHandler(this.ScanForServerIPClick);
            // 
            // final_restart_server
            // 
            this.final_restart_server.Location = new System.Drawing.Point(195, 389);
            this.final_restart_server.Name = "final_restart_server";
            this.final_restart_server.Size = new System.Drawing.Size(165, 23);
            this.final_restart_server.TabIndex = 16;
            this.final_restart_server.Text = "Restart Server";
            this.final_restart_server.UseVisualStyleBackColor = true;
            this.final_restart_server.Click += new System.EventHandler(this.final_restart_server_Click);
            // 
            // renamebutton
            // 
            this.renamebutton.Location = new System.Drawing.Point(179, 346);
            this.renamebutton.Name = "renamebutton";
            this.renamebutton.Size = new System.Drawing.Size(200, 23);
            this.renamebutton.TabIndex = 17;
            this.renamebutton.Text = "Rename Server";
            this.renamebutton.UseVisualStyleBackColor = true;
            this.renamebutton.Click += new System.EventHandler(this.renamebutton_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(576, 531);
            this.Controls.Add(this.renamebutton);
            this.Controls.Add(this.final_restart_server);
            this.Controls.Add(this.ScanForServerIP);
            this.Controls.Add(this.stopScheduledTasks);
            this.Controls.Add(this.make_server_backup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.incidentNumberEntered);
            this.Controls.Add(this.nameEntered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameEntered;
        private System.Windows.Forms.TextBox incidentNumberEntered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button make_server_backup;
        private System.Windows.Forms.Button stopScheduledTasks;
        private System.Windows.Forms.Button ScanForServerIP;
        private System.Windows.Forms.Button final_restart_server;
        private System.Windows.Forms.Button renamebutton;
    }
}

