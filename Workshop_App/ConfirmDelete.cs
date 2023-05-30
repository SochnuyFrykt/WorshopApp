namespace Workshop_App
{
    public partial class ConfirmDelete : Form
    {
        DataGridView gridView;

        public ConfirmDelete(DataGridView gridView)
        {
            InitializeComponent();
            this.gridView = gridView;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            WorkWishSQL workWishSQL = new WorkWishSQL();
            int indexCell = gridView.CurrentCell.RowIndex;
            object idValue = gridView[0, indexCell].Value;
            workWishSQL.DeleteData(idValue);
            gridView.Rows.Remove(gridView.Rows[indexCell]);
            workWishSQL.LoadData(gridView);
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
