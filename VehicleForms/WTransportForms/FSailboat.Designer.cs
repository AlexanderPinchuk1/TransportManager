namespace CRUD.VehicleForms.WTransportForms
{
    partial class FSailboat
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
            this.TextBNumMasts = new System.Windows.Forms.TextBox();
            this.labMasts = new System.Windows.Forms.Label();
            this.TextBNumSails = new System.Windows.Forms.TextBox();
            this.labSails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(325, 257);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(111, 36);
            this.ButSave.TabIndex = 32;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // TextBNumMasts
            // 
            this.TextBNumMasts.Location = new System.Drawing.Point(587, 169);
            this.TextBNumMasts.Name = "TextBNumMasts";
            this.TextBNumMasts.Size = new System.Drawing.Size(134, 22);
            this.TextBNumMasts.TabIndex = 36;
            this.TextBNumMasts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumMasts_KeyPress);
            // 
            // labMasts
            // 
            this.labMasts.AutoSize = true;
            this.labMasts.Location = new System.Drawing.Point(406, 172);
            this.labMasts.Name = "labMasts";
            this.labMasts.Size = new System.Drawing.Size(89, 17);
            this.labMasts.TabIndex = 35;
            this.labMasts.Text = "Кол-во мачт";
            // 
            // TextBNumSails
            // 
            this.TextBNumSails.Location = new System.Drawing.Point(587, 127);
            this.TextBNumSails.Name = "TextBNumSails";
            this.TextBNumSails.Size = new System.Drawing.Size(134, 22);
            this.TextBNumSails.TabIndex = 34;
            this.TextBNumSails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumSails_KeyPress);
            // 
            // labSails
            // 
            this.labSails.AutoSize = true;
            this.labSails.Location = new System.Drawing.Point(406, 130);
            this.labSails.Name = "labSails";
            this.labSails.Size = new System.Drawing.Size(110, 17);
            this.labSails.TabIndex = 33;
            this.labSails.Text = "Кол-во парусов";
            // 
            // FSailboat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 315);
            this.Controls.Add(this.TextBNumMasts);
            this.Controls.Add(this.labMasts);
            this.Controls.Add(this.TextBNumSails);
            this.Controls.Add(this.labSails);
            this.Controls.Add(this.ButSave);
            this.Name = "FSailboat";
            this.Text = "Парусник";
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.Controls.SetChildIndex(this.labSails, 0);
            this.Controls.SetChildIndex(this.TextBNumSails, 0);
            this.Controls.SetChildIndex(this.labMasts, 0);
            this.Controls.SetChildIndex(this.TextBNumMasts, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.TextBox TextBNumMasts;
        private System.Windows.Forms.Label labMasts;
        private System.Windows.Forms.TextBox TextBNumSails;
        private System.Windows.Forms.Label labSails;
    }
}