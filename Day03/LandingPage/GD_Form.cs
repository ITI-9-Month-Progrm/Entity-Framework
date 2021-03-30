using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using LandingPage.Entity;

namespace LandingPage

{

    public partial class GD_Form : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=.; Initial Catalog=pubs;Integrated Security=true");
        BindingSource TitleBS;
        string id, title, type;
       
        public GD_Form()
        {
            InitializeComponent();
        }


        private void GD_Form_Load(object sender, EventArgs e)
        {
            #region Selection
            var Title_Result = sqlCon.Query<Title>("Exec ShowData");
            TitleBS = new BindingSource(Title_Result, "");
            dgv1.DataSource = TitleBS;
            dgv1.Columns["pub_id"].Visible = false;
            #endregion

        }
        #region Deleting
        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
            
        }

        private void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Recorde", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sqlCon.Execute("Exec DeleteTitleById @ID", new { ID = id });
                    MessageBox.Show("Deleted ");
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow currentRow = dgv1.CurrentRow;
                id = currentRow.Cells[0].Value.ToString();
                title = currentRow.Cells[1].Value.ToString();
                type = currentRow.Cells[2].Value.ToString();
                if(id.Length <=6 && title.Length <= 80 && type.Length <= 12)
                {
                    sqlCon.Execute("Exec InsertNewTitle @ID, @TITILE, @TYPE", new { ID = id, TITILE = title, TYPE = type });
                    MessageBox.Show("Insertion Done");
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Data ");
                }
            }


        }
        #endregion
        #region Updating
        private void dgv1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
          
            DataGridViewRow currentRow = dgv1.CurrentRow;
            id = currentRow.Cells[0].Value.ToString();
            title = currentRow.Cells[1].Value.ToString();
            type = currentRow.Cells[2].Value.ToString();
            if (title.Length <= 80 && type.Length <= 12)
            {
                if (currentRow != null)
                {
                    sqlCon.Execute("Exec UpdateTitleById @ID, @TITILE, @TYPE", new { ID = id, TITILE = title, TYPE = type });
                    MessageBox.Show("Updating Done");
                }
                else
                {


                }

            }
            else
            {
                MessageBox.Show("Please Enter Valid Data");
            }
        }

        #endregion
        #region Insertion
        /*  private void dgv1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
          {

              DataGridViewRow currentRow = dgv1.CurrentRow;
              id = currentRow.Cells[0].Value.ToString();
              title = currentRow.Cells[1].Value.ToString();
              type = currentRow.Cells[2].Value.ToString();
              if (id.Length<=6 && title.Length <= 80 && type.Length <= 12)
              {
                  sqlCon.Execute("Exec InsertNewTitle @ID, @TITILE, @TYPE", new { ID = id, TITILE = title, TYPE = type });
                      MessageBox.Show("Insertion Done");

              }
              else
              {
                  MessageBox.Show("Please Enter Valid Data");
              }
          }*/
        #endregion


    }
}
