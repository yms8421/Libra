using BilgeAdam.Client.Cards;
using BilgeAdam.Client.Definitions;
using BilgeAdam.Client.Lists;
using BilgeAdam.Entities.Context;
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

namespace BilgeAdam.Client
{
    public partial class frmMain : Form
    {
        //list ile daha iyi olur, çünkü value değerine ihtiyacımız yok
        private Dictionary<string, Form> forms;
        public frmMain()
        {
            forms = new Dictionary<string, Form>();
            InitializeComponent();
            this.FormClosed += FrmMain_FormClosed;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void msbBookList_Click(object sender, EventArgs e)
        {
            Open<frmListBooks>();
        }

        private void tsAuthor_Click(object sender, EventArgs e)
        {
            Open<frmAuthors>();
        }
        
        private void Open<T>() where T : Form
        {
            var typeName = typeof(T).FullName;
            Form f;
            if (forms.ContainsKey(typeName))
            {
                return;
            }
            else
            {
                f = Activator.CreateInstance<T>();
                forms.Add(typeName, f);
            }
            
            f.MdiParent = this;
            f.FormClosed += ChildFormClosed;
            f.Show();
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            var typeName = sender.GetType().FullName;
            if (forms.ContainsKey(typeName))
            {
                forms.Remove(typeName);
            }

            //dictionary'den formu sildiğimiz için tekrar açmak için satır 58'deki instance alma işlemi
            //yeniden çalışacaktır. Daha önce zaten instance'ı alınmış bir formun tekrar instance'ını almadan
            //dolayısı ile bu method çalışırken dictionary'den "silmeden"; daha önce alınmış instance'ı çağırınız 
        }

        private void tsBookCard_Click(object sender, EventArgs e)
        {
            Open<frmBooks>();
        }
    }
}
