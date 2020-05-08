namespace CRUD
{
    partial class FMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupBoxMenu = new System.Windows.Forms.GroupBox();
            this.labCrypt = new System.Windows.Forms.Label();
            this.comboBCrypt = new System.Windows.Forms.ComboBox();
            this.ButLoad = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.ButAdd = new System.Windows.Forms.Button();
            this.labTypeSer = new System.Windows.Forms.Label();
            this.ComboBoxTypeTransport = new System.Windows.Forms.ComboBox();
            this.ComboBTypeSer = new System.Windows.Forms.ComboBox();
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.GroupBoxMenu.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxMenu
            // 
            this.GroupBoxMenu.Controls.Add(this.labCrypt);
            this.GroupBoxMenu.Controls.Add(this.comboBCrypt);
            this.GroupBoxMenu.Controls.Add(this.ButLoad);
            this.GroupBoxMenu.Controls.Add(this.ButSave);
            this.GroupBoxMenu.Controls.Add(this.ButAdd);
            this.GroupBoxMenu.Controls.Add(this.labTypeSer);
            this.GroupBoxMenu.Controls.Add(this.ComboBoxTypeTransport);
            this.GroupBoxMenu.Controls.Add(this.ComboBTypeSer);
            this.GroupBoxMenu.Location = new System.Drawing.Point(531, 28);
            this.GroupBoxMenu.Name = "GroupBoxMenu";
            this.GroupBoxMenu.Size = new System.Drawing.Size(354, 272);
            this.GroupBoxMenu.TabIndex = 15;
            this.GroupBoxMenu.TabStop = false;
            this.GroupBoxMenu.Text = "Меню";
            // 
            // labCrypt
            // 
            this.labCrypt.AutoSize = true;
            this.labCrypt.Location = new System.Drawing.Point(29, 217);
            this.labCrypt.Name = "labCrypt";
            this.labCrypt.Size = new System.Drawing.Size(93, 17);
            this.labCrypt.TabIndex = 16;
            this.labCrypt.Text = "Шифрование";
            // 
            // comboBCrypt
            // 
            this.comboBCrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCrypt.FormattingEnabled = true;
            this.comboBCrypt.Location = new System.Drawing.Point(142, 211);
            this.comboBCrypt.Name = "comboBCrypt";
            this.comboBCrypt.Size = new System.Drawing.Size(164, 24);
            this.comboBCrypt.TabIndex = 15;
            // 
            // ButLoad
            // 
            this.ButLoad.Location = new System.Drawing.Point(142, 140);
            this.ButLoad.Name = "ButLoad";
            this.ButLoad.Size = new System.Drawing.Size(111, 31);
            this.ButLoad.TabIndex = 14;
            this.ButLoad.Text = "Загрузить";
            this.ButLoad.UseVisualStyleBackColor = true;
            this.ButLoad.Click += new System.EventHandler(this.ButLoad_Click);
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(30, 140);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(106, 31);
            this.ButSave.TabIndex = 13;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(29, 34);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(128, 42);
            this.ButAdd.TabIndex = 9;
            this.ButAdd.Text = "Добавить";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // labTypeSer
            // 
            this.labTypeSer.AutoSize = true;
            this.labTypeSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTypeSer.Location = new System.Drawing.Point(28, 101);
            this.labTypeSer.MaximumSize = new System.Drawing.Size(140, 0);
            this.labTypeSer.Name = "labTypeSer";
            this.labTypeSer.Size = new System.Drawing.Size(33, 17);
            this.labTypeSer.TabIndex = 12;
            this.labTypeSer.Text = "Вид";
            // 
            // ComboBoxTypeTransport
            // 
            this.ComboBoxTypeTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTypeTransport.FormattingEnabled = true;
            this.ComboBoxTypeTransport.Items.AddRange(new object[] {
            "Автомобиль ",
            "Мотоцикл",
            "Подлодка ",
            "Теплоход",
            "Парусник"});
            this.ComboBoxTypeTransport.Location = new System.Drawing.Point(179, 41);
            this.ComboBoxTypeTransport.Name = "ComboBoxTypeTransport";
            this.ComboBoxTypeTransport.Size = new System.Drawing.Size(149, 24);
            this.ComboBoxTypeTransport.TabIndex = 10;
            // 
            // ComboBTypeSer
            // 
            this.ComboBTypeSer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBTypeSer.FormattingEnabled = true;
            this.ComboBTypeSer.Items.AddRange(new object[] {
            "Бинарный",
            "JSON",
            "Текстовый"});
            this.ComboBTypeSer.Location = new System.Drawing.Point(142, 98);
            this.ComboBTypeSer.Name = "ComboBTypeSer";
            this.ComboBTypeSer.Size = new System.Drawing.Size(164, 24);
            this.ComboBTypeSer.TabIndex = 11;
            // 
            // listViewInfo
            // 
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderType,
            this.columnHeaderName});
            this.listViewInfo.FullRowSelect = true;
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(29, 39);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(485, 261);
            this.listViewInfo.TabIndex = 14;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Тип";
            this.columnHeaderType.Width = 170;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Модель";
            this.columnHeaderName.Width = 170;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 104);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.DelToolStripMenuItem.Text = "Удалить";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ViewToolStripMenuItem.Text = "Просмотр";
            this.ViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 337);
            this.Controls.Add(this.GroupBoxMenu);
            this.Controls.Add(this.listViewInfo);
            this.Name = "FMenu";
            this.Text = "Меню";
            this.GroupBoxMenu.ResumeLayout(false);
            this.GroupBoxMenu.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMenu;
        private System.Windows.Forms.Label labCrypt;
        private System.Windows.Forms.ComboBox comboBCrypt;
        private System.Windows.Forms.Button ButLoad;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Label labTypeSer;
        private System.Windows.Forms.ComboBox ComboBoxTypeTransport;
        private System.Windows.Forms.ComboBox ComboBTypeSer;
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
    }
}

