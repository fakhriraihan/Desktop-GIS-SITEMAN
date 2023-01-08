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

namespace SI_TEMAN2
{
    public partial class FormAddPoint : Form
    {
        FormUtama FormUtamaObject;
        public bool draggable;
        public int mouseX;
        public int mouseY;

        public FormAddPoint(FormUtama FormUtamaInitialized)
        {
            InitializeComponent();
            FormUtamaObject = FormUtamaInitialized;
        }

        private void RadioButton_Digitasi_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Digitasi.Checked == true)
            {
                FormUtamaObject.btnNormal.PerformClick();
                FormUtamaObject.axMap1.MapCursor = tkCursor.crsrCross;
                txtX.Enabled = false;
                txtY.Enabled = false;
            }
            else
            {
                FormUtamaObject.axMap1.MapCursor = tkCursor.crsrMapDefault;
                FormUtamaObject.btnNormal.PerformClick();
                txtX.Enabled = true;
                txtY.Enabled = true;
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Browse Photo";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if ((ofd.ShowDialog() == DialogResult.OK))
            {
                string fileName = @Path.GetFileName(ofd.FileName);
                string sourcePath = @Path.GetDirectoryName(ofd.FileName);
                string targetPath = @Path.Combine(FormUtama.strFilePath, "Database/Non-Spatial/Foto");
                string sourceFile = @Path.Combine(sourcePath, fileName);
                string destFile = @Path.Combine(targetPath, fileName);
                File.Copy(sourceFile, destFile, true);
                txtFoto.Text = fileName;
                pictureBox1.ImageLocation = destFile;
            }
            else
            {
                MessageBox.Show("Anda belum memilih foto :(", "Report", MessageBoxButtons.OK);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Shapefile sf = FormUtamaObject.axMap1.get_Shapefile(FormUtamaObject.handleAsetFaskes);
            bool result = sf.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            var myPoint = new MapWinGIS.Point();
            myPoint.x = Convert.ToDouble(txtX.Text);
            myPoint.y = Convert.ToDouble(txtY.Text);

            MessageBox.Show(sf.ShapefileType.ToString());
            Shape myShape = new Shape();
            myShape.Create(ShpfileType.SHP_POINT);
            int myPointIndex = 0;
            myShape.InsertPoint(myPoint, ref myPointIndex);
            int myShapeIndex = 0;

            sf.StartEditingShapes();
            if (sf.EditInsertShape(myShape, ref myShapeIndex))
            {
                sf.Save();
                sf.StartEditingTable();
                sf.EditCellValue(sf.Table.get_FieldIndexByName("Nama Aset"),
                    myShapeIndex, txtNamaAset.Text);
                sf.EditCellValue(sf.Table.get_FieldIndexByName("Kategori"),
                    myShapeIndex, cboKategori.Text);
                sf.EditCellValue(sf.Table.get_FieldIndexByName("Sumber"),
                    myShapeIndex, txtSumber.Text);
                sf.EditCellValue(sf.Table.get_FieldIndexByName("Foto"),
                    myShapeIndex, txtFoto.Text);
                sf.Save();
                sf.StopEditingTable();
            }
            else
            {
                MessageBox.Show(sf.ErrorMsg[sf.LastErrorCode].ToString());
            }
            sf.Save();
            sf.StopEditingShapes();

            FormUtamaObject.axMap1.RemoveLayer(FormUtamaObject.handleAsetFaskes);
            FormUtamaObject.axMap1.Redraw();
            FormUtamaObject.axMap1.Redraw2(tkRedrawType.RedrawAll);
            FormUtamaObject.axMap1.Redraw3(tkRedrawType.RedrawSkipDataLayers, true);
            FormUtamaObject.axMap1.Refresh();
            FormUtamaObject.legend1.Layers.Remove(FormUtamaObject.handleAsetFaskes);
            FormUtamaObject.legend1.RedrawLegendAndMap();
            FormUtamaObject.legend1.Refresh();
            FormUtamaObject.Refresh();

            FormUtamaObject.loadAsetFaskes();
            FormUtamaObject.axMap1.Redraw();
            FormUtamaObject.axMap1.Redraw2(tkRedrawType.RedrawAll);
            FormUtamaObject.axMap1.Redraw3(tkRedrawType.RedrawSkipDataLayers, true);
            FormUtamaObject.axMap1.Refresh();
            FormUtamaObject.legend1.RedrawLegendAndMap();
            FormUtamaObject.legend1.Refresh();
            FormUtamaObject.Refresh();

            this.Hide();
            MessageBox.Show("Datane wes kesimpen");
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormAddPoint_Load(object sender, EventArgs e)
        {
            RadioButton_Digitasi.Checked = true;
            txtX.Text = "";
            txtY.Text = "";
            txtNamaAset.Text = "";
            cboKategori.Text = "";
            txtSumber.Text = "";
            txtFoto.Text = "";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = null;
        }

        private void FormAddPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
            RadioButton_Digitasi.Checked = true;
            txtX.Text = "";
            txtY.Text = "";
            txtNamaAset.Text = "";
            cboKategori.Text = "";
            txtSumber.Text = "";
            txtFoto.Text = "";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = null;
            FormUtamaObject.axMap1.MapCursor = tkCursor.crsrMapDefault;
            FormUtamaObject.btnNormal.PerformClick();
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
