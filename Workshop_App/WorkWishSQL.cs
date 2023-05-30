using System.Data;
using System.Data.SqlClient;

namespace Workshop_App
{
    internal class WorkWishSQL
    {
        private static string pathDB = @"C:\Users\sereb\OneDrive\Документы\WorkShop_SQLServer.mdf";

        public SqlConnection sqlConnection = new SqlConnection(
                @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathDB};Integrated Security=True;Connect Timeout=30"
            );

        private SqlDataAdapter sqlAdapter = null;

        private DataSet dataSet = new DataSet();

        public void LoadData(DataGridView dataGrid)
        {
            try
            {
                sqlConnection.Open();
                sqlAdapter = new SqlDataAdapter(
                    "SELECT Hardware.id, brand, model, dateAceptance, status, firstName, secondName, lastName, phone " +
                    "FROM Hardware " +
                    "INNER JOIN Model ON Model.id = model_id " +
                    "INNER JOIN Users ON Users.id = id_user " +
                    "ORDER BY Hardware.id DESC",
                    sqlConnection
                );
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.Fill(dataSet, "Workshop");
                dataGrid.DataSource = dataSet.Tables["Workshop"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        public void InsertNewData(params string[] insertData)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            if (insertData[0] != "" & insertData[1] != "" & insertData[2] != "" & insertData[3] != "" & insertData[5] != "")
                sqlCommand.CommandText =
                    "INSERT Users(firstName, secondName, lastName, phone)" +
                    $"VALUES(N'{insertData[2]}', N'{insertData[3]}', N'{insertData[4]}', '{insertData[5]}')" +
                    "INSERT Model(Model)" +
                    $"VALUES('{insertData[1]}')" +
                    "INSERT Hardware(brand, model_id, dateAceptance, status, id_user)" +
                    $"VALUES('{insertData[0]}', " +
                    $"(SELECT TOP 1 id FROM model ORDER BY ID DESC), " +
                    $"'{DateTime.Now.ToString("MM/dd/yyyy")}', N'В ремонте', (SELECT TOP 1 id FROM Users ORDER BY ID DESC))";
            else MessageBox.Show("Указанны не все значения");
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void UpdateData(params string[] updateData)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText =
                "UPDATE Hardware " +
                $"SET brand = N'{updateData[1]}' " +
                $"WHERE id = {updateData[0]} " +
                "UPDATE model " +
                $"SET model = N'{updateData[2]}' " +
                $"WHERE id = {updateData[0]} " +
                $"UPDATE Users " +
                $"SET firstName = N'{updateData[3]}' " +
                $"FROM Users, Hardware " +
                $"WHERE Hardware.id_user = Users.id and Hardware.id = {updateData[0]} " +
                $"UPDATE Users " +
                $"SET secondName = N'{updateData[4]}' " +
                $"FROM Users, Hardware " +
                $"WHERE Hardware.id_user = Users.id and Hardware.id = {updateData[0]} " +
                $"UPDATE Users " +
                $"SET lastName = N'{updateData[5]}' " +
                $"FROM Users, Hardware " +
                $"WHERE Hardware.id_user = Users.id and Hardware.id = {updateData[0]} " +
                $"UPDATE Users " +
                $"SET phone = '{updateData[6]}' " +
                $"FROM Users, Hardware " +
                $"WHERE Hardware.id_user = Users.id and Hardware.id = {updateData[0]} ";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void UpdateStatus(object id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText =
                "UPDATE Hardware " +
                $"SET status = N'Ремонт окончен ({DateTime.Now.ToString("MM/dd/yyyy")})' " +
                $"WHERE id = '{id}'";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteData(object id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText =
                    "DELETE Hardware " +
                    "FROM Hardware " +
                    "INNER JOIN Model ON Model.id = model_id " +
                    "INNER JOIN Users ON Users.id = id_user " +
                    $"Where Hardware.id = '{id}'";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public int GetStatistic(string start, string finish)
        {
            sqlConnection.Open();
            SqlCommand thisCommand = new SqlCommand("SELECT COUNT(*) " +
                    "FROM Hardware " +
                    $"WHERE dateAceptance BETWEEN '{start}' AND '{finish}' " +
                    "AND status LIKE N'Ремонт окончен%' ", sqlConnection);
            int numStatistic = (int)thisCommand.ExecuteScalar();
            sqlConnection.Close();
            return numStatistic;
        }

        public void Search(DataGridView dataGrid, string searchText)
        {
            sqlConnection.Open();
            sqlAdapter = new SqlDataAdapter(
                "SELECT Hardware.id, brand, model, dateAceptance, status, firstName, secondName, lastName, phone " +
                "FROM Hardware " +
                "INNER JOIN Model ON Model.id = model_id " +
                "INNER JOIN Users ON Users.id = id_user " +
                $"WHERE brand LIKE N'%{searchText}%' " +
                $"OR model LIKE N'%{searchText}%' " +
                $"OR dateAceptance LIKE N'%{searchText}%' " +
                $"OR status LIKE N'%{searchText}%' " +
                $"OR firstName LIKE N'%{searchText}%' " +
                $"OR secondName LIKE N'%{searchText}%' " +
                $"OR lastName LIKE N'%{searchText}%' " +
                $"OR phone LIKE N'%{searchText}%' " +
                "ORDER BY Hardware.id DESC",
                sqlConnection
            );
            sqlAdapter.Fill(dataSet, "Workshop");
            dataGrid.DataSource = dataSet.Tables["Workshop"];
            sqlConnection.Close();
        }

        public List<string> GetHint(string query)
        {
            sqlConnection.Open();
            var listBrand = new List<string>();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string str = reader[0].ToString();
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    if (reader[i].ToString() != "")
                        str += $"  {reader[i]}";
                }
                listBrand.Add(str);
            }
            sqlConnection.Close();
            return listBrand;
        }
    }
}
