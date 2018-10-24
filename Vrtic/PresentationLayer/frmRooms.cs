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
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            RoomsBusiness sb = new RoomsBusiness();
            List<Rooms> lstRooms = new List<Rooms>();
            lstRooms = sb.AllRooms();
            cmbRoomNumber.Items.Clear();
            foreach (var v in lstRooms)
            {
                cmbRoomNumber.Items.Add(v.GetSetRoomNum);
            }
        }

        private void cmbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RoomsBusiness sb = new RoomsBusiness();
                Rooms s = new Rooms();
                s = sb.RoomByRoomNumber(int.Parse(cmbRoomNumber.Text));
                txtSize.Text = s.GetSetSize;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                RoomsBusiness sb = new RoomsBusiness();
                bool roomExists = sb.RoomExists(int.Parse(cmbRoomNumber.Text));
                if (roomExists || cmbRoomNumber.Text == null || cmbRoomNumber.Text == "")
                {
                    MessageBox.Show("Postoji soba sa ovim brojem");
                }
                else
                {
                    Rooms s = new Rooms();
                    s.GetSetRoomNum = int.Parse(cmbRoomNumber.Text);
                    s.GetSetSize = txtSize.Text;
                    lblMsg.Text = sb.InsertRoom(s);                   
                    cmbRoomNumber.Items.Add(s.GetSetRoomNum);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                RoomsBusiness rb = new RoomsBusiness();
                Rooms s = new Rooms();
                s.GetSetRoomNum = int.Parse(cmbRoomNumber.Text);
                s.GetSetSize = txtSize.Text;
                lblMsg.Text = rb.UpdateRoom(s);
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
                RoomsBusiness s = new RoomsBusiness();
                lblMsg.Text = s.DeleteRoom(int.Parse(cmbRoomNumber.Text));
                cmbRoomNumber.Items.Remove(cmbRoomNumber.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
