namespace Workshop_App
{
    public partial class UpdateForm : Form
    {
        DataGridView DataGridView;

        public UpdateForm(DataGridView dataGridView)
        {
            InitializeComponent();
            DataGridView = dataGridView;
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
