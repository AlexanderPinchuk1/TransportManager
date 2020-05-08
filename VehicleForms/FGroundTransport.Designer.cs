namespace CRUD.VehicleForms
{
    partial class FGroundTransport
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
            this.ButViewEngine = new System.Windows.Forms.Button();
            this.labEngine = new System.Windows.Forms.Label();
            this.ButViewTransmisson = new System.Windows.Forms.Button();
            this.labEdTransmission = new System.Windows.Forms.Label();
            this.TextBNumWheels = new System.Windows.Forms.TextBox();
            this.labNumWheels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButViewEngine
            // 
            this.ButViewEngine.Location = new System.Drawing.Point(562, 79);
            this.ButViewEngine.Name = "ButViewEngine";
            this.ButViewEngine.Size = new System.Drawing.Size(135, 31);
            this.ButViewEngine.TabIndex = 43;
            this.ButViewEngine.Text = "Просмотр";
            this.ButViewEngine.UseVisualStyleBackColor = true;
            this.ButViewEngine.Click += new System.EventHandler(this.ButViewEngine_Click);
            // 
            // labEngine
            // 
            this.labEngine.AutoSize = true;
            this.labEngine.Location = new System.Drawing.Point(394, 83);
            this.labEngine.Name = "labEngine";
            this.labEngine.Size = new System.Drawing.Size(77, 17);
            this.labEngine.TabIndex = 42;
            this.labEngine.Text = "Двигатель";
            // 
            // ButViewTransmisson
            // 
            this.ButViewTransmisson.Location = new System.Drawing.Point(562, 33);
            this.ButViewTransmisson.Name = "ButViewTransmisson";
            this.ButViewTransmisson.Size = new System.Drawing.Size(134, 31);
            this.ButViewTransmisson.TabIndex = 41;
            this.ButViewTransmisson.Text = "Просмотр";
            this.ButViewTransmisson.UseVisualStyleBackColor = true;
            this.ButViewTransmisson.Click += new System.EventHandler(this.ButViewTransmisson_Click);
            // 
            // labEdTransmission
            // 
            this.labEdTransmission.AutoSize = true;
            this.labEdTransmission.Location = new System.Drawing.Point(393, 42);
            this.labEdTransmission.Name = "labEdTransmission";
            this.labEdTransmission.Size = new System.Drawing.Size(124, 17);
            this.labEdTransmission.TabIndex = 40;
            this.labEdTransmission.Text = "Коробка передач";
            // 
            // TextBNumWheels
            // 
            this.TextBNumWheels.Location = new System.Drawing.Point(205, 204);
            this.TextBNumWheels.Name = "TextBNumWheels";
            this.TextBNumWheels.Size = new System.Drawing.Size(134, 22);
            this.TextBNumWheels.TabIndex = 39;
            this.TextBNumWheels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumWheels_KeyPress);
            // 
            // labNumWheels
            // 
            this.labNumWheels.AutoSize = true;
            this.labNumWheels.Location = new System.Drawing.Point(29, 206);
            this.labNumWheels.Name = "labNumWheels";
            this.labNumWheels.Size = new System.Drawing.Size(95, 17);
            this.labNumWheels.TabIndex = 38;
            this.labNumWheels.Text = "Кол-во колёс";
            // 
            // FGroundTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 319);
            this.Controls.Add(this.ButViewEngine);
            this.Controls.Add(this.labEngine);
            this.Controls.Add(this.ButViewTransmisson);
            this.Controls.Add(this.labEdTransmission);
            this.Controls.Add(this.TextBNumWheels);
            this.Controls.Add(this.labNumWheels);
            this.Name = "FGroundTransport";
            this.Text = "FGroundTransport";
            this.Controls.SetChildIndex(this.labNumWheels, 0);
            this.Controls.SetChildIndex(this.TextBNumWheels, 0);
            this.Controls.SetChildIndex(this.labEdTransmission, 0);
            this.Controls.SetChildIndex(this.ButViewTransmisson, 0);
            this.Controls.SetChildIndex(this.labEngine, 0);
            this.Controls.SetChildIndex(this.ButViewEngine, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButViewEngine;
        private System.Windows.Forms.Label labEngine;
        private System.Windows.Forms.Button ButViewTransmisson;
        private System.Windows.Forms.Label labEdTransmission;
        private System.Windows.Forms.TextBox TextBNumWheels;
        private System.Windows.Forms.Label labNumWheels;
    }
}