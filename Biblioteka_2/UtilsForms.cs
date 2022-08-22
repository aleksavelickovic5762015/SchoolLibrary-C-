using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_2
{
    static partial class Utils
    {
        public static class Forms
        {
            public static void ConfigureForm(Form form)
            {
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.MaximizeBox = false;
            }

            public static void ConfigureDataGridView(DataGridView dataGridView, bool autoGenerateColumns = true)
            {
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.AllowUserToOrderColumns = true;
                dataGridView.MultiSelect = false;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.ReadOnly = true;
                dataGridView.AutoGenerateColumns = autoGenerateColumns;
            }

            public static void ReplaceForm(Form current, Form next, bool closeOnClose = false)
            {
                current.Hide();
                if (closeOnClose)
                    next.Closed += (s, args) => current.Close();
                else
                    next.Closed += (s, args) => current.Show();
                next.Show();
            }

            public static DataTable RefreshDataGridView(DataGridView dgv, string query, Dictionary<string, object> parameters = null)
            {
                DataTable dt = DB.DataTableFromQuery(query, parameters);
                dgv.DataSource = dt;
                return dt;
            }

            public static DataRow GetDataRowFromDataGridViewSelection(DataGridView dgv, string dgvIdFieldName, DataTable dt, string dtIdFieldName)
            {
                int idOfSelection = (int)(long)dgv.CurrentRow.Cells[dgvIdFieldName].Value;
                DataRow dtRow = dt.Select($"{dtIdFieldName} = {idOfSelection}").First();
                return dtRow;
            }

            public static string GetDataRowFieldText<FieldType>(DataRow dr, string fieldName)
            {
                return Convert.ToString(dr.Field<FieldType>(fieldName));
            }
        }
    }
}
