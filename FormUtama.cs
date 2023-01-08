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
    public partial class FormUtama : Form
    {
        public static string strAppPath = "";
        public static string strFilePath = "";
        public int handleBatasDesa;
        public int handleAsetFaskes;
        public FormPopUp FormPopUpObject = null;
        public FormAddPoint FormAddPointObject = null;
        public FormBuffer FormBufferObject = null;
        public bool draggable;
        public int mouseX;
        public int mouseY;

        public FormUtama()
        {
            InitializeComponent();
            strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            strFilePath = Path.Combine(strAppPath, "Resources");
            legend1.Map = (MapWinGIS.Map)axMap1.GetOcx();
            axMap1.SendMouseMove = true;
            axMap1.SendMouseDown = true;
            axMap1.SendMouseUp = true;
            axMap1.MapCursor = tkCursor.crsrMapDefault;
            btnIdentify.PerformClick();
            FormPopUpObject = new FormPopUp(this);
            FormAddPointObject = new FormAddPoint(this);
            FormBufferObject = new FormBuffer(this);
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(panel7, true);

            var utils = new Utils();

            //LAYER BATAS DESA

            string shpBatasDesa = Path.Combine(strFilePath, "Database/Spatial/Desa_Admin.shp");
            MapWinGIS.Shapefile sfBatasDesa = new MapWinGIS.Shapefile();
            sfBatasDesa.Open(shpBatasDesa, null);
            handleBatasDesa = legend1.Layers.Add(sfBatasDesa, true);
            legend1.GetLayer(handleBatasDesa).Name = "Batas Administrasi";

            //SIMBOLISASI BATAS DESA
            int fidBatasDesa = sfBatasDesa.Table.get_FieldIndexByName("Desa");
            sfBatasDesa.Categories.Generate(fidBatasDesa, tkClassificationType.ctUniqueValues, 0);
            ColorScheme schemeBatasDesa = new ColorScheme();
            //sfBatasDesa.Categories.ApplyColorScheme(tkColorSchemeType.ctSchemeGraduated, schemeBatasDesa);
            schemeBatasDesa.SetColors2(tkMapColor.OrangeRed, tkMapColor.LightGoldenrodYellow);
            sfBatasDesa.Categories.ApplyColorScheme3(tkColorSchemeType.ctSchemeGraduated,
                schemeBatasDesa, tkShapeElements.shElementFill, 0, Convert.ToInt32(sfBatasDesa.Categories.Count / 2));

            schemeBatasDesa.SetColors2(tkMapColor.ForestGreen, tkMapColor.PowderBlue);
            sfBatasDesa.Categories.ApplyColorScheme3(tkColorSchemeType.ctSchemeGraduated,
                schemeBatasDesa, tkShapeElements.shElementFill, (Convert.ToInt32(sfBatasDesa.Categories.Count / 2) + 1),
                (sfBatasDesa.Categories.Count - 1));
            axMap1.Redraw();

            //--------------------
            //LAYER JARINGAN JALAN
            string shpJalan = Path.Combine(strFilePath, "Database/Spatial/Jalanan.shp");
            MapWinGIS.Shapefile sfJalan = new MapWinGIS.Shapefile();
            sfJalan.Open(shpJalan, null);
            int handleJalan = legend1.Layers.Add(sfJalan, true);
            legend1.GetLayer(handleJalan).Name = "Jaringan Jalan";

            //SIMBOLISASI JARINGANJALAN
            LinePattern patternArteri = new LinePattern();
            patternArteri.AddLine(utils.ColorByName(tkMapColor.DarkRed), 3.0f, tkDashStyle.dsSolid);
            ShapefileCategory ctArteri = sfJalan.Categories.Add("Jalan Arteri");
            ctArteri.Expression = "[Jalan] = \"Jalan Arteri\"";
            ctArteri.DrawingOptions.LinePattern = patternArteri;
            ctArteri.DrawingOptions.UseLinePattern = true;

            LinePattern patternKolektor = new LinePattern();
            patternKolektor.AddLine(utils.ColorByName(tkMapColor.Red), 2.0f, tkDashStyle.dsSolid);
            ShapefileCategory ctKolektor = sfJalan.Categories.Add("Jalan Kolektor");
            ctKolektor.Expression = "[Jalan] = \"Jalan Kolektor\"";
            ctKolektor.DrawingOptions.LinePattern = patternKolektor;
            ctKolektor.DrawingOptions.UseLinePattern = true;

            LinePattern patternLokal = new LinePattern();
            patternLokal.AddLine(utils.ColorByName(tkMapColor.DeepPink), 1.5f, tkDashStyle.dsSolid);
            ShapefileCategory ctLokal = sfJalan.Categories.Add("Jalan Lokal");
            ctLokal.Expression = "[Jalan] = \"Jalan Lokal\"";
            ctLokal.DrawingOptions.LinePattern = patternLokal;
            ctLokal.DrawingOptions.UseLinePattern = true;

            LinePattern patternLain = new LinePattern();
            patternLain.AddLine(utils.ColorByName(tkMapColor.Pink), 1.0f, tkDashStyle.dsSolid);
            ShapefileCategory ctLain = sfJalan.Categories.Add("Jalan Lain");
            ctLain.Expression = "[Jalan] = \"Jalan Lain\"";
            ctLain.DrawingOptions.LinePattern = patternLain;
            ctLain.DrawingOptions.UseLinePattern = true;

            LinePattern patternSetapak = new LinePattern();
            patternSetapak.AddLine(utils.ColorByName(tkMapColor.DarkOrange), 0.5f, tkDashStyle.dsSolid);
            ShapefileCategory ctSetapak = sfJalan.Categories.Add("Jalan Setapak");
            ctSetapak.Expression = "[Jalan] = \"Jalan Setapak\"";
            ctSetapak.DrawingOptions.LinePattern = patternSetapak;
            ctSetapak.DrawingOptions.UseLinePattern = true;

            sfJalan.DefaultDrawingOptions.Visible = false;    //Hide all the unclassified points
            sfJalan.Categories.ApplyExpressions();
            axMap1.Redraw();

            //----------------------
            //LAYER ASET FASKES
            loadAsetFaskes();
        }

        //---------------------
        //BASEMAP
        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.ProviderNone;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonOCM_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenCycleMap;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonBingMaps_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.BingMaps;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonBingHybrid_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.BingHybrid;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonGoogleSatellite_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.BingSatellite;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonGoogleTerrain_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.GoogleTerrain;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonOSM_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonOTM_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenTransportMap;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonBingSatellite_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.BingSatellite;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonGMaps_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.GoogleMaps;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonGHybrid_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.GoogleHybrid;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        private void radioButtonMapQuestAerial_CheckedChanged(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.MapQuestAerial;
            axMap1.Redraw();
            axMap1.Refresh();
        }

        //-------------------------
        //TOOL MODE
        private void btnNormal_Click(object sender, EventArgs e)
        {
            axMap1.MapCursor = tkCursor.crsrMapDefault;
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            axMap1.MapCursor = tkCursor.crsrHand;
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            axMap1.MapCursor = tkCursor.crsrMapDefault;
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            axMap1.MapCursor = tkCursor.crsrMapDefault;
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void btnZoomToExtent_Click(object sender, EventArgs e)
        {
            axMap1.ZoomToMaxExtents();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            axMap1.MapCursor = tkCursor.crsrHelp;
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            axMap1.MapCursor = tkCursor.crsrMapDefault;
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap1.Measuring.MeasuringType = tkMeasuringType.MeasureDistance;
        }

        private void btnLengthArea_Click(object sender, EventArgs e)
        {
            axMap1.MapCursor = tkCursor.crsrMapDefault;
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap1.Measuring.MeasuringType = tkMeasuringType.MeasureArea;
        }

        //--------------------
        //DATA
        private void btnAddData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string strfileshp = "Durung milih shapefile cok!";

            ofd.Title = "Browse Shapefile";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Shapefile (*.shp)|*.shp|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if ((ofd.ShowDialog() == DialogResult.OK))
            {
                strfileshp = ofd.FileName;

                MapWinGIS.Shapefile sfAsetFaskes = new MapWinGIS.Shapefile();
                sfAsetFaskes.Open(strfileshp, null);
                int handleBufferResult = legend1.Layers.Add(sfAsetFaskes, true);
                legend1.GetLayer(handleBufferResult).Name = System.IO.Path.GetFileName(strfileshp);
                sfAsetFaskes.Identifiable = true;

                if (!FormBufferObject.cboInput.Items.Contains(strfileshp))
                {
                    FormBufferObject.cboInput.Items.Add(strfileshp);
                }
                FormBufferObject.cboInput.Text = strfileshp;
            }
            else
            {
                MessageBox.Show(strfileshp, "Report", MessageBoxButtons.OKCancel);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            legend1.Layers.Remove(legend1.SelectedLayer);
        }

        //---------------------------
        //DATA GRID VIEW EVENT
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Shapefile sf = axMap1.get_Shapefile(handleAsetFaskes);
                sf.SelectNone();

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    sf.set_ShapeSelected(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["fid"].Value), true);
                }
                axMap1.ZoomToSelected(handleAsetFaskes);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Shapefile sf = axMap1.get_Shapefile(handleAsetFaskes);
                sf.SelectNone();

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    sf.set_ShapeSelected(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["fid"].Value), true);
                }
                axMap1.ZoomToSelected(handleAsetFaskes);
            }
        }

        //-------------------------
        //QUERY KECAMATAN
        private void cbKecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbKecamatan.Text == "Kecamatan :"))
            {
                cbDesa.Items.Clear();
                cbDesa.Text = "Desa :";
                cbAset.Items.Clear();
                cbAset.Text = "Aset :";

                Shapefile sfBatasDesa = axMap1.get_Shapefile(handleBatasDesa);
                sfBatasDesa.SelectNone();

                string errorBatasDesa = "";
                object resultBatasDesa = null;
                string queryBatasDesa = "[Kecamatan] = \"" + cbKecamatan.Text + "\"";

                if (sfBatasDesa.Table.Query(queryBatasDesa, ref resultBatasDesa, ref errorBatasDesa))
                {
                    int[] shapesBatasDesa = resultBatasDesa as int[];
                    if (shapesBatasDesa != null)
                    {
                        for (int i = 0; i < shapesBatasDesa.Length; i++)
                        {
                            sfBatasDesa.set_ShapeSelected(shapesBatasDesa[i], true);

                            if (!cbDesa.Items.Contains(
                                sfBatasDesa.CellValue[sfBatasDesa.FieldIndexByName["Desa"], shapesBatasDesa[i]].ToString()))
                            {
                                cbDesa.Items.Add(
                                    sfBatasDesa.CellValue[sfBatasDesa.FieldIndexByName["Desa"], shapesBatasDesa[i]].ToString());
                            }
                        }
                        cbDesa.Sorted = true;
                        axMap1.ZoomToSelected(handleBatasDesa);
                    }
                }

                Shapefile sfAsetFaskes = axMap1.get_Shapefile(handleAsetFaskes);
                sfAsetFaskes.SelectNone();

                string errorAsetFaskes = "";
                object resultAsetFaskes = null;
                string queryAsetFaskes = "[Kecamatan] =\"" + cbKecamatan.Text + "\"";

                if (sfAsetFaskes.Table.Query(queryAsetFaskes, ref resultAsetFaskes, ref errorAsetFaskes))
                {
                    int[] shapesAsetFaskes = resultAsetFaskes as int[];
                    if (shapesAsetFaskes != null)
                    {
                        if (!(shapesAsetFaskes.Length == 0))
                        {
                            MessageBox.Show("Pada Kecamatan " + cbKecamatan.Text
                                + " ditemukan " + shapesAsetFaskes.Length.ToString()
                                + " fasilitas kesehatan milik Kabupaten Sleman..", "Informasi Fasilitas Kesehatan", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Pada Kecamatan " + cbKecamatan.Text
                                + " tidak ditemukan fasilitas kesehatan milik Kabupaten Sleman.. ",
                                "Informasi Fasilitas Kesehatan", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pada Kecamatan " + cbKecamatan.Text
                            + " tidak ditemukan fasilitas kesehatan milik Kabupaten Sleman.. ",
                            "Informasi Fasilitas Kesehatan", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void cbDesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbKecamatan.Text == "Kecamatan :")
                && !(cbDesa.Text == "Desa :"))
            {
                cbAset.Items.Clear();
                cbAset.Text = "Aset :";

                Shapefile sfBatasDesa = axMap1.get_Shapefile(handleBatasDesa);
                sfBatasDesa.SelectNone();

                string errorBatasDesa = "";
                object resultBatasDesa = null;
                string queryBatasDesa = "[Kecamatan] = \"" + cbKecamatan.Text + "\""
                    + "\" AND [Desa] = \"" + cbDesa.Text + "\"";

                if (sfBatasDesa.Table.Query(queryBatasDesa, ref resultBatasDesa, ref errorBatasDesa))
                {
                    int[] shapesBatasDesa = resultBatasDesa as int[];
                    if (shapesBatasDesa != null)
                    {
                        for (int i = 0; i < shapesBatasDesa.Length; i++)
                        {
                            sfBatasDesa.set_ShapeSelected(shapesBatasDesa[i], true);
                        }
                        axMap1.ZoomToSelected(handleBatasDesa);
                    }
                }

                Shapefile sfAsetFaskes = axMap1.get_Shapefile(handleAsetFaskes);
                sfAsetFaskes.SelectNone();

                string errorAsetFaskes = "";
                object resultAsetFaskes = null;
                string queryAsetFaskes = "[Kecamatan] =\"" + cbKecamatan.Text
                    + "\" AND [Desa] = \"" + cbDesa.Text + "\"";

                if (sfAsetFaskes.Table.Query(queryAsetFaskes, ref resultAsetFaskes, ref errorAsetFaskes))
                {
                    int[] shapesAsetFaskes = resultAsetFaskes as int[];
                    if (shapesAsetFaskes != null)
                    {
                        if (!(shapesAsetFaskes.Length == 0))
                        {
                            for (int i = 0; i < shapesAsetFaskes.Length; i++)
                            {
                                if (!cbAset.Items.Contains(
                                    sfAsetFaskes.CellValue[sfAsetFaskes.FieldIndexByName["Kategori"], shapesAsetFaskes[i]].ToString()))
                                {
                                    cbAset.Items.Add(
                                        sfAsetFaskes.CellValue[sfAsetFaskes.FieldIndexByName["Kategori"], shapesAsetFaskes[i]].ToString());
                                }
                            }
                            cbAset.Sorted = true;
                            MessageBox.Show("Pada Kecamatan " + cbKecamatan.Text
                                + " Desa " + cbDesa.Text + " ditemukan "
                                + shapesAsetFaskes.Length.ToString() + " fasilitas kesehatan milik Kabupaten Sleman..",
                                "Informasi Fasilitas Kesehatan", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Pada Kecamatan " + cbKecamatan.Text
                                + " Desa " + cbDesa.Text
                                + " tidak ditemukan fasilitas kesehatan milik Kabupaten Sleman.. ",
                                "Informasi Fasilitas Kesehatan", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pada Kecamatan " + cbKecamatan.Text
                            + " Desa " + cbDesa.Text
                            + " tidak ditemukan fasilitas kesehatan milik Kabupaten Sleman.. ",
                            "Informasi Fasilitas Kesehatan", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void cbAset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbKecamatan.Text == "Kecamatan :")
                && !(cbDesa.Text == "Desa :")
                && !(cbAset.Text == "Aset :"))
            {
                Shapefile sfBatasDesa = axMap1.get_Shapefile(handleBatasDesa);
                sfBatasDesa.SelectNone();

                Shapefile sfAsetFaskes = axMap1.get_Shapefile(handleAsetFaskes);
                sfAsetFaskes.SelectNone();

                string errorAsetFaskes = "";
                object resultAsetFaskes = null;
                string queryAsetFaskes = "[Kecamatan] =\"" + cbKecamatan.Text
                    + "\" AND [Desa] = \"" + cbDesa.Text + "\""
                    + "\" AND [Kategori] = \"" + cbAset.Text + "\"";

                if (sfAsetFaskes.Table.Query(queryAsetFaskes, ref resultAsetFaskes, ref errorAsetFaskes))
                {
                    int[] shapesAsetFaskes = resultAsetFaskes as int[];
                    if (shapesAsetFaskes != null)
                    {
                        for (int i = 0; i < shapesAsetFaskes.Length; i++)
                        {
                            sfAsetFaskes.set_ShapeSelected(shapesAsetFaskes[i], true);
                        }
                        axMap1.ZoomToSelected(handleAsetFaskes);
                        axMap1.ZoomIn(0.2);
                        axMap1.ZoomIn(0.2);
                        axMap1.ZoomIn(0.2);
                        axMap1.ZoomIn(0.2);
                        axMap1.ZoomIn(0.2);
                    }
                }
            }
        }

        //----------------------------
        //EDIT
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            FormAddPointObject.Show();
            FormAddPointObject.BringToFront();
        }

        //-----------------------------
        //ANALYST
        private void btnBuffer_Click(object sender, EventArgs e)
        {
            FormBufferObject.Show();
            FormBufferObject.BringToFront();
        }

        //-----------------------------
        //MAPEVENT
        private void axMap1_MouseUpEvent(object sender, _DMapEvents_MouseUpEvent e)
        {
            double projX = 0.0;
            double projY = 0.0;
            axMap1.PixelToProj(e.x, e.y, ref projX, ref projY);
            object result = null;
            Extents ext = new Extents();
            ext.SetBounds(projX, projY, 0.0, projX, projY, 0.0);
            double tolerance = 100; //meter
            Utils utils = new Utils();
            utils.ConvertDistance(tkUnitsOfMeasure.umMeters, tkUnitsOfMeasure.umDecimalDegrees, ref tolerance);

            if (axMap1.MapCursor == tkCursor.crsrHelp)
            {
                Shapefile sf = axMap1.get_Shapefile(handleAsetFaskes);
                sf.SelectNone();
                axMap1.Redraw2(tkRedrawType.RedrawAll);
                axMap1.Refresh();

                FormPopUpObject.Hide();

                if (sf != null)
                {
                    if (sf.SelectShapes(ext, tolerance, SelectMode.INTERSECTION, ref result))
                    {
                        int[] shapes = result as int[];
                        if (shapes.Length > 0)
                        {
                            sf.SelectNone();
                            sf.set_ShapeSelected(shapes[0], true);
                            axMap1.Redraw2(tkRedrawType.RedrawAll);
                            axMap1.Refresh();

                            FormPopUpObject.txtIndex.Text = shapes[0].ToString();

                            FormPopUpObject.txtNamaAset.Text = sf.get_CellValue(
                                sf.Table.get_FieldIndexByName("Nama"), shapes[0]).ToString();
                            FormPopUpObject.cboKategori.Text = sf.get_CellValue(
                                sf.Table.get_FieldIndexByName("Kategori"), shapes[0]).ToString();
                            FormPopUpObject.txtSumber.Text = sf.get_CellValue(
                                sf.Table.get_FieldIndexByName("Sumber"), shapes[0]).ToString();
                            FormPopUpObject.txtFoto.Text = sf.get_CellValue(
                                sf.Table.get_FieldIndexByName("Foto"), shapes[0]).ToString();

                            FormPopUpObject.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            FormPopUpObject.pictureBox1.ImageLocation = Path.Combine(strFilePath,
                            "Database/Non-Spatial/Foto/" + sf.get_CellValue(
                                sf.Table.get_FieldIndexByName("Foto"), shapes[0]).ToString());

                            FormPopUpObject.Show();
                            FormPopUpObject.BringToFront();
                        }
                    }
                }
            }
            else if (axMap1.MapCursor == tkCursor.crsrCross)
            {
                FormAddPointObject.txtX.Text = Convert.ToString(projX);
                FormAddPointObject.txtY.Text = Convert.ToString(projY);
            }
        }

        //-------------------
        //FUNCTION
        public void loadAsetFaskes()
        {
            //-----------------------------------
            //LAYER FASKES
            //-----------------------------------
            string shpAsetFaskes = Path.Combine(strFilePath, "Database/Spatial/Aset_Kesehatan.shp");
            MapWinGIS.Shapefile sfAsetFaskes = new MapWinGIS.Shapefile();
            sfAsetFaskes.Open(shpAsetFaskes, null);
            handleAsetFaskes = legend1.Layers.Add(sfAsetFaskes, true);
            legend1.GetLayer(handleAsetFaskes).Name = "Fasilitas Kesehatan";

            MapWinGIS.Image imgPuskesmas = new MapWinGIS.Image();
            imgPuskesmas.Open(Path.Combine(strFilePath, "Database/Non-Spatial/Icon/Puskesmas.png"),
                ImageType.USE_FILE_EXTENSION, true, null);
            ShapefileCategory ctPuskesmas = sfAsetFaskes.Categories.Add("Puskesmas");
            ctPuskesmas.Expression = "[Kategori] = \"Puskesmas\"";
            ctPuskesmas.DrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;
            ctPuskesmas.DrawingOptions.Picture = imgPuskesmas;
            ctPuskesmas.DrawingOptions.PictureScaleX = 0.5;
            ctPuskesmas.DrawingOptions.PictureScaleY = 0.5;

            MapWinGIS.Image imgPuskesmasPembantu = new MapWinGIS.Image();
            imgPuskesmasPembantu.Open(Path.Combine(strFilePath, "Database/Non-Spatial/Icon/Puskesmas Pembantu.png"),
                ImageType.USE_FILE_EXTENSION, true, null);
            ShapefileCategory ctPuskesmasPembantu = sfAsetFaskes.Categories.Add("Puskesmas Pembantu");
            ctPuskesmasPembantu.Expression = "[Kategori] = \"Puskesmas Pembantu\"";
            ctPuskesmasPembantu.DrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;
            ctPuskesmasPembantu.DrawingOptions.Picture = imgPuskesmasPembantu;
            ctPuskesmasPembantu.DrawingOptions.PictureScaleX = 0.5;
            ctPuskesmasPembantu.DrawingOptions.PictureScaleY = 0.5;

            MapWinGIS.Image imgRS = new MapWinGIS.Image();
            imgRS.Open(Path.Combine(strFilePath, "Database/Non-Spatial/Icon/RS.png"),
                ImageType.USE_FILE_EXTENSION, true, null);
            ShapefileCategory ctRS = sfAsetFaskes.Categories.Add("Rumah Sakit");
            ctRS.Expression = "[Kategori] = \"Rumah Sakit\"";
            ctRS.DrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;
            ctRS.DrawingOptions.Picture = imgRS;
            ctRS.DrawingOptions.PictureScaleX = 0.5;
            ctRS.DrawingOptions.PictureScaleY = 0.5;

            sfAsetFaskes.DefaultDrawingOptions.Visible = false;
            sfAsetFaskes.Categories.ApplyExpressions();
            axMap1.Redraw();

            //-----------------------------------
            //ATTRIBUTE
            dataGridView1.Rows.Clear();
            cbKecamatan.Items.Clear();

            for (int i = 0; i < sfAsetFaskes.Table.NumFields; i++)
            {
                dataGridView1.Columns.Add(sfAsetFaskes.Table.Field[i].Name, sfAsetFaskes.Table.Field[i].Name);
            }
            dataGridView1.Columns.Add("fid", "fid");

            for (int i = 0; i < sfAsetFaskes.Table.NumRows; i++)
            {
                string[] myAttributeRow = new string[sfAsetFaskes.Table.NumFields + 1];
                for (int j = 0; j < sfAsetFaskes.Table.NumFields; j++)
                {
                    myAttributeRow[j] = sfAsetFaskes.Table.CellValue[j, i].ToString();
                }
                myAttributeRow[sfAsetFaskes.Table.NumFields] = i.ToString();
                dataGridView1.Rows.Insert(i, myAttributeRow);

                if (!cbKecamatan.Items.Contains(
                    sfAsetFaskes.Table.CellValue[sfAsetFaskes.FieldIndexByName["Kecamatan"], i].ToString()))
                {
                    cbKecamatan.Items.Add(
                        sfAsetFaskes.Table.CellValue[sfAsetFaskes.FieldIndexByName["Kecamatan"], i].ToString());
                }
            }

            dataGridView1.ClearSelection();
            cbKecamatan.Sorted = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(draggable)
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
