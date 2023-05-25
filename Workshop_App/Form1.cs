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
            workWishSQL.sqlConnection.Open();
            workWishSQL.LoadData(dataGrid);
            dataGrid.Columns[0].HeaderText = "����� ������";
            dataGrid.Columns[1].HeaderText = "�����";
            dataGrid.Columns[2].HeaderText = "������";
            dataGrid.Columns[3].HeaderText = "���� ������ �������";
            dataGrid.Columns[4].HeaderText = "������ �������";
            dataGrid.Columns[5].HeaderText = "�������";
            dataGrid.Columns[6].HeaderText = "���";
            dataGrid.Columns[7].HeaderText = "��������";
            dataGrid.Columns[8].HeaderText = "����� ��������";
        }

        private void SaveDevise_Click(object sender, EventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            workWishSQL.InsertNewData(InputBrand.Text, InputModel.Text, InputFirstName.Text, InputSecondName.Text, InputLastName.Text, InputNumberPhone.Text);
            workWishSQL.LoadData(dataGrid);
            workWishSQL.sqlConnection.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm(dataGrid);
            updateForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            int indexCell = dataGrid.CurrentCell.RowIndex;
            object idValue = dataGrid[0, indexCell].Value;
            workWishSQL.DeleteData(idValue);
            dataGrid.Rows.Remove(dataGrid.Rows[indexCell]);
            workWishSQL.LoadData(dataGrid);
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
                        $"��������� ������������� �� ������ � {monthCalendar1.SelectionStart:dd.MM.yyyy} " +
                        $"�� {monthCalendar2.SelectionStart:dd.MM.yyyy}: {str}", "����������", MessageBoxButtons.OK
                    );
            }
            else MessageBox.Show("�� �� ���������� �������� �������");
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            if (e.KeyChar == (char)13)
            {
                workWishSQL.Search(dataGrid, Search.Text);
            }
        }
    }
}