using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;

namespace VinylMusicStore.Model
{
    internal class ReceiptsFromDB
    {
        public int GetMaxReceiptNum()
        {
            int maxNum = 0;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select id_receipt from public.receipts order by id_receipt desc limit 1";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            maxNum = (int) reader[0] + 1;
                        }
                        return maxNum;
                    }
                    reader.Close();
                    return maxNum;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return maxNum;
            }
        }

        private int GetMaxComposNum()
        {
            int maxNum = 0;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select id_compos from public.composition order by id_compos desc limit 1";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            maxNum = (int)reader[0] + 1;
                        }
                        return maxNum;
                    }
                    reader.Close();
                    return maxNum;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return maxNum;
            }
        }

        private void AddReceipt(Receipt receipt)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "call add_receipt(@receiptId, @dateOfCreation, @sum, @employee, @FN, @FD, @FPD)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("receiptId", receipt.ReceiptID);
                    command.Parameters.Add(new NpgsqlParameter("dateOfCreation", NpgsqlTypes.NpgsqlDbType.Date) { Value = DateTime.Parse(receipt.DateOfCreation) });
                    command.Parameters.Add(new NpgsqlParameter("sum", NpgsqlTypes.NpgsqlDbType.Money) { Value = Decimal.Parse(receipt.Sum.ToString()) });
                    command.Parameters.AddWithValue("employee", receipt.Employee);
                    command.Parameters.AddWithValue("FN", receipt.FN);
                    command.Parameters.Add(new NpgsqlParameter("FD", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = receipt.FD });
                    command.Parameters.Add(new NpgsqlParameter("FPD", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = receipt.FPD });

                    int i = command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCompositionAndInstock(int maxNum, int receipt, int album, int count)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "call add_composition_and_update_instock(@maxNum, @receipt, @album, @count)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("maxNum", maxNum);
                    command.Parameters.AddWithValue("receipt", receipt);
                    command.Parameters.AddWithValue("album", album);
                    command.Parameters.AddWithValue("count", count);

                    int i = command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateReceipt(Receipt receipt, int[,] values, int count)
        {
            int maxNum = GetMaxComposNum();
            AddReceipt(receipt);
            for (int i = 0; i < count; i++)
                AddCompositionAndInstock(maxNum, receipt.ReceiptID, values[i, 0], values[i, 1]);
        }

        public int GetEmployeeID(string employee)
        {
            int id = 0;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select emp_id from public.employees where fio = @employee";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("employee", employee);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = (int)reader[0];
                        }
                        return id;
                    }
                    reader.Close();
                    return id;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return id;
            }
        }
    }
}
