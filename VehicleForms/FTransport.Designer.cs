namespace CRUD.VehicleForms
{
    partial class FTransport
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
            this.TextBMaxSpeed = new System.Windows.Forms.TextBox();
            this.labMaxSpeed = new System.Windows.Forms.Label();
            this.TextBWeight = new System.Windows.Forms.TextBox();
            this.labWeight = new System.Windows.Forms.Label();
            this.TextBYear = new System.Windows.Forms.TextBox();
            this.labYear = new System.Windows.Forms.Label();
            this.textBModel = new System.Windows.Forms.TextBox();
            this.labModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBMaxSpeed
            // 
            this.TextBMaxSpeed.Location = new System.Drawing.Point(205, 167);
            this.TextBMaxSpeed.Name = "TextBMaxSpeed";
            this.TextBMaxSpeed.Size = new System.Drawing.Size(134, 22);
            this.TextBMaxSpeed.TabIndex = 25;
            this.TextBMaxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBMaxSpeed_KeyPress);
            // 
            // labMaxSpeed
            // 
            this.labMaxSpeed.AutoSize = true;
            this.labMaxSpeed.Location = new System.Drawing.Point(29, 172);
            this.labMaxSpeed.Name = "labMaxSpeed";
            this.labMaxSpeed.Size = new System.Drawing.Size(158, 17);
            this.labMaxSpeed.TabIndex = 24;
            this.labMaxSpeed.Text = "Макс. скорость ( км/ч )";
            // 
            // TextBWeight
            // 
            this.TextBWeight.Location = new System.Drawing.Point(205, 127);
            this.TextBWeight.Name = "TextBWeight";
            this.TextBWeight.Size = new System.Drawing.Size(134, 22);
            this.TextBWeight.TabIndex = 23;
            this.TextBWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBWeight_KeyPress);
            // 
            // labWeight
            // 
            this.labWeight.AutoSize = true;
            this.labWeight.Location = new System.Drawing.Point(29, 127);
            this.labWeight.Name = "labWeight";
            this.labWeight.Size = new System.Drawing.Size(66, 17);
            this.labWeight.TabIndex = 22;
            this.labWeight.Text = "Вес ( кг )";
            // 
            // TextBYear
            // 
            this.TextBYear.Location = new System.Drawing.Point(205, 83);
            this.TextBYear.Name = "TextBYear";
            this.TextBYear.Size = new System.Drawing.Size(134, 22);
            this.TextBYear.TabIndex = 21;
            this.TextBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBYear_KeyPress);
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(29, 85);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(90, 17);
            this.labYear.TabIndex = 20;
            this.labYear.Text = "Год выпуска";
            // 
            // textBModel
            // 
            this.textBModel.Location = new System.Drawing.Point(205, 41);
            this.textBModel.Name = "textBModel";
            this.textBModel.Size = new System.Drawing.Size(134, 22);
            this.textBModel.TabIndex = 19;
            // 
            // labModel
            // 
            this.labModel.AutoSize = true;
            this.labModel.Location = new System.Drawing.Point(29, 43);
            this.labModel.Name = "labModel";
            this.labModel.Size = new System.Drawing.Size(58, 17);
            this.labModel.TabIndex = 18;
            this.labModel.Text = "Модель";
            // 
            // FTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 377);
            this.Controls.Add(this.TextBMaxSpeed);
            this.Controls.Add(this.labMaxSpeed);
            this.Controls.Add(this.TextBWeight);
            this.Controls.Add(this.labWeight);
            this.Controls.Add(this.TextBYear);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.textBModel);
            this.Controls.Add(this.labModel);
            this.Name = "FTransport";
            this.Text = "FTransport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBMaxSpeed;
        private System.Windows.Forms.Label labMaxSpeed;
        private System.Windows.Forms.TextBox TextBWeight;
        private System.Windows.Forms.Label labWeight;
        private System.Windows.Forms.TextBox TextBYear;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.TextBox textBModel;
        private System.Windows.Forms.Label labModel;
    }
}