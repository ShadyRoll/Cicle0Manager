namespace Cicle0Manager
{
    partial class MainPage
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
            this.novelTextBox = new System.Windows.Forms.RichTextBox();
            this.titleTextBox = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.novelslListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // novelTextBox
            // 
            this.novelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.novelTextBox.Location = new System.Drawing.Point(12, 118);
            this.novelTextBox.Name = "novelTextBox";
            this.novelTextBox.Size = new System.Drawing.Size(662, 446);
            this.novelTextBox.TabIndex = 0;
            this.novelTextBox.Text = "";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(12, 16);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(662, 41);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.Text = "";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(12, 570);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(312, 62);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(330, 570);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(344, 62);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // novelslListView
            // 
            this.novelslListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.novelslListView.AutoArrange = false;
            this.novelslListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.novelslListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.novelslListView.FullRowSelect = true;
            this.novelslListView.HideSelection = false;
            this.novelslListView.Location = new System.Drawing.Point(694, 16);
            this.novelslListView.MultiSelect = false;
            this.novelslListView.Name = "novelslListView";
            this.novelslListView.Size = new System.Drawing.Size(344, 548);
            this.novelslListView.TabIndex = 5;
            this.novelslListView.TileSize = new System.Drawing.Size(332, 30);
            this.novelslListView.UseCompatibleStateImageBehavior = false;
            this.novelslListView.View = System.Windows.Forms.View.Tile;
            this.novelslListView.SelectedIndexChanged += new System.EventHandler(this.novelslListView_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(694, 570);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 62);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(760, 570);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 62);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(826, 570);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(212, 62);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1050, 644);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.novelslListView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.novelTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cicle0 Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox novelTextBox;
        private System.Windows.Forms.RichTextBox titleTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListView novelslListView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

