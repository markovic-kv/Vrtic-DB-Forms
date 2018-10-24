using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmTwoParameterView : Form
    {
        string choiceGlob;
        string lowGlob;
        string highGlob;
        public frmTwoParameterView(string choice, string low, string high)
        {
            InitializeComponent();
            choiceGlob = choice;
            lowGlob = low;
            highGlob = high;
        }

        private void TwoParameterView_Load(object sender, EventArgs e)
        {
            if (choiceGlob == "bodovi seminari")
            {
                try
                {
                    SeminarsTeachersBusiness stb = new SeminarsTeachersBusiness();
                    List<SeminarsTeachers> lst = stb.SeminarsTeachersForPoints(int.Parse(lowGlob), int.Parse(highGlob));
                    if (int.Parse(lowGlob) > int.Parse(highGlob))
                    {
                        MessageBox.Show("Neispravno unet interval");
                        this.Close();
                    }
                    dataGrid.DataSource = lst;
                    dataGrid.Columns[0].HeaderText = "Datum";
                    dataGrid.Columns[1].HeaderText = "Dana";
                    dataGrid.Columns[2].HeaderText = "Sati";
                    dataGrid.Columns[3].HeaderText = "Poena";
                    dataGrid.Columns[4].HeaderText = "Tema";
                    dataGrid.Columns[5].HeaderText = "Mesto";
                    dataGrid.Columns[6].HeaderText = "Broj vaspitaca";
                    dataGrid.Columns[7].HeaderText = "Ime vaspitaca";
                    dataGrid.Columns[8].HeaderText = "Prezime vaspitaca";
                }
                catch (Exception ex) { MessageBox.Show("Greska u unosu " + ex.Message); this.Close(); }
            }
            else if (choiceGlob == "deca rodjena")
            {
                ChildrenBusiness cb = new ChildrenBusiness();
                List<Children> lstd = new List<Children>();
                try
                {
                    lstd = cb.ChildrenBornOnDate(lowGlob, highGlob);
                    dataGrid.DataSource = lstd;
                    dataGrid.Columns[0].HeaderText = "RB";
                    dataGrid.Columns[1].HeaderText = "Ime";
                    dataGrid.Columns[2].HeaderText = "Prezime";
                    dataGrid.Columns[3].HeaderText = "Datum rodjenja";
                    dataGrid.Columns[4].HeaderText = "Pol";
                    dataGrid.Columns[5].HeaderText = "Telefon";
                    dataGrid.Columns[6].HeaderText = "Broj vaspitaca";
                    dataGrid.Columns[7].HeaderText = "Broj sobe";
                    
                }
                catch (Exception ex) { MessageBox.Show("Neispravan unos " + ex.Message); this.Close(); }
            }
            else if (choiceGlob == "deca izostanci")
            {
                ChildrenAbsencesBusiness db = new ChildrenAbsencesBusiness();
                List<ChildrenAbsences> lstd = new List<ChildrenAbsences>();
                try
                {
                    lstd = db.ChildrenByAbsence(lowGlob, highGlob);
                    dataGrid.DataSource = lstd;
                    dataGrid.Columns[0].HeaderText = "Ime";
                    dataGrid.Columns[1].HeaderText = "Prezime";
                    dataGrid.Columns[2].HeaderText = "Telefon";
                    dataGrid.Columns[3].HeaderText = "Datum rodjenja";
                    dataGrid.Columns[4].HeaderText = "Datum pocetka";
                    dataGrid.Columns[5].HeaderText = "Datum kraja";
                }
                catch (Exception ex) { MessageBox.Show("Neispravan unos " + ex.Message); this.Close(); }
            }
        }
    }
}
