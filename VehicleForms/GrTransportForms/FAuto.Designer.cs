namespace CRUD.VehicleForms.GrTransportForms
{
    partial class FAuto
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
            this.comboBTypeBody = new System.Windows.Forms.ComboBox();
            this.comboBDriveUnit = new System.Windows.Forms.ComboBox();
            this.labDriveUnit = new System.Windows.Forms.Label();
            this.labTypeBody = new System.Windows.Forms.Label();
            this.TextBNumDoors = new System.Windows.Forms.TextBox();
            this.labNumDoors = new System.Windows.Forms.Label();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBTypeBody
            // 
            this.comboBTypeBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBTypeBody.FormattingEnabled = true;
            this.comboBTypeBody.Items.AddRange(new object[] {
            "",
            "Седан",
            "Хэтчбэк",
            "Грузовик",
            "Купе",
            "Суперкар",
            "Внедорожник",
            "Кроссовер",
            "Кабриолет",
            "Родстер",
            "Пикап",
            "Фургон"});
            this.comboBTypeBody.Location = new System.Drawing.Point(563, 165);
            this.comboBTypeBody.Name = "comboBTypeBody";
            this.comboBTypeBody.Size = new System.Drawing.Size(134, 24);
            this.comboBTypeBody.TabIndex = 49;
            // 
            // comboBDriveUnit
            // 
            this.comboBDriveUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBDriveUnit.FormattingEnabled = true;
            this.comboBDriveUnit.Items.AddRange(new object[] {
            "",
            "Передний",
            "Задний",
            "Полный"});
            this.comboBDriveUnit.Location = new System.Drawing.Point(563, 205);
            this.comboBDriveUnit.Name = "comboBDriveUnit";
            this.comboBDriveUnit.Size = new System.Drawing.Size(134, 24);
            this.comboBDriveUnit.TabIndex = 48;
            // 
            // labDriveUnit
            // 
            this.labDriveUnit.AutoSize = true;
            this.labDriveUnit.Location = new System.Drawing.Point(392, 208);
            this.labDriveUnit.Name = "labDriveUnit";
            this.labDriveUnit.Size = new System.Drawing.Size(57, 17);
            this.labDriveUnit.TabIndex = 47;
            this.labDriveUnit.Text = "Привод";
            // 
            // labTypeBody
            // 
            this.labTypeBody.AutoSize = true;
            this.labTypeBody.Location = new System.Drawing.Point(392, 167);
            this.labTypeBody.Name = "labTypeBody";
            this.labTypeBody.Size = new System.Drawing.Size(46, 17);
            this.labTypeBody.TabIndex = 46;
            this.labTypeBody.Text = "Кузов";
            // 
            // TextBNumDoors
            // 
            this.TextBNumDoors.Location = new System.Drawing.Point(563, 128);
            this.TextBNumDoors.Name = "TextBNumDoors";
            this.TextBNumDoors.Size = new System.Drawing.Size(135, 22);
            this.TextBNumDoors.TabIndex = 45;
            this.TextBNumDoors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumDoors_KeyPress);
            // 
            // labNumDoors
            // 
            this.labNumDoors.AutoSize = true;
            this.labNumDoors.Location = new System.Drawing.Point(392, 125);
            this.labNumDoors.Name = "labNumDoors";
            this.labNumDoors.Size = new System.Drawing.Size(104, 17);
            this.labNumDoors.TabIndex = 44;
            this.labNumDoors.Text = "Кол-во дверей";
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(314, 261);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(135, 35);
            this.ButSave.TabIndex = 50;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.comboBTypeBody);
            this.Controls.Add(this.comboBDriveUnit);
            this.Controls.Add(this.labDriveUnit);
            this.Controls.Add(this.labTypeBody);
            this.Controls.Add(this.TextBNumDoors);
            this.Controls.Add(this.labNumDoors);
            this.Name = "FAuto";
            this.Text = "Авто";
            this.Controls.SetChildIndex(this.labNumDoors, 0);
            this.Controls.SetChildIndex(this.TextBNumDoors, 0);
            this.Controls.SetChildIndex(this.labTypeBody, 0);
            this.Controls.SetChildIndex(this.labDriveUnit, 0);
            this.Controls.SetChildIndex(this.comboBDriveUnit, 0);
            this.Controls.SetChildIndex(this.comboBTypeBody, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBTypeBody;
        private System.Windows.Forms.ComboBox comboBDriveUnit;
        private System.Windows.Forms.Label labDriveUnit;
        private System.Windows.Forms.Label labTypeBody;
        private System.Windows.Forms.TextBox TextBNumDoors;
        private System.Windows.Forms.Label labNumDoors;
        private System.Windows.Forms.Button ButSave;
    }
}