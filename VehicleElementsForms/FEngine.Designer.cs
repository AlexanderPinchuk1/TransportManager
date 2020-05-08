namespace CRUD.VehicleElementsForms
{
    partial class FEngine
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
            this.ButSave = new System.Windows.Forms.Button();
            this.ComboBFuel = new System.Windows.Forms.ComboBox();
            this.LabFuel = new System.Windows.Forms.Label();
            this.TextBVolume = new System.Windows.Forms.TextBox();
            this.LabVolume = new System.Windows.Forms.Label();
            this.TextBPower = new System.Windows.Forms.TextBox();
            this.LabPower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(134, 173);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(117, 40);
            this.ButSave.TabIndex = 13;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // ComboBFuel
            // 
            this.ComboBFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBFuel.FormattingEnabled = true;
            this.ComboBFuel.Items.AddRange(new object[] {
            "",
            "Бензин",
            "Дизель",
            "Газ"});
            this.ComboBFuel.Location = new System.Drawing.Point(191, 126);
            this.ComboBFuel.Name = "ComboBFuel";
            this.ComboBFuel.Size = new System.Drawing.Size(140, 24);
            this.ComboBFuel.TabIndex = 12;
            // 
            // LabFuel
            // 
            this.LabFuel.AutoSize = true;
            this.LabFuel.Location = new System.Drawing.Point(55, 129);
            this.LabFuel.Name = "LabFuel";
            this.LabFuel.Size = new System.Drawing.Size(64, 17);
            this.LabFuel.TabIndex = 11;
            this.LabFuel.Text = "Топливо";
            // 
            // TextBVolume
            // 
            this.TextBVolume.Location = new System.Drawing.Point(191, 76);
            this.TextBVolume.Name = "TextBVolume";
            this.TextBVolume.Size = new System.Drawing.Size(140, 22);
            this.TextBVolume.TabIndex = 10;
            this.TextBVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBVolume_KeyPress);
            // 
            // LabVolume
            // 
            this.LabVolume.AutoSize = true;
            this.LabVolume.Location = new System.Drawing.Point(55, 76);
            this.LabVolume.Name = "LabVolume";
            this.LabVolume.Size = new System.Drawing.Size(87, 17);
            this.LabVolume.TabIndex = 9;
            this.LabVolume.Text = "Объем ( л. )";
            // 
            // TextBPower
            // 
            this.TextBPower.Location = new System.Drawing.Point(191, 27);
            this.TextBPower.Name = "TextBPower";
            this.TextBPower.Size = new System.Drawing.Size(140, 22);
            this.TextBPower.TabIndex = 8;
            this.TextBPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBPower_KeyPress);
            // 
            // LabPower
            // 
            this.LabPower.AutoSize = true;
            this.LabPower.Location = new System.Drawing.Point(55, 27);
            this.LabPower.Name = "LabPower";
            this.LabPower.Size = new System.Drawing.Size(120, 17);
            this.LabPower.TabIndex = 7;
            this.LabPower.Text = "Мощность ( л.с. )";
            // 
            // FEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 238);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBFuel);
            this.Controls.Add(this.LabFuel);
            this.Controls.Add(this.TextBVolume);
            this.Controls.Add(this.LabVolume);
            this.Controls.Add(this.TextBPower);
            this.Controls.Add(this.LabPower);
            this.Name = "FEngine";
            this.Text = "Двигатель";
            this.Shown += new System.EventHandler(this.FEngine_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.ComboBox ComboBFuel;
        private System.Windows.Forms.Label LabFuel;
        private System.Windows.Forms.TextBox TextBVolume;
        private System.Windows.Forms.Label LabVolume;
        private System.Windows.Forms.TextBox TextBPower;
        private System.Windows.Forms.Label LabPower;
    }
}