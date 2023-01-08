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
    public partial class FormBuffer : Form
    {
        FormUtama FormUtamaObject;
        public bool draggable;
        public int mouseX;
        public int mouseY;

        public FormBuffer(FormUtama FormUtamaInitialized)
        {
            InitializeComponent();
            FormUtamaObject = FormUtamaInitialized;
        }

        private void FormBuffer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < FormUtamaObject.legend1.Layers.Count; i++)
            {
                if (!cboInput.Items.Contains(FormUtamaObject.legend1.Layers[i].FileName))
                {
                    cboInput.Items.Add(FormUtamaObject.legend1.Layers[i].FileName);
                }
            }
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string strfileshp = "Durung milih cok!";

            ofd.Title = "Browse Shapefile";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Shapefile (*shpjpg)|*.shp|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if ((ofd.ShowDialog() == DialogResult.OK))
            {
                strfileshp = ofd.FileName;
                if (!cboInput.Items.Contains(strfileshp))
                {
                    cboInput.Items.Add(strfileshp);
                }
                cboInput.Text = strfileshp;
            }
            else
            {
                MessageBox.Show("Durung milih cok!", "Report",
                MessageBoxButtons.OKCancel);
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string stroutputshp = "Durung milih cok!";

            sfd.Title = "Output Shapefile";
            sfd.InitialDirectory = @"D:\";
            sfd.Filter = "Shapefile (*shp)|*.shp|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if ((sfd.ShowDialog() == DialogResult.OK))
            {
                stroutputshp = sfd.FileName;
                txtOutput.Text = stroutputshp;
            }
            else
            {
                MessageBox.Show("Durung milih cok!", "Report",
                MessageBoxButtons.OKCancel);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string inputshapefile = Convert.ToString(cboInput.Text);
            double inputdistance = Convert.ToDouble(txtDistance.Text);
            int inputsegment = Convert.ToInt16(txtSegments.Text);
            bool inputselected = Convert.ToBoolean(cboSelectedOnly.Text);
            bool inputmerge = Convert.ToBoolean(cboMerge.Text);
            bool inputoverwrite = Convert.ToBoolean(checkBoxOverwrite.Checked);
            string outputshapefile = Convert.ToString(txtOutput);

            Shapefile sf = new Shapefile();
            sf.Open(inputshapefile);

            Utils utils = new Utils();
            utils.ConvertDistance(tkUnitsOfMeasure.umMeters, tkUnitsOfMeasure.umDecimalDegrees, ref inputdistance);

            bool bufferprocess = utils.BufferByDistance(sf, inputdistance,
                inputsegment, inputselected, inputmerge,
                outputshapefile, inputoverwrite);

            if (bufferprocess == true)
            {
                this.Hide();
                MessageBox.Show("Selamat, berhasil :)", "Report", MessageBoxButtons.OK);

                Shapefile sfAsetFaskes = new Shapefile();
                sfAsetFaskes.Open(outputshapefile, null);
                int handleBufferResult = FormUtamaObject.legend1.Layers.Add(sfAsetFaskes, true);
                FormUtamaObject.legend1.GetLayer(handleBufferResult).Name = Path.GetFileName(outputshapefile);
                sfAsetFaskes.Identifiable = true;
            }
            else
            {
                this.Hide();
                MessageBox.Show("Coba Lagi, Semoga beruntung :(", "Report",
                MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void FormBuffer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
