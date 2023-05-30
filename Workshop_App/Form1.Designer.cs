namespace Workshop_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGrid = new DataGridView();
            Brand = new Label();
            Model = new Label();
            SaveDevise = new Button();
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            Statistics = new Button();
            Start = new Label();
            End = new Label();
            InputNumberPhone = new TextBox();
            InputFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Search = new TextBox();
            label3 = new Label();
            InputLastName = new TextBox();
            InputSecondName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            DeleteButton = new Button();
            UpdateButton = new Button();
            UpdateStatusButton = new Button();
            InputBrand = new ComboBox();
            InputModel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(294, 77);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1397, 690);
            dataGrid.TabIndex = 100;
            // 
            // Brand
            // 
            Brand.AutoSize = true;
            Brand.Location = new Point(52, 25);
            Brand.Name = "Brand";
            Brand.Size = new Size(40, 15);
            Brand.TabIndex = 2;
            Brand.Text = "Бренд";
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.Location = new Point(52, 77);
            Model.Name = "Model";
            Model.Size = new Size(114, 15);
            Model.TabIndex = 3;
            Model.Text = "Модель устройства";
            // 
            // SaveDevise
            // 
            SaveDevise.Location = new Point(95, 352);
            SaveDevise.Name = "SaveDevise";
            SaveDevise.Size = new Size(75, 23);
            SaveDevise.TabIndex = 6;
            SaveDevise.Text = "Добавить";
            SaveDevise.UseVisualStyleBackColor = true;
            SaveDevise.Click += SaveDevise_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(53, 415);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 100;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(52, 605);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 100;
            // 
            // Statistics
            // 
            Statistics.Location = new Point(52, 779);
            Statistics.Name = "Statistics";
            Statistics.Size = new Size(164, 23);
            Statistics.TabIndex = 11;
            Statistics.Text = "Вывести статистику";
            Statistics.UseVisualStyleBackColor = true;
            Statistics.Click += Statistics_Click;
            // 
            // Start
            // 
            Start.AutoSize = true;
            Start.Location = new Point(52, 391);
            Start.Name = "Start";
            Start.Size = new Size(94, 15);
            Start.TabIndex = 8;
            Start.Text = "Начало отсчёта";
            // 
            // End
            // 
            End.AutoSize = true;
            End.Location = new Point(52, 586);
            End.Name = "End";
            End.Size = new Size(86, 15);
            End.TabIndex = 9;
            End.Text = "Конец отсчёта";
            // 
            // InputNumberPhone
            // 
            InputNumberPhone.Location = new Point(52, 314);
            InputNumberPhone.Name = "InputNumberPhone";
            InputNumberPhone.Size = new Size(175, 23);
            InputNumberPhone.TabIndex = 5;
            // 
            // InputFirstName
            // 
            InputFirstName.Location = new Point(52, 149);
            InputFirstName.Name = "InputFirstName";
            InputFirstName.Size = new Size(175, 23);
            InputFirstName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 131);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 12;
            label1.Text = "Фамилия владельца";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 296);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 13;
            label2.Text = "Номер телефона";
            // 
            // Search
            // 
            Search.Location = new Point(294, 43);
            Search.Name = "Search";
            Search.Size = new Size(420, 23);
            Search.TabIndex = 7;
            Search.KeyPress += Search_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 25);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 16;
            label3.Text = "Поиск";
            // 
            // InputLastName
            // 
            InputLastName.Location = new Point(52, 258);
            InputLastName.Name = "InputLastName";
            InputLastName.Size = new Size(175, 23);
            InputLastName.TabIndex = 4;
            // 
            // InputSecondName
            // 
            InputSecondName.Location = new Point(52, 202);
            InputSecondName.Name = "InputSecondName";
            InputSecondName.Size = new Size(175, 23);
            InputSecondName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 184);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 19;
            label4.Text = "Имя владельца";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 240);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 20;
            label5.Text = "Отчество владельца";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(1527, 42);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(164, 23);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Удалить запись";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(1357, 42);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(164, 23);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "Изменить запись";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdateStatusButton
            // 
            UpdateStatusButton.Location = new Point(1187, 42);
            UpdateStatusButton.Name = "UpdateStatusButton";
            UpdateStatusButton.Size = new Size(164, 23);
            UpdateStatusButton.TabIndex = 8;
            UpdateStatusButton.Text = "Изменить статус";
            UpdateStatusButton.UseVisualStyleBackColor = true;
            UpdateStatusButton.Click += UpdateStatusButton_Click;
            // 
            // InputBrand
            // 
            InputBrand.FormattingEnabled = true;
            InputBrand.Location = new Point(52, 43);
            InputBrand.Name = "InputBrand";
            InputBrand.Size = new Size(175, 23);
            InputBrand.TabIndex = 101;
            InputBrand.SelectedIndexChanged += InputBrand_SelectedIndexChanged;
            // 
            // InputModel
            // 
            InputModel.FormattingEnabled = true;
            InputModel.Location = new Point(52, 95);
            InputModel.Name = "InputModel";
            InputModel.Size = new Size(175, 23);
            InputModel.TabIndex = 102;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1703, 807);
            Controls.Add(InputModel);
            Controls.Add(InputBrand);
            Controls.Add(UpdateStatusButton);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(InputSecondName);
            Controls.Add(InputLastName);
            Controls.Add(label3);
            Controls.Add(Search);
            Controls.Add(dataGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputFirstName);
            Controls.Add(InputNumberPhone);
            Controls.Add(End);
            Controls.Add(Start);
            Controls.Add(Statistics);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Controls.Add(SaveDevise);
            Controls.Add(Model);
            Controls.Add(Brand);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Brand;
        private Label Model;
        private Button SaveDevise;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Button Statistics;
        private Label Start;
        private Label End;
        private TextBox InputNumberPhone;
        private TextBox InputFirstName;
        private Label label1;
        private Label label2;
        private TextBox Search;
        private Label label3;
        private TextBox InputLastName;
        private TextBox InputSecondName;
        private Label label4;
        private Label label5;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button UpdateStatusButton;
        public DataGridView dataGrid;
        private ComboBox InputBrand;
        private ComboBox InputModel;
    }
}