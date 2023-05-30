namespace Workshop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            workWishSQL.LoadData(dataGrid);
            dataGrid.Columns[0].HeaderText = "Номер записи";
            dataGrid.Columns[1].HeaderText = "Бренд";
            dataGrid.Columns[2].HeaderText = "Модель";
            dataGrid.Columns[3].HeaderText = "Дата начала ремонта";
            dataGrid.Columns[4].HeaderText = "Статус ремонта";
            dataGrid.Columns[5].HeaderText = "Фамилия";
            dataGrid.Columns[6].HeaderText = "Имя";
            dataGrid.Columns[7].HeaderText = "Отчество";
            dataGrid.Columns[8].HeaderText = "Номер телефона";
            InputBrand.Items.AddRange(workWishSQL.GetHint("SELECT DISTINCT brand FROM Hardware").ToArray());
        }

        private void SaveDevise_Click(object sender, EventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            workWishSQL.InsertNewData(InputBrand.Text, InputModel.Text, InputFirstName.Text, InputSecondName.Text, InputLastName.Text, InputNumberPhone.Text);
            workWishSQL.LoadData(dataGrid);
            InputBrand.Items.Clear();
            InputBrand.Items.AddRange(workWishSQL.GetHint("SELECT DISTINCT brand FROM Hardware").ToArray());
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string number = "", brand = "", model = "", firstName = "", secondName = "", lastName = "", numberPhone = "";
            foreach (DataGridViewRow item in dataGrid.SelectedRows)
            {
                number = item.Cells[0].Value.ToString();
                brand = item.Cells[1].Value.ToString();
                model = item.Cells[2].Value.ToString();
                firstName = item.Cells[5].Value.ToString();
                secondName = item.Cells[6].Value.ToString();
                lastName = item.Cells[7].Value.ToString();
                numberPhone = item.Cells[8].Value.ToString();
            }
            var updateForm = new UpdateForm(dataGrid, number, brand, model, firstName, secondName, lastName, numberPhone);
            updateForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmDelete = new ConfirmDelete(dataGrid);
            confirmDelete.Show();
        }

        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            int indexCell = dataGrid.CurrentCell.RowIndex;
            object idValue = dataGrid[0, indexCell].Value;
            workWishSQL.UpdateStatus(idValue);
            workWishSQL.LoadData(dataGrid);
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            string start = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string finish = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd");
            if (start != "" && finish != "")
            {
                WorkWishSQL workWishSQL = new WorkWishSQL();
                int str = workWishSQL.GetStatistic(start, finish);
                MessageBox.Show(
                        $"Устройств востановленно за период с {monthCalendar1.SelectionStart:dd.MM.yyyy} " +
                        $"по {monthCalendar2.SelectionStart:dd.MM.yyyy}: {str}", "Статистика", MessageBoxButtons.OK
                    );
            }
            else MessageBox.Show("Вы не установили значения выборки");
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            if (e.KeyChar == (char)13)
            {
                workWishSQL.Search(dataGrid, Search.Text);
            }
        }

        private void InputBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            InputModel.Items.Clear();
            InputModel.Items.AddRange(workWishSQL.GetHint(
                "SELECT DISTINCT model " +
                "FROM Model " +
                "INNER JOIN Hardware " +
                "ON Model.id = model_id " +
                $"WHERE brand = N'{InputBrand.Text}'").ToArray());
        }
    }
}