using BusinessLayer;
using DataLayer;
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
    public partial class frmSections : Form
    {
        public frmSections()
        {
            InitializeComponent();
        }

        private void frmSections_Load(object sender, EventArgs e)
        {
            //boacenje boxa oblasti
            cmbSectionNumber.Items.Clear();
            SectionsChildrenBusiness scb = new SectionsChildrenBusiness();
            List<Sections> lstSection = new List<Sections>();
            lstSection = scb.SectionsSortedByKey();
            foreach (var v in lstSection) { cmbSectionNumber.Items.Add(v.GetSetIdSec); }
            //bogacenjek boxa deteta
            ChildrenBusiness cb = new ChildrenBusiness();
            List<Children> lstChildren = new List<Children>();
            lstChildren = cb.AllChildrenSortedByKey();
            cmbChildNumber.Items.Clear();
            foreach (var v in lstChildren) { cmbChildNumber.Items.Add(v.GetSetIdC); }
            //kombo box predmet
            cmbSubject.Items.Clear();
            cmbSubject.Items.Add("uvod u znakove"); cmbSubject.Items.Add("matematika"); cmbSubject.Items.Add("crtanje"); cmbSubject.Items.Add("izgovor");
            cmbSubject.Items.Add("komunikacija"); cmbSubject.Items.Add("priroda"); cmbSubject.Items.Add("znakovi"); cmbSubject.Items.Add("motorika");
            //uspeh kombo
            cmbGrade.Items.Clear();
            cmbGrade.Items.Add("zadovoljavajuce");
            cmbGrade.Items.Add("prosao"); cmbGrade.Items.Add("napredno znanje"); cmbGrade.Items.Add("potrebna pomoc");

        }

        private void cmbSectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionsChildrenBusiness scb = new SectionsChildrenBusiness();
            Sections sec = new Sections();
            sec = scb.SectionSearchByKey(int.Parse(cmbSectionNumber.Text));
            cmbChildNumber.Text = sec.GetSetIdChild.ToString();
            cmbSubject.Text = sec.GetSetSubject;
            cmbGrade.Text = sec.GetSetGrade;
        }

        private void cmbChildNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChildrenBusiness cb = new ChildrenBusiness();
            Children ch = new Children();
            ch = cb.SearchChildrenByKey(int.Parse(cmbChildNumber.Text));
            txtChildSurname.Text = ch.GetSetSurname;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Sections sec = new Sections();
                SectionsChildrenBusiness scb = new SectionsChildrenBusiness();

                sec.GetSetIdChild = int.Parse(cmbChildNumber.Text);
                sec.GetSetSubject = cmbSubject.Text;
                sec.GetSetGrade = cmbGrade.Text;
                lblMsg.Text = scb.InsertSections(sec);
                List<Sections> lst = new List<Sections>();
                SectionsRepository sr = new SectionsRepository();
                lst = sr.GetAllSections();
                var lstVar = from d in lst where d.GetSetIdChild == int.Parse(cmbChildNumber.Text) && d.GetSetSubject == cmbSubject.Text select d;
                foreach (var v in lstVar)
                    cmbSectionNumber.Items.Add(v.GetSetIdSec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Sections sec = new Sections();
                SectionsChildrenBusiness scb = new SectionsChildrenBusiness();
                sec.GetSetIdSec = int.Parse(cmbSectionNumber.Text);
                sec.GetSetIdChild = int.Parse(cmbChildNumber.Text);
                sec.GetSetSubject = cmbSubject.Text;
                sec.GetSetGrade = cmbGrade.Text;
                lblMsg.Text = scb.UpdateSection(sec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SectionsChildrenBusiness scb = new SectionsChildrenBusiness();
                lblMsg.Text = scb.DeleteSection(int.Parse(cmbSectionNumber.Text));
                cmbSectionNumber.Items.Remove(cmbSectionNumber.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
