using BilgeAdam.Business.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Client.Lists
{
    public partial class frmListBooks : Form
    {
        public frmListBooks()
        {
            InitializeComponent();
            Repo = new BookRepository();
            this.FormClosed += FrmListBooks_FormClosed;
        }

        private void FrmListBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Repo.Dispose();
        }

        public BookRepository Repo { get; set; }
        private void frmListBooks_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = Repo.GetAll();
        }
    }
}
