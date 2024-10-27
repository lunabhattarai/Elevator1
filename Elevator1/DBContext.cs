using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class DBContext
    {
        string connecting = "server=DESKTOP-2E25VUI\\LUNA_TEST;Database=testing; Trusted_Connection=True;";
        public void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    string query = @"Insert into Log_2 (LogTime, EventDescription) values (@Time,@Log)";
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "LogTime");
                        adapter.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "EventDescription");
                        conn.Open();
                        adapter.Update(dt);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB:" + ex.Message);
            }

        }

        public void loadLogsFormDB(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    string query = @"Select LogTime, EventDescription from Log_2 order by LogTime";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();
                        adapter.Fill(dt);
                        dataGridViewLogs.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            string events = row["EventDescription"].ToString();

                            dataGridViewLogs.Rows.Add(currentTime, events);


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB:" + ex.Message);

            }
        }

        public void DeleteLogFromDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    string query = @"DELETE FROM Log_2";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting log from DB: " + ex.Message);
            }
        }
    }
}
