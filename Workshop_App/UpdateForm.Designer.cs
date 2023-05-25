namespace Workshop_App
{
    partial class UpdateForm
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
            label5 = new Label();
            label4 = new Label();
            UpdateSecondName = new TextBox();
            UpdateLastName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            UpdateFirstName = new TextBox();
            UpdateNumberPhone = new TextBox();
            Model = new Label();
            Brand = new Label();
            UpdateModel = new TextBox();
            UpdateBrand = new TextBox();
            label3 = new Label();
            EntryNumber = new TextBox();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 287);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 32;
            label5.Text = "Отчество владельца";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 231);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 31;
            label4.Text = "Имя владельца";
            // 
            // UpdateSecondName
            // 
            UpdateSecondName.Location = new Point(12, 249);
            UpdateSecondName.Name = "UpdateSecondName";
            UpdateSecondName.Size = new Size(289, 23);
            UpdateSecondName.TabIndex = 30;
            // 
            // UpdateLastName
            // 
            UpdateLastName.Location = new Point(12, 305);
            UpdateLastName.Name = "UpdateLastName";
            UpdateLastName.Size = new Size(289, 23);
            UpdateLastName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 343);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 28;
            label2.Text = "Номер телефона";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 178);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 27;
            label1.Text = "Фамилия владельца";
            // 
            // UpdateFirstName
            // 
            UpdateFirstName.Location = new Point(12, 196);
            UpdateFirstName.Name = "UpdateFirstName";
            UpdateFirstName.Size = new Size(289, 23);
            UpdateFirstName.TabIndex = 26;
            // 
            // UpdateNumberPhone
            // 
            UpdateNumberPhone.Location = new Point(12, 361);
            UpdateNumberPhone.Name = "UpdateNumberPhone";
            UpdateNumberPhone.Size = new Size(289, 23);
            UpdateNumberPhone.TabIndex = 25;
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.Location = new Point(12, 124);
            Model.Name = "Model";
            Model.Size = new Size(114, 15);
            Model.TabIndex = 24;
            Model.Text = "Модель устройства";
            // 
            // Brand
            // 
            Brand.AutoSize = true;
            Brand.Location = new Point(12, 72);
            Brand.Name = "Brand";
            Brand.Size = new Size(40, 15);
            Brand.TabIndex = 23;
            Brand.Text = "Бренд";
            // 
            // UpdateModel
            // 
            UpdateModel.Location = new Point(12, 142);
            UpdateModel.Name = "UpdateModel";
            UpdateModel.Size = new Size(289, 23);
            UpdateModel.TabIndex = 22;
            // 
            // UpdateBrand
            // 
            UpdateBrand.Location = new Point(12, 90);
            UpdateBrand.Name = "UpdateBrand";
            UpdateBrand.Size = new Size(289, 23);
            UpdateBrand.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 28);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 34;
            label3.Text = "Номер записи";
            // 
            // EntryNumber
            // 
            EntryNumber.Location = new Point(12, 46);
            EntryNumber.Name = "EntryNumber";
            EntryNumber.Size = new Size(289, 23);
            EntryNumber.TabIndex = 33;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(118, 400);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 37;
            UpdateButton.Text = "Изменить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 437);
            Controls.Add(UpdateButton);
            Controls.Add(label3);
            Controls.Add(EntryNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(UpdateSecondName);
            Controls.Add(UpdateLastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateFirstName);
            Controls.Add(UpdateNumberPhone);
            Controls.Add(Model);
            Controls.Add(Brand);
            Controls.Add(UpdateModel);
            Controls.Add(UpdateBrand);
            Name = "UpdateForm";
            Text = "Изменение записи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox UpdateSecondName;
        private TextBox UpdateLastName;
        private Label label2;
        private Label label1;
        private TextBox UpdateFirstName;
        private TextBox UpdateNumberPhone;
        private Label Model;
        private Label Brand;
        private TextBox UpdateModel;
        private TextBox UpdateBrand;
        private Label label3;
        private TextBox EntryNumber;
        private Button UpdateButton;
    }
}