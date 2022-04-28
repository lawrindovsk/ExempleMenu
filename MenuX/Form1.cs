using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuX
{
    public partial class Menusx : Form
    {
        Register reg;
        Consult csn;
        Update upd;
        Delete del;
        public Menusx()
        {
            InitializeComponent();

            reg = new Register();
            csn = new Consult();
            upd = new Update();
            del = new Delete();
        }
        private void Menusx_Load(object sender, EventArgs e)
        {
        }//End Menusx.
        private void register_Click(object sender, EventArgs e)
        {
            Visible = false;
            reg.ShowDialog(); //mostrar a tela ao ser chamada
            Visible = true;
        }//End register button.
        private void consult_Click(object sender, EventArgs e)
        {
            Visible = false;
            csn.ShowDialog(); //mostrar a tela ao ser chamada
            Visible = true;
        }//End consult button.

        private void update_Click(object sender, EventArgs e)
        {
            Visible = false;
            upd.ShowDialog(); //mostrar a tela ao ser chamada
            Visible = true;
        }//End update button.

        private void delete_Click(object sender, EventArgs e)
        {
            Visible = false;
            del.ShowDialog(); //mostrar a tela ao ser chamada
            Visible = true;

        }//End delete button.

    }//End Class
}//End Project.
