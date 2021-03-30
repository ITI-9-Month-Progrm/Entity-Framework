using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using LandingPage.Entity;

namespace LandingPage
{
    public partial class DV_Form : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=.; Initial Catalog=pubs;Integrated Security=true");
       
        BindingSource titleBS;
        BindingNavigator BindNav;
        public DV_Form()
        {
            InitializeComponent();
        }

        private void DV_Form_Load(object sender, EventArgs e)
        {
            #region Selection
            var Titel_Result = sqlCon.Query<Title>("Exec ShowData");
            titleBS = new BindingSource(Titel_Result, "");

            titleID.DataBindings.Add("Text", titleBS, "title_id", true);
            title.DataBindings.Add("Text", titleBS, "title", true);
            type.DataBindings.Add("Text", titleBS, "type", true);
           
            price.DataBindings.Add("Text", titleBS, "price", true);
            advance.DataBindings.Add("Text", titleBS, "advance", true);
            royal.DataBindings.Add("Value", titleBS, "royalty", true);
            sales.DataBindings.Add("Value", titleBS, "ytd_sales", true);
            notes.DataBindings.Add("Text", titleBS, "notes", true);
            date.DataBindings.Add("Value", titleBS, "pubdate", true);

            BindNav = new BindingNavigator(true);
            this.Controls.Add(BindNav);
            BindNav.Dock = DockStyle.Top;
            BindNav.BindingSource = titleBS;
            #endregion
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            this.Hide();
            landingPage.Show();
            
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            #region Insertion
            sqlCon.Execute("Exec InsertNewTitle @ID, @TITILE, @TYPE", new { ID = titleID.Text, TITILE = title.Text, TYPE = type.Text });
            MessageBox.Show("Insertion Done");
            #endregion
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Updating
            sqlCon.Execute("Exec UpdateTitleById @ID, @TITILE, @TYPE", new { ID = titleID.Text, TITILE = title.Text, TYPE = type.Text });
            MessageBox.Show("Updating Done");
            #endregion
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            #region Deleting
            sqlCon.Execute("Exec DeleteTitleById @ID", new { ID = titleID.Text });
            MessageBox.Show("Deletings Done");
            #endregion
        }
    }
}
