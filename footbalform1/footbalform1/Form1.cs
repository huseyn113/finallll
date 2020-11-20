using footbalform1.mode1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace footbalform1
{
    public partial class Form1 : Form
    {
        formfinal5Entities db = new formfinal5Entities();


        public void fillmey()
        {
            cmbmeydanca.Items.AddRange(db.Meydanca00.Select(x => x.Name).ToArray());
        }



        public void fillotaq()
        {
            cmbotaq.Items.AddRange(db.Meydanca00.Select(x => x.Otaqlar).ToArray());
        }


        public Form1()
        {
            InitializeComponent();
        }


        public void filldatagrid()
        {
            datagrid.DataSource = db.Umumi00.Select(x => new
            {
                x.ID,
                Meydanca = x.Meydanca00.Name,
                Musteriadi = x.Musteriadi,
                x.Musterinomresi,
                x.Qiymetler,
                x.Necenefer,
                x.tarix

            }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldatagrid();
            fillmey();
            fillotaq();
        }




        private void btnrezerv_Click(object sender, EventArgs e)
        {



            Umumi00 tezeumumi = new Umumi00();


            tezeumumi.Musteriadi = txtadi.Text;
            tezeumumi.Musterinomresi = Convert.ToInt32(txtnomre.Text);



            tezeumumi.Qiymetler = Convert.ToInt32(numqiymet.Text);
            tezeumumi.Necenefer = Convert.ToInt32(nmnefer.Text);
            tezeumumi.tarix = (datetarix.Value);

            db.Umumi00.Add(tezeumumi);
            db.SaveChanges();

            MessageBox.Show("rezerv olundu");







           
        }
    }
}
