namespace CRUD.VehicleForms.GrTransportForms
{
    partial class FMotorBike
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
            this.RButSideCarNo = new System.Windows.Forms.RadioButton();
            this.RButSideCarYes = new System.Windows.Forms.RadioButton();
            this.labSideCar = new System.Windows.Forms.Label();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RButSideCarNo
            // 
            this.RButSideCarNo.AutoSize = true;
            this.RButSideCarNo.Location = new System.Drawing.Point(562, 167);
            this.RButSideCarNo.Name = "RButSideCarNo";
            this.RButSideCarNo.Size = new System.Drawing.Size(54, 21);
            this.RButSideCarNo.TabIndex = 65;
            this.RButSideCarNo.TabStop = true;
            this.RButSideCarNo.Text = "Нет";
            this.RButSideCarNo.UseVisualStyleBackColor = true;
            // 
            // RButSideCarYes
            // 
            this.RButSideCarYes.AutoSize = true;
            this.RButSideCarYes.Location = new System.Drawing.Point(562, 133);
            this.RButSideCarYes.Name = "RButSideCarYes";
            this.RButSideCarYes.Size = new System.Drawing.Size(48, 21);
            this.RButSideCarYes.TabIndex = 64;
            this.RButSideCarYes.TabStop = true;
            this.RButSideCarYes.Text = "Да";
            this.RButSideCarYes.UseVisualStyleBackColor = true;
            // 
            // labSideCar
            // 
            this.labSideCar.AutoSize = true;
            this.labSideCar.Location = new System.Drawing.Point(394, 133);
            this.labSideCar.Name = "labSideCar";
            this.labSideCar.Size = new System.Drawing.Size(123, 17);
            this.labSideCar.TabIndex = 63;
            this.labSideCar.Text = "Наличие коляски";
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(305, 253);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(135, 35);
            this.ButSave.TabIndex = 62;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FMotorBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 310);
            this.Controls.Add(this.RButSideCarNo);
            this.Controls.Add(this.RButSideCarYes);
            this.Controls.Add(this.labSideCar);
            this.Controls.Add(this.ButSave);
            this.Name = "FMotorBike";
            this.Text = "Мотоцикл";
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.Controls.SetChildIndex(this.labSideCar, 0);
            this.Controls.SetChildIndex(this.RButSideCarYes, 0);
            this.Controls.SetChildIndex(this.RButSideCarNo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RButSideCarNo;
        private System.Windows.Forms.RadioButton RButSideCarYes;
        private System.Windows.Forms.Label labSideCar;
        private System.Windows.Forms.Button ButSave;
    }
}