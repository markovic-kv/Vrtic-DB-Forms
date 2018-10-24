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
    public partial class frmTextSearch : Form
    {
        string choiceGlob;
        string parGlob;
        public frmTextSearch(string choice, string seachPar)
        {
            InitializeComponent();
            choiceGlob = choice;
            parGlob = seachPar;
        }

        private void frmTextSearch_Load(object sender, EventArgs e)
        {
            
            if (choiceGlob == "vaspitac")
            {
                
                List<Teachers> lst = new List<Teachers>();
                TeachersBusiness tb = new TeachersBusiness();
                lst = tb.SearchByText(parGlob);
                dataGrid.DataSource = lst;
                dataGrid.Columns[0].HeaderText = "RB";
                dataGrid.Columns[1].HeaderText = "Ime";
                dataGrid.Columns[2].HeaderText = "Prezime";
                dataGrid.Columns[3].HeaderText = "Jmbg";
                dataGrid.Columns[4].HeaderText = "Pol";
                dataGrid.Columns[5].HeaderText = "Tel";
                dataGrid.Columns[6].HeaderText = "Datum rodjenja";
                dataGrid.Columns[7].HeaderText = "Strucna sprema";
            }
            else if (choiceGlob == "deca")
            {
                List<Children> lst = new List<Children>();
                ChildrenBusiness ch = new ChildrenBusiness();
                lst = ch.TextSearch(parGlob);
                dataGrid.DataSource = lst;
                dataGrid.Columns[0].HeaderText = "RB";
                dataGrid.Columns[1].HeaderText = "Ime";
                dataGrid.Columns[2].HeaderText = "Prezime";
                dataGrid.Columns[3].HeaderText = "Datum rodjenja";
                dataGrid.Columns[4].HeaderText = "Pol";
                dataGrid.Columns[5].HeaderText = "Tel";
                dataGrid.Columns[6].HeaderText = "Broj vaspitaca";
                dataGrid.Columns[7].HeaderText = "Broj sobe";
            }
            else if (choiceGlob == "seminari")
            {
                List<Seminars> lst = new List<Seminars>();
                SeminarsTeachersBusiness stb = new SeminarsTeachersBusiness();
                lst = stb.SearchByText(parGlob);
                dataGrid.DataSource = lst;
                dataGrid.Columns[0].HeaderText = "RB";
                dataGrid.Columns[1].HeaderText = "Datum";
                dataGrid.Columns[2].HeaderText = "Dana";
                dataGrid.Columns[3].HeaderText = "Sati";
                dataGrid.Columns[4].HeaderText = "Bodovi";
                dataGrid.Columns[5].HeaderText = "Tema";
                dataGrid.Columns[6].HeaderText = "Mesto";
                dataGrid.Columns[7].HeaderText = "Broj vaspitaca";
            }
            else if (choiceGlob == "deca izostanci")
            {
                List<ChildrenAbsences> lst = new List<ChildrenAbsences>();
                ChildrenAbsencesBusiness cab = new ChildrenAbsencesBusiness();
                lst = cab.TextSearch(parGlob);
                dataGrid.DataSource = lst;
                dataGrid.Columns[0].HeaderText = "Ime";
                dataGrid.Columns[1].HeaderText = "Prezime";
                dataGrid.Columns[2].HeaderText = "Telefon";
                dataGrid.Columns[3].HeaderText = "Datum rodjenja";
                dataGrid.Columns[4].HeaderText = "Datum pocetka";
                dataGrid.Columns[5].HeaderText = "Datum kraja";
            }
            else if (choiceGlob == "oblasti deca")
            {
                List<SectionsChildren> lst = new List<SectionsChildren>();
                SectionsChildrenBusiness scb = new SectionsChildrenBusiness();
                lst = scb.SectionSearch(parGlob);
                dataGrid.DataSource = lst;
                dataGrid.Columns[0].HeaderText = "Broj deteta";
                dataGrid.Columns[1].HeaderText = "Ime";
                dataGrid.Columns[2].HeaderText = "Prezime";
                dataGrid.Columns[3].HeaderText = "Predmet";
                dataGrid.Columns[4].HeaderText = "Uspeh";
            }
        }
    }
}
