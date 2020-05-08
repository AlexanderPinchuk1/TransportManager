namespace CRUD.VehicleElementsForms
{
    partial class FTransmission
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
            this.LabType = new System.Windows.Forms.Label();
            this.ComboBTypeTransmission = new System.Windows.Forms.ComboBox();
            this.TextBNumGears = new System.Windows.Forms.TextBox();
            this.labNumGears = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(143, 160);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(111, 36);
            this.ButSave.TabIndex = 9;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // LabType
            // 
            this.LabType.AutoSize = true;
            this.LabType.Location = new System.Drawing.Point(71, 96);
            this.LabType.Name = "LabType";
            this.LabType.Size = new System.Drawing.Size(91, 17);
            this.LabType.TabIndex = 8;
            this.LabType.Text = "Тип коробки";
            // 
            // ComboBTypeTransmission
            // 
            this.ComboBTypeTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBTypeTransmission.FormattingEnabled = true;
            this.ComboBTypeTransmission.Items.AddRange(new object[] {
            "",
            "Механика",
            "Автомат",
            "Робот"});
            this.ComboBTypeTransmission.Location = new System.Drawing.Point(199, 96);
            this.ComboBTypeTransmission.Name = "ComboBTypeTransmission";
            this.ComboBTypeTransmission.Size = new System.Drawing.Size(132, 24);
            this.ComboBTypeTransmission.TabIndex = 7;
            // 
            // TextBNumGears
            // 
            this.TextBNumGears.Location = new System.Drawing.Point(200, 45);
            this.TextBNumGears.Name = "TextBNumGears";
            this.TextBNumGears.Size = new System.Drawing.Size(131, 22);
            this.TextBNumGears.TabIndex = 6;
            this.TextBNumGears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumGears_KeyPress);
            // 
            // labNumGears
            // 
            this.labNumGears.AutoSize = true;
            this.labNumGears.Location = new System.Drawing.Point(71, 45);
            this.labNumGears.Name = "labNumGears";
            this.labNumGears.Size = new System.Drawing.Size(113, 17);
            this.labNumGears.TabIndex = 5;
            this.labNumGears.Text = "Кол-во передач";
            // 
            // FTransmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 220);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.LabType);
            this.Controls.Add(this.ComboBTypeTransmission);
            this.Controls.Add(this.TextBNumGears);
            this.Controls.Add(this.labNumGears);
            this.Name = "FTransmission";
            this.Text = "Коробка передач";
            this.Shown += new System.EventHandler(this.FTransmission_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Label LabType;
        private System.Windows.Forms.ComboBox ComboBTypeTransmission;
        private System.Windows.Forms.TextBox TextBNumGears;
        private System.Windows.Forms.Label labNumGears;
    }
}