namespace Workshop_App
{
    public partial class UpdateForm : Form
    {
        DataGridView DataGridView;

        public UpdateForm(DataGridView dataGridView, params string[] inputData)
        {
            InitializeComponent();
            DataGridView = dataGridView;
            EntryNumber.Text = inputData[0];
            UpdateBrand.Text = inputData[1];
            UpdateModel.Text = inputData[2];
            UpdateFirstName.Text = inputData[3];
            UpdateSecondName.Text = inputData[4];
            UpdateLastName.Text = inputData[5];
            UpdateNumberPhone.Text = inputData[6];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var updateData = new WorkWishSQL();
            if (EntryNumber.Text == "")
                MessageBox.Show("Вы не вписали номер записи");
            else
            {
                if (UpdateBrand.Text != "" & UpdateModel.Text != "" & UpdateFirstName.Text != ""
                    & UpdateSecondName.Text != "" & UpdateNumberPhone.Text != "")
                    updateData.UpdateData(EntryNumber.Text, UpdateBrand.Text, UpdateModel.Text, UpdateFirstName.Text,
                        UpdateSecondName.Text, UpdateLastName.Text, UpdateNumberPhone.Text);
                else MessageBox.Show("Вы указали не все данные");
            }
            Close();
            updateData.LoadData(DataGridView);
        }
    }
}
