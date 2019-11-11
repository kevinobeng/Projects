namespace GameShop
{
    partial class frmAddGame
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.lblConsole = new System.Windows.Forms.Label();
            this.lblGameDeveloper = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.txtGameDeveloper = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxConsole = new System.Windows.Forms.ComboBox();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(75, 69);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(87, 17);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Game Title";
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsole.Location = new System.Drawing.Point(92, 31);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(66, 17);
            this.lblConsole.TabIndex = 1;
            this.lblConsole.Text = "Console";
            // 
            // lblGameDeveloper
            // 
            this.lblGameDeveloper.AutoSize = true;
            this.lblGameDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDeveloper.Location = new System.Drawing.Point(36, 105);
            this.lblGameDeveloper.Name = "lblGameDeveloper";
            this.lblGameDeveloper.Size = new System.Drawing.Size(129, 17);
            this.lblGameDeveloper.TabIndex = 2;
            this.lblGameDeveloper.Text = "Game Developer";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(84, 180);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(76, 17);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "Condition";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(57, 142);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(106, 17);
            this.lblReleaseDate.TabIndex = 4;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentValue.Location = new System.Drawing.Point(56, 217);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(108, 17);
            this.lblCurrentValue.TabIndex = 5;
            this.lblCurrentValue.Text = "Current Value";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(169, 67);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(270, 22);
            this.txtGameTitle.TabIndex = 6;
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Location = new System.Drawing.Point(169, 217);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(270, 22);
            this.txtCurrentValue.TabIndex = 10;
            // 
            // txtGameDeveloper
            // 
            this.txtGameDeveloper.Location = new System.Drawing.Point(169, 105);
            this.txtGameDeveloper.Name = "txtGameDeveloper";
            this.txtGameDeveloper.Size = new System.Drawing.Size(270, 22);
            this.txtGameDeveloper.TabIndex = 14;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.MintCream;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(169, 262);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 29);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MintCream;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(312, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 29);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBoxConsole
            // 
            this.comboBoxConsole.FormattingEnabled = true;
            this.comboBoxConsole.Location = new System.Drawing.Point(169, 27);
            this.comboBoxConsole.Name = "comboBoxConsole";
            this.comboBoxConsole.Size = new System.Drawing.Size(270, 24);
            this.comboBoxConsole.TabIndex = 17;
            this.comboBoxConsole.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsole_SelectedIndexChanged);
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Location = new System.Drawing.Point(169, 180);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(270, 24);
            this.comboBoxCondition.TabIndex = 18;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(170, 145);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker.TabIndex = 19;
            // 
            // frmAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(559, 357);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.comboBoxConsole);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtGameDeveloper);
            this.Controls.Add(this.txtCurrentValue);
            this.Controls.Add(this.txtGameTitle);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblGameDeveloper);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "frmAddGame";
            this.Text = "Add Game";
            this.Load += new System.EventHandler(this.frmAddGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Label lblGameDeveloper;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.TextBox txtGameDeveloper;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxConsole;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}