namespace CRUD.VehicleForms.WTransportForms
{
    partial class FSubmarine
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
            this.TextBTurbines = new System.Windows.Forms.TextBox();
            this.labTurbines = new System.Windows.Forms.Label();
            this.TextBMaxImmersionDepth = new System.Windows.Forms.TextBox();
            this.labMaxImmersionDepth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(318, 259);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(111, 36);
            this.ButSave.TabIndex = 32;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // TextBTurbines
            // 
            this.TextBTurbines.Location = new System.Drawing.Point(587, 169);
            this.TextBTurbines.Name = "TextBTurbines";
            this.TextBTurbines.Size = new System.Drawing.Size(134, 22);
            this.TextBTurbines.TabIndex = 36;
            this.TextBTurbines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBTurbines_KeyPress);
            // 
            // labTurbines
            // 
            this.labTurbines.AutoSize = true;
            this.labTurbines.Location = new System.Drawing.Point(406, 172);
            this.labTurbines.Name = "labTurbines";
            this.labTurbines.Size = new System.Drawing.Size(103, 17);
            this.labTurbines.TabIndex = 35;
            this.labTurbines.Text = "Кол-во турбин";
            // 
            // TextBMaxImmersionDepth
            // 
            this.TextBMaxImmersionDepth.Location = new System.Drawing.Point(587, 127);
            this.TextBMaxImmersionDepth.Name = "TextBMaxImmersionDepth";
            this.TextBMaxImmersionDepth.Size = new System.Drawing.Size(134, 22);
            this.TextBMaxImmersionDepth.TabIndex = 34;
            this.TextBMaxImmersionDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBMaxImmersionDepth_KeyPress);
            // 
            // labMaxImmersionDepth
            // 
            this.labMaxImmersionDepth.AutoSize = true;
            this.labMaxImmersionDepth.Location = new System.Drawing.Point(406, 130);
            this.labMaxImmersionDepth.Name = "labMaxImmersionDepth";
            this.labMaxImmersionDepth.Size = new System.Drawing.Size(138, 17);
            this.labMaxImmersionDepth.TabIndex = 33;
            this.labMaxImmersionDepth.Text = "Макс. глубина погр.";
            // 
            // FSubmarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.TextBTurbines);
            this.Controls.Add(this.labTurbines);
            this.Controls.Add(this.TextBMaxImmersionDepth);
            this.Controls.Add(this.labMaxImmersionDepth);
            this.Controls.Add(this.ButSave);
            this.Name = "FSubmarine";
            this.Text = "Подлодка";
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.Controls.SetChildIndex(this.labMaxImmersionDepth, 0);
            this.Controls.SetChildIndex(this.TextBMaxImmersionDepth, 0);
            this.Controls.SetChildIndex(this.labTurbines, 0);
            this.Controls.SetChildIndex(this.TextBTurbines, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.TextBox TextBTurbines;
        private System.Windows.Forms.Label labTurbines;
        private System.Windows.Forms.TextBox TextBMaxImmersionDepth;
        private System.Windows.Forms.Label labMaxImmersionDepth;
    }
}