namespace CRUD.VehicleForms
{
    partial class FWaterTransport
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
            this.TextBCrew = new System.Windows.Forms.TextBox();
            this.labCrew = new System.Windows.Forms.Label();
            this.TextBDisplacement = new System.Windows.Forms.TextBox();
            this.labDisplacement = new System.Windows.Forms.Label();
            this.TextBNumOfDecks = new System.Windows.Forms.TextBox();
            this.labNumOfDecks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBCrew
            // 
            this.TextBCrew.Location = new System.Drawing.Point(587, 85);
            this.TextBCrew.Name = "TextBCrew";
            this.TextBCrew.Size = new System.Drawing.Size(134, 22);
            this.TextBCrew.TabIndex = 31;
            this.TextBCrew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBCrew_KeyPress);
            // 
            // labCrew
            // 
            this.labCrew.AutoSize = true;
            this.labCrew.Location = new System.Drawing.Point(406, 88);
            this.labCrew.Name = "labCrew";
            this.labCrew.Size = new System.Drawing.Size(57, 17);
            this.labCrew.TabIndex = 30;
            this.labCrew.Text = "Экипаж";
            // 
            // TextBDisplacement
            // 
            this.TextBDisplacement.Location = new System.Drawing.Point(587, 43);
            this.TextBDisplacement.Name = "TextBDisplacement";
            this.TextBDisplacement.Size = new System.Drawing.Size(134, 22);
            this.TextBDisplacement.TabIndex = 29;
            this.TextBDisplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBDisplacement_KeyPress);
            // 
            // labDisplacement
            // 
            this.labDisplacement.AutoSize = true;
            this.labDisplacement.Location = new System.Drawing.Point(406, 46);
            this.labDisplacement.Name = "labDisplacement";
            this.labDisplacement.Size = new System.Drawing.Size(159, 17);
            this.labDisplacement.TabIndex = 28;
            this.labDisplacement.Text = "Водоизмещение  ( м3 )";
            // 
            // TextBNumOfDecks
            // 
            this.TextBNumOfDecks.Location = new System.Drawing.Point(204, 207);
            this.TextBNumOfDecks.Name = "TextBNumOfDecks";
            this.TextBNumOfDecks.Size = new System.Drawing.Size(134, 22);
            this.TextBNumOfDecks.TabIndex = 27;
            this.TextBNumOfDecks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumOfDecks_KeyPress);
            // 
            // labNumOfDecks
            // 
            this.labNumOfDecks.AutoSize = true;
            this.labNumOfDecks.Location = new System.Drawing.Point(31, 209);
            this.labNumOfDecks.Name = "labNumOfDecks";
            this.labNumOfDecks.Size = new System.Drawing.Size(96, 17);
            this.labNumOfDecks.TabIndex = 26;
            this.labNumOfDecks.Text = "Кол-во палуб";
            // 
            // FWaterTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.TextBCrew);
            this.Controls.Add(this.labCrew);
            this.Controls.Add(this.TextBDisplacement);
            this.Controls.Add(this.labDisplacement);
            this.Controls.Add(this.TextBNumOfDecks);
            this.Controls.Add(this.labNumOfDecks);
            this.Name = "FWaterTransport";
            this.Text = "FWaterTransport";
            this.Controls.SetChildIndex(this.labNumOfDecks, 0);
            this.Controls.SetChildIndex(this.TextBNumOfDecks, 0);
            this.Controls.SetChildIndex(this.labDisplacement, 0);
            this.Controls.SetChildIndex(this.TextBDisplacement, 0);
            this.Controls.SetChildIndex(this.labCrew, 0);
            this.Controls.SetChildIndex(this.TextBCrew, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBCrew;
        private System.Windows.Forms.Label labCrew;
        private System.Windows.Forms.TextBox TextBDisplacement;
        private System.Windows.Forms.Label labDisplacement;
        private System.Windows.Forms.TextBox TextBNumOfDecks;
        private System.Windows.Forms.Label labNumOfDecks;
    }
}