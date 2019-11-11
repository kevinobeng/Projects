namespace GameShop
{
    partial class frmGameShop
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
            this.lblCurrentGame = new System.Windows.Forms.Label();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearchForGame = new System.Windows.Forms.TextBox();
            this.lblSearchforGame = new System.Windows.Forms.Label();
            this.btnFindGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentGame
            // 
            this.lblCurrentGame.AutoSize = true;
            this.lblCurrentGame.Location = new System.Drawing.Point(39, 185);
            this.lblCurrentGame.Name = "lblCurrentGame";
            this.lblCurrentGame.Size = new System.Drawing.Size(52, 17);
            this.lblCurrentGame.TabIndex = 0;
            this.lblCurrentGame.Text = "label1";
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(43, 205);
            this.txtGame.Multiline = true;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(727, 300);
            this.txtGame.TabIndex = 1;
            this.txtGame.TextChanged += new System.EventHandler(this.txtGame_TextChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevious.Location = new System.Drawing.Point(43, 511);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(143, 29);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(628, 511);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.White;
            this.btnAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddGame.Location = new System.Drawing.Point(235, 511);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(143, 29);
            this.btnAddGame.TabIndex = 4;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(421, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Game";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearchForGame
            // 
            this.txtSearchForGame.Location = new System.Drawing.Point(382, 165);
            this.txtSearchForGame.Name = "txtSearchForGame";
            this.txtSearchForGame.Size = new System.Drawing.Size(256, 22);
            this.txtSearchForGame.TabIndex = 7;
            // 
            // lblSearchforGame
            // 
            this.lblSearchforGame.AutoSize = true;
            this.lblSearchforGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchforGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchforGame.Location = new System.Drawing.Point(228, 165);
            this.lblSearchforGame.Name = "lblSearchforGame";
            this.lblSearchforGame.Size = new System.Drawing.Size(131, 17);
            this.lblSearchforGame.TabIndex = 8;
            this.lblSearchforGame.Text = "Search for Game";
            this.lblSearchforGame.Click += new System.EventHandler(this.lblSearchforGame_Click);
            // 
            // btnFindGame
            // 
            this.btnFindGame.BackColor = System.Drawing.Color.Lavender;
            this.btnFindGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindGame.Location = new System.Drawing.Point(657, 159);
            this.btnFindGame.Name = "btnFindGame";
            this.btnFindGame.Size = new System.Drawing.Size(111, 28);
            this.btnFindGame.TabIndex = 9;
            this.btnFindGame.Text = "Find Game";
            this.btnFindGame.UseVisualStyleBackColor = false;
            this.btnFindGame.Click += new System.EventHandler(this.btnFindGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gamers Direact ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(685, 585);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmGameShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(821, 622);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindGame);
            this.Controls.Add(this.lblSearchforGame);
            this.Controls.Add(this.txtSearchForGame);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.lblCurrentGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGameShop";
            this.Text = "Game list";
            this.Load += new System.EventHandler(this.frmGameShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentGame;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchForGame;
        private System.Windows.Forms.Label lblSearchforGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindGame;
        private System.Windows.Forms.Button btnCancel;
    }
}

