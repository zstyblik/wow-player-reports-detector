namespace PlayerReportsDetector
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceToPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mounted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSwimming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsStuck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCombat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMeInInstance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(652, 575);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 53);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.PlayerLevel,
            this.Time,
            this.Faction,
            this.PlayerLocation,
            this.MyLocation,
            this.DistanceToPlayer,
            this.Mounted,
            this.IsSwimming,
            this.IsStuck,
            this.IsCombat,
            this.IsMeInInstance});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1632, 569);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Width = 105;
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.HeaderText = "Player Level";
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Width = 102;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 64;
            // 
            // Faction
            // 
            this.Faction.HeaderText = "Faction";
            this.Faction.Name = "Faction";
            this.Faction.Width = 79;
            // 
            // PlayerLocation
            // 
            this.PlayerLocation.HeaderText = "PlayerLocation";
            this.PlayerLocation.Name = "PlayerLocation";
            this.PlayerLocation.Width = 127;
            // 
            // MyLocation
            // 
            this.MyLocation.HeaderText = "My Location";
            this.MyLocation.Name = "MyLocation";
            // 
            // DistanceToPlayer
            // 
            this.DistanceToPlayer.HeaderText = "Distance To Player";
            this.DistanceToPlayer.Name = "DistanceToPlayer";
            this.DistanceToPlayer.Width = 104;
            // 
            // Mounted
            // 
            this.Mounted.HeaderText = "IsPlayerMounted";
            this.Mounted.Name = "Mounted";
            this.Mounted.Width = 138;
            // 
            // IsSwimming
            // 
            this.IsSwimming.HeaderText = "IsMeSwimming";
            this.IsSwimming.Name = "IsSwimming";
            this.IsSwimming.Width = 124;
            // 
            // IsStuck
            // 
            this.IsStuck.HeaderText = "IsMeStuck";
            this.IsStuck.Name = "IsStuck";
            this.IsStuck.Width = 97;
            // 
            // IsCombat
            // 
            this.IsCombat.HeaderText = "IsMeInCombat";
            this.IsCombat.Name = "IsCombat";
            this.IsCombat.Width = 121;
            // 
            // IsMeInInstance
            // 
            this.IsMeInInstance.HeaderText = "IsMeInInstance";
            this.IsMeInInstance.Name = "IsMeInInstance";
            this.IsMeInInstance.Width = 126;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1632, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faction;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceToPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mounted;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsSwimming;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsStuck;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCombat;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMeInInstance;

    }
}