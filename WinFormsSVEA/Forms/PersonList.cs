using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSVEA
{
    public partial class PersonListForm : Form
    {
        public PersonListForm()
        {
            InitializeComponent();
        }
        //delay function
        async Task PutTaskDelay()
        {
            await Task.Delay(5000);
        }

        DataTable table = new DataTable();
        int indexRow;
        int noOfRows;

        private void PersonListForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Birth Date", typeof(DateTime));
            table.Columns.Add("Department", typeof(string));

            table.Rows.Add(1, "Alina", "01/02/1989", "HR");
            table.Rows.Add(2, "Marian", "10/06/1976", "Dev");
            table.Rows.Add(3, "Ion", "04/09/1991", "QA");
            table.Rows.Add(4, "Alexandra", "07/07/1993", "Dev");

            GridPerson.DataSource = table;

            noOfRows = GridPerson.Rows.Count;

        }



        private async void ProcessButton_Click(object sender, EventArgs e)
        {
            indexRow = GridPerson.CurrentCell.RowIndex;
            DataGridViewRow currentRow = GridPerson.Rows[indexRow];
  
             if(currentRow.Selected)
             {
                 if (indexRow < (noOfRows - 2))
                 {
                    currentRow.DefaultCellStyle.SelectionBackColor = Color.Red;
                    await PutTaskDelay();
                    currentRow.Selected = false;
                    currentRow = GridPerson.Rows[++indexRow];
                    currentRow.Selected = true;
                 }
                 else
                 {
                    if(indexRow == (noOfRows - 2))
                    {
                        await PutTaskDelay();
                        GridPerson.Rows[0].Selected = true;
                        currentRow = GridPerson.Rows[0];
                        currentRow.DefaultCellStyle.SelectionBackColor = Color.Violet;
                    }
                 }
             }
             else
             {
                await PutTaskDelay();
                GridPerson.Rows[0].Selected = true;
                currentRow = GridPerson.Rows[0];
                currentRow.DefaultCellStyle.SelectionBackColor = Color.Blue;
             }
        }

        private void GridPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEdit.Enabled = true;
            txtID.Text = GridPerson.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = GridPerson.CurrentRow.Cells[1].Value.ToString();
            datePicker.Text = GridPerson.CurrentRow.Cells[2].Value.ToString();
            comboDept.Text = GridPerson.CurrentRow.Cells[3].Value.ToString();
        }

        private void GridPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            GridPerson.CurrentRow.Cells[0].Value = txtID.Text;
            GridPerson.CurrentRow.Cells[1].Value = txtName.Text;
            GridPerson.CurrentRow.Cells[2].Value = datePicker.Text;
            GridPerson.CurrentRow.Cells[3].Value = comboDept.Text;
            txtID.Clear();
            txtName.Clear();
            datePicker.ResetText();
            comboDept.ResetText();
            ButtonEdit.Enabled = false;
        }
    }
}
