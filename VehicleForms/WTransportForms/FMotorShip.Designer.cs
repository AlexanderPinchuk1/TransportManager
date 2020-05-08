namespace CRUD.VehicleForms.WTransportForms
{
    partial class FMotorShip
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
            this.TextBNumPipes = new System.Windows.Forms.TextBox();
            this.labNumPipes = new System.Windows.Forms.Label();
            this.TextNumScrews = new System.Windows.Forms.TextBox();
            this.labNumScrews = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(334, 272);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(111, 36);
            this.ButSave.TabIndex = 32;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // TextBNumPipes
            // 
            this.TextBNumPipes.Location = new System.Drawing.Point(587, 169);
            this.TextBNumPipes.Name = "TextBNumPipes";
            this.TextBNumPipes.Size = new System.Drawing.Size(134, 22);
            this.TextBNumPipes.TabIndex = 36;
            this.TextBNumPipes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumPipes_KeyPress);
            // 
            // labNumPipes
            // 
            this.labNumPipes.AutoSize = true;
            this.labNumPipes.Location = new System.Drawing.Point(406, 172);
            this.labNumPipes.Name = "labNumPipes";
            this.labNumPipes.Size = new System.Drawing.Size(87, 17);
            this.labNumPipes.TabIndex = 35;
            this.labNumPipes.Text = "Кол-во труб";
            // 
            // TextNumScrews
            // 
            this.TextNumScrews.Location = new System.Drawing.Point(587, 127);
            this.TextNumScrews.Name = "TextNumScrews";
            this.TextNumScrews.Size = new System.Drawing.Size(134, 22);
            this.TextNumScrews.TabIndex = 34;
            this.TextNumScrews.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNumScrews_KeyPress);
            // 
            // labNumScrews
            // 
            this.labNumScrews.AutoSize = true;
            this.labNumScrews.Location = new System.Drawing.Point(406, 130);
            this.labNumScrews.Name = "labNumScrews";
            this.labNumScrews.Size = new System.Drawing.Size(102, 17);
            this.labNumScrews.TabIndex = 33;
            this.labNumScrews.Text = "Кол-во винтов";
            // 
            // FMotorShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.TextBNumPipes);
            this.Controls.Add(this.labNumPipes);
            this.Controls.Add(this.TextNumScrews);
            this.Controls.Add(this.labNumScrews);
            this.Controls.Add(this.ButSave);
            this.Name = "FMotorShip";
            this.Text = "Теплоход";
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.Controls.SetChildIndex(this.labNumScrews, 0);
            this.Controls.SetChildIndex(this.TextNumScrews, 0);
            this.Controls.SetChildIndex(this.labNumPipes, 0);
            this.Controls.SetChildIndex(this.TextBNumPipes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.TextBox TextBNumPipes;
        private System.Windows.Forms.Label labNumPipes;
        private System.Windows.Forms.TextBox TextNumScrews;
        private System.Windows.Forms.Label labNumScrews;
    }
}