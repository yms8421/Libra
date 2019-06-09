using BilgeAdam.Business.Repositories;
using BilgeAdam.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Client.Cards
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
            Repo = new BookRepository();
        }
        public BookRepository Repo { get; set; }

        private void btnInsOrUpt_Click(object sender, EventArgs e)
        {
            var book = new BookDTO
            {
                Name = txtBookName.Text,
                Code = txtIbsnNo.Text,
                AuthorId = 1//(int)cbAuthor.SelectedValue
            };

            Repo.Add(book);
        }
    }
}
