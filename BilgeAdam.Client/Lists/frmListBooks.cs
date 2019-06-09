using BilgeAdam.Business.Repositories;
using BilgeAdam.Entities.Models;
using BilgeAdam.Enums;
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
            RepoAuthor = new AuthorRepository();
            this.FormClosed += FrmListBooks_FormClosed;
        }

        private void FrmListBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Repo.Dispose();
        }

        public BookRepository Repo { get; set; }
        public AuthorRepository RepoAuthor { get; set; }
        private void frmListBooks_Load(object sender, EventArgs e)
        {

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = Repo.GetAllParametre(test());
            cbAuthor.DataSource = RepoAuthor.GetCombobox();
            cbCategory.DataSource = Enum.GetValues(typeof(BookCategory));
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            dgv.DataSource = Repo.GetAllParametre(test());
        }

        private object  test()
        {
            
            return txtBookName.Text;
        }
    }
}
