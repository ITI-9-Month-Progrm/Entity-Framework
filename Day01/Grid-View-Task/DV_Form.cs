using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grid_View_Task.Context;
using Grid_View_Task.Entities;
using Microsoft.EntityFrameworkCore;

namespace Grid_View_Task
{
    public partial class DV_Form : Form
    {
        public DV_Form()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Context.Dispose();
        }
        PubsContext Context = new PubsContext();
        BindingSource BS;
        BindingNavigator BindNav;
        private void DV_Form_Load(object sender, EventArgs e)
        {
            Context.titles.Load();
            var Result = Context.titles.Local.ToBindingList();
            BS = new BindingSource(Result,"");
            BindNav = new BindingNavigator(true); //addStandardItems
            this.Controls.Add(BindNav);
            BindNav.Dock = DockStyle.Top;
            BindNav.BindingSource = BS;
            //Binding El Data
            
            BindingSource BS2 = new BindingSource();
            BS2.AddingNew += (sender, e) => BS2.AddNew();

            txtID.DataBindings.Add("Text", BS, "title_id");
            txtTitle.DataBindings.Add("Text", BS, "title1");
            txtType.DataBindings.Add("Text", BS, "type");
           // txtPubName.DataBindings.Add("Text", BS, "pub_name");
            txtPrice.DataBindings.Add("Text", BS, "price");
            txtAdv.DataBindings.Add("Text", BS, "advance");
            txtRoy.DataBindings.Add("Text", BS, "royalty");
            txtSales.DataBindings.Add("Text", BS, "ytd_sales");
            txtNote.DataBindings.Add("Text", BS, "notes");
            txtDate.DataBindings.Add("Text", BS, "pubdate");


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Context.SaveChanges();
        }
    }
}
