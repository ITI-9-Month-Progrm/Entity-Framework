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
    public partial class GV_Form : Form

    {
        
       
        public GV_Form()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Context.Dispose();
        }
        PubsContext Context = new PubsContext();

        //select
        private void GV_Form_Load(object sender, EventArgs e)
        {


            Context.titles.Load();
           
            this.dataGridView1.DataSource = Context.titles.Local.ToBindingList();

            dataGridView1.Columns["pub_id"].Visible = false;
            dataGridView1.Columns["Pub"].Visible = false;


        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            Context.SaveChanges();
        }
    }
}
