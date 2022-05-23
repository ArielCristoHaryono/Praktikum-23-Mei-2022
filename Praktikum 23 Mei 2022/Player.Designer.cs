namespace Praktikum_23_Mei_2022
{
    partial class Player
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
            this.buttonPertama = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonTerakhir = new System.Windows.Forms.Button();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBoxPlayerID = new System.Windows.Forms.TextBox();
            this.tBoxPlayerName = new System.Windows.Forms.TextBox();
            this.dTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxNationality = new System.Windows.Forms.ComboBox();
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            this.lblCekAvailable = new System.Windows.Forms.Label();
            this.listBoxTeamNumber = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonPertama
            // 
            this.buttonPertama.Location = new System.Drawing.Point(46, 43);
            this.buttonPertama.Name = "buttonPertama";
            this.buttonPertama.Size = new System.Drawing.Size(75, 52);
            this.buttonPertama.TabIndex = 0;
            this.buttonPertama.Text = "<<";
            this.buttonPertama.UseVisualStyleBackColor = true;
            this.buttonPertama.Click += new System.EventHandler(this.buttonPertama_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(154, 43);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 52);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(261, 43);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 52);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonTerakhir
            // 
            this.buttonTerakhir.Location = new System.Drawing.Point(368, 43);
            this.buttonTerakhir.Name = "buttonTerakhir";
            this.buttonTerakhir.Size = new System.Drawing.Size(75, 52);
            this.buttonTerakhir.TabIndex = 3;
            this.buttonTerakhir.Text = ">>";
            this.buttonTerakhir.UseVisualStyleBackColor = true;
            this.buttonTerakhir.Click += new System.EventHandler(this.buttonTerakhir_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(46, 112);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(73, 20);
            this.lblPlayerID.TabIndex = 4;
            this.lblPlayerID.Text = "Player ID";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(46, 153);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(98, 20);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(46, 189);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(77, 20);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "BirthDate";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(46, 225);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(82, 20);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationality";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(46, 259);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(49, 20);
            this.lblTeam.TabIndex = 8;
            this.lblTeam.Text = "Team";
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Location = new System.Drawing.Point(46, 292);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(109, 20);
            this.lblTeamNumber.TabIndex = 9;
            this.lblTeamNumber.Text = "Team Number";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tBoxPlayerID
            // 
            this.tBoxPlayerID.Location = new System.Drawing.Point(188, 109);
            this.tBoxPlayerID.Name = "tBoxPlayerID";
            this.tBoxPlayerID.Size = new System.Drawing.Size(122, 26);
            this.tBoxPlayerID.TabIndex = 13;
            // 
            // tBoxPlayerName
            // 
            this.tBoxPlayerName.Location = new System.Drawing.Point(188, 150);
            this.tBoxPlayerName.Name = "tBoxPlayerName";
            this.tBoxPlayerName.Size = new System.Drawing.Size(262, 26);
            this.tBoxPlayerName.TabIndex = 14;
            // 
            // dTPBirthDate
            // 
            this.dTPBirthDate.CustomFormat = "dddd,MMMM,dd yyyy";
            this.dTPBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPBirthDate.Location = new System.Drawing.Point(188, 182);
            this.dTPBirthDate.Name = "dTPBirthDate";
            this.dTPBirthDate.Size = new System.Drawing.Size(262, 26);
            this.dTPBirthDate.TabIndex = 19;
            this.dTPBirthDate.ValueChanged += new System.EventHandler(this.dTPBirthDate_ValueChanged);
            // 
            // cBoxNationality
            // 
            this.cBoxNationality.FormattingEnabled = true;
            this.cBoxNationality.Location = new System.Drawing.Point(188, 216);
            this.cBoxNationality.Name = "cBoxNationality";
            this.cBoxNationality.Size = new System.Drawing.Size(262, 28);
            this.cBoxNationality.TabIndex = 20;
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Location = new System.Drawing.Point(188, 251);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(262, 28);
            this.cBoxTeam.TabIndex = 21;
            // 
            // lblCekAvailable
            // 
            this.lblCekAvailable.AutoSize = true;
            this.lblCekAvailable.Location = new System.Drawing.Point(392, 292);
            this.lblCekAvailable.Name = "lblCekAvailable";
            this.lblCekAvailable.Size = new System.Drawing.Size(21, 20);
            this.lblCekAvailable.TabIndex = 22;
            this.lblCekAvailable.Text = "...";
            // 
            // listBoxTeamNumber
            // 
            this.listBoxTeamNumber.FormattingEnabled = true;
            this.listBoxTeamNumber.ItemHeight = 20;
            this.listBoxTeamNumber.Location = new System.Drawing.Point(188, 288);
            this.listBoxTeamNumber.Name = "listBoxTeamNumber";
            this.listBoxTeamNumber.Size = new System.Drawing.Size(120, 24);
            this.listBoxTeamNumber.TabIndex = 23;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.listBoxTeamNumber);
            this.Controls.Add(this.lblCekAvailable);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.cBoxNationality);
            this.Controls.Add(this.dTPBirthDate);
            this.Controls.Add(this.tBoxPlayerName);
            this.Controls.Add(this.tBoxPlayerID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTeamNumber);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.buttonTerakhir);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonPertama);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPertama;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonTerakhir;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tBoxPlayerID;
        private System.Windows.Forms.TextBox tBoxPlayerName;
        private System.Windows.Forms.DateTimePicker dTPBirthDate;
        private System.Windows.Forms.ComboBox cBoxNationality;
        private System.Windows.Forms.ComboBox cBoxTeam;
        private System.Windows.Forms.Label lblCekAvailable;
        private System.Windows.Forms.ListBox listBoxTeamNumber;
    }
}

