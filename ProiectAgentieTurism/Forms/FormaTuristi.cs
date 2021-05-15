using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAgentieTurism.Forms
{
    public partial class FormaTuristi : Form
    {
        List<Turisti> lt;
        public FormaTuristi()
        {
            InitializeComponent();
            if (!File.Exists("FisierTurist.dat"))
            {
                FileStream f = new FileStream("FisierTurist.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Turisti aux = new Turisti();
                aux = (Turisti)bf.Deserialize(f);
                f.Close();
                lt = new List<Turisti>();
                lt.Add(aux);
                AddToRow(aux);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lt == null) { lt = new List<Turisti>(); }
            string nume = txtNume.Text;
            string prenume = txtPren.Text;
            string cnp = txtCNP.Text;
            bool tichete = cbTichete.Checked;
            Turisti t = new Turisti(nume, prenume, cnp,tichete);
            lt.Add(t);
            DataGridViewRow row = (DataGridViewRow)dateTuristi.Rows[0].Clone();
            row.Cells[0].Value = nume;
            row.Cells[1].Value = prenume;
            row.Cells[2].Value = cnp;
            row.Cells[3].Value = tichete;
            dateTuristi.Rows.Add(row);
            FileStream f = new FileStream("FisierTurist.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, t);
            f.Close();
        }

        public void AddToRow(Turisti aux)
        {
            DataGridViewRow row = (DataGridViewRow)dateTuristi.Rows[0].Clone();
            row.Cells[0].Value = aux.Nume;
            row.Cells[1].Value = aux.Prenume;
            row.Cells[2].Value = aux.pCNP;
            row.Cells[3].Value = aux.Tichete;
            dateTuristi.Rows.Add(row);
        }
    }
}
