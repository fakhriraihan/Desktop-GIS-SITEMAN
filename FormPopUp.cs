using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AxMapWinGIS;
using MapWinGIS;
using Microsoft.VisualBasic;

namespace SI_TEMAN2
{
    public partial class FormPopUp : Form
    {
        FormUtama FormUtamaObject;
        public bool draggable;
        public int mouseX;
        public int mouseY;

        public FormPopUp(FormUtama FormUtamaInitialized)
        {
            InitializeComponent();
            FormUtamaObject = FormUtamaInitialized;
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (cmdEdit.Text == "Edit")
            {
                string input = Interaction.InputBox(
                    "Silahkan masukkan password anda ...", "Password", "", -1, -1);
                if (input == "fakhri")
                {
                    cboKategori.Enabled = true;
                    cmdBrowse.Enabled = true;
                    cmdHapus.Visible = true;
                    cmdEdit.Text = "Save";
                }
                else
                {
                    cboKategori.Enabled = false;
                    cmdBrowse.Enabled = false;
                    cmdHapus.Visible = false;
                    cmdEdit.Text = "Edit";
                    MessageBox.Show("Password anda salah :(");
                }
            }
            else if (cmdEdit.Text == "Save")
            {
                Shapefile sf = FormUtamaObject.axMap1.get_Shapefile(FormUtamaObject.handleAsetFaskes);

                sf.StartEditingTable();
                sf.EditCellValue(sf.Table.get_FieldIndexByName("Jenis"),
                    Convert.ToInt32(txtIndex.Text), cboKategori.Text);
                sf.EditCellValue(sf.Table.get_FieldIndexByName("Pictures"),
                    Convert.ToInt32(txtIndex.Text), txtFoto.Text);
                sf.StopEditingTable();
                sf.Save();

                cmdEdit.Text = "Edit";
                cboKategori.Enabled = false;
                cmdBrowse.Enabled = false;
                FormUtamaObject.axMap1.Redraw2(tkRedrawType.RedrawAll);
                FormUtamaObject.axMap1.Refresh();
                this.Hide();
                MessageBox.Show("Data sudah tersimpan :)");
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Browse Photo";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "JPG (*.jpg)|*.jpg|JPEG (*.jpeg|PNG (*.png)|*.png|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if ((ofd.ShowDialog() == DialogResult.OK))
            {
                string fileName = @Path.GetFileName(ofd.FileName);
                string sourcePath = @Path.GetDirectoryName(ofd.FileName);
                string targetPath = @Path.Combine(FormUtama.strFilePath, "Resource/Non-Spatial/Foto");
                string sourceFile = @Path.Combine(sourcePath, fileName);
                string destFile = @Path.Combine(targetPath, fileName);
                File.Copy(sourceFile, destFile, true);
                txtFoto.Text = fileName;
                pictureBox1.ImageLocation = destFile;
            }
            else
            {
                MessageBox.Show("Foto Belum Dipilih :(", "Report", MessageBoxButtons.OK);
            }
        }

        private void cmdHapus_Click(object sender, EventArgs e)
        {
            Shapefile sf = FormUtamaObject.axMap1.get_Shapefile(FormUtamaObject.handleAsetFaskes);

            sf.StartEditingShapes();
            if (!sf.EditDeleteShape(Convert.ToInt32(txtIndex)))
            {
                MessageBox.Show("Datane rung kehapus. Error: " + sf.ErrorMsg[sf.LastErrorCode]);
            }
            else
            {
                MessageBox.Show("Datane wes kehapus. Index = " + Convert.ToInt32(txtIndex.Text));
                FormUtamaObject.axMap1.Redraw2(tkRedrawType.RedrawAll);
                FormUtamaObject.axMap1.Refresh();
            }
            sf.Save();
            sf.StopEditingShapes();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shapefile sf = FormUtamaObject.axMap1.get_Shapefile(FormUtamaObject.handleAsetFaskes);
            sf.SelectNone();
        }

        private void FormPopUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Shapefile sf = FormUtamaObject.axMap1.get_Shapefile(FormUtamaObject.handleAsetFaskes);
            sf.SelectNone();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                mouseX = MousePosition.X - 400;
                mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }
    }
}
