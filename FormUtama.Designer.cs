
namespace SI_TEMAN2
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnPrintMap = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnBuffer = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.legend1 = new MWLite.Symbology.LegendControl.Legend();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.radioButtonMapQuestAerial = new System.Windows.Forms.RadioButton();
            this.radioButtonGHybrid = new System.Windows.Forms.RadioButton();
            this.radioButtonGMaps = new System.Windows.Forms.RadioButton();
            this.radioButtonBingSatellite = new System.Windows.Forms.RadioButton();
            this.radioButtonOTM = new System.Windows.Forms.RadioButton();
            this.radioButtonOSM = new System.Windows.Forms.RadioButton();
            this.radioButtonGoogleTerrain = new System.Windows.Forms.RadioButton();
            this.radioButtonGoogleSatellite = new System.Windows.Forms.RadioButton();
            this.radioButtonBingHybrid = new System.Windows.Forms.RadioButton();
            this.radioButtonBingMaps = new System.Windows.Forms.RadioButton();
            this.radioButtonOCM = new System.Windows.Forms.RadioButton();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAset = new System.Windows.Forms.ComboBox();
            this.cbDesa = new System.Windows.Forms.ComboBox();
            this.cbKecamatan = new System.Windows.Forms.ComboBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomToExtent = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLengthArea = new System.Windows.Forms.Button();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.metroSetControlBox1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 44);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1289, 0);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 3;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(0, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 27);
            this.button10.TabIndex = 2;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 823);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1425, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnAddData);
            this.panel3.Controls.Add(this.btnPrintMap);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnBuffer);
            this.panel3.Controls.Add(this.btnAddPoint);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(58, 779);
            this.panel3.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(10, 71);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(37, 39);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.FlatAppearance.BorderSize = 0;
            this.btnAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddData.Image = ((System.Drawing.Image)(resources.GetObject("btnAddData.Image")));
            this.btnAddData.Location = new System.Drawing.Point(10, 25);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(37, 39);
            this.btnAddData.TabIndex = 22;
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnPrintMap
            // 
            this.btnPrintMap.FlatAppearance.BorderSize = 0;
            this.btnPrintMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintMap.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMap.Image")));
            this.btnPrintMap.Location = new System.Drawing.Point(9, 278);
            this.btnPrintMap.Name = "btnPrintMap";
            this.btnPrintMap.Size = new System.Drawing.Size(40, 50);
            this.btnPrintMap.TabIndex = 21;
            this.btnPrintMap.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(10, 229);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(40, 40);
            this.btnExport.TabIndex = 20;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnBuffer
            // 
            this.btnBuffer.FlatAppearance.BorderSize = 0;
            this.btnBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuffer.Image = ((System.Drawing.Image)(resources.GetObject("btnBuffer.Image")));
            this.btnBuffer.Location = new System.Drawing.Point(14, 183);
            this.btnBuffer.Name = "btnBuffer";
            this.btnBuffer.Size = new System.Drawing.Size(29, 31);
            this.btnBuffer.TabIndex = 19;
            this.btnBuffer.UseVisualStyleBackColor = true;
            this.btnBuffer.Click += new System.EventHandler(this.btnBuffer_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.FlatAppearance.BorderSize = 0;
            this.btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPoint.Image")));
            this.btnAddPoint.Location = new System.Drawing.Point(9, 126);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(38, 38);
            this.btnAddPoint.TabIndex = 18;
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(58, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 779);
            this.panel4.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(345, 779);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.legend1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(337, 750);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Table Of Contents";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.Location = new System.Drawing.Point(3, 3);
            this.legend1.Map = null;
            this.legend1.Name = "legend1";
            this.legend1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.legend1.SelectedLayer = -1;
            this.legend1.ShowGroupFolders = true;
            this.legend1.ShowLabels = false;
            this.legend1.Size = new System.Drawing.Size(331, 744);
            this.legend1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.radioButtonMapQuestAerial);
            this.tabPage4.Controls.Add(this.radioButtonGHybrid);
            this.tabPage4.Controls.Add(this.radioButtonGMaps);
            this.tabPage4.Controls.Add(this.radioButtonBingSatellite);
            this.tabPage4.Controls.Add(this.radioButtonOTM);
            this.tabPage4.Controls.Add(this.radioButtonOSM);
            this.tabPage4.Controls.Add(this.radioButtonGoogleTerrain);
            this.tabPage4.Controls.Add(this.radioButtonGoogleSatellite);
            this.tabPage4.Controls.Add(this.radioButtonBingHybrid);
            this.tabPage4.Controls.Add(this.radioButtonBingMaps);
            this.tabPage4.Controls.Add(this.radioButtonOCM);
            this.tabPage4.Controls.Add(this.radioButtonNone);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(337, 750);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Basemaps";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // radioButtonMapQuestAerial
            // 
            this.radioButtonMapQuestAerial.AutoSize = true;
            this.radioButtonMapQuestAerial.Location = new System.Drawing.Point(23, 515);
            this.radioButtonMapQuestAerial.Name = "radioButtonMapQuestAerial";
            this.radioButtonMapQuestAerial.Size = new System.Drawing.Size(138, 21);
            this.radioButtonMapQuestAerial.TabIndex = 11;
            this.radioButtonMapQuestAerial.TabStop = true;
            this.radioButtonMapQuestAerial.Text = "Map Quest Aerial";
            this.radioButtonMapQuestAerial.UseVisualStyleBackColor = true;
            this.radioButtonMapQuestAerial.CheckedChanged += new System.EventHandler(this.radioButtonMapQuestAerial_CheckedChanged);
            // 
            // radioButtonGHybrid
            // 
            this.radioButtonGHybrid.AutoSize = true;
            this.radioButtonGHybrid.Location = new System.Drawing.Point(23, 463);
            this.radioButtonGHybrid.Name = "radioButtonGHybrid";
            this.radioButtonGHybrid.Size = new System.Drawing.Size(120, 21);
            this.radioButtonGHybrid.TabIndex = 10;
            this.radioButtonGHybrid.TabStop = true;
            this.radioButtonGHybrid.Text = "Google Hybrid";
            this.radioButtonGHybrid.UseVisualStyleBackColor = true;
            this.radioButtonGHybrid.CheckedChanged += new System.EventHandler(this.radioButtonGHybrid_CheckedChanged);
            // 
            // radioButtonGMaps
            // 
            this.radioButtonGMaps.AutoSize = true;
            this.radioButtonGMaps.Location = new System.Drawing.Point(23, 416);
            this.radioButtonGMaps.Name = "radioButtonGMaps";
            this.radioButtonGMaps.Size = new System.Drawing.Size(113, 21);
            this.radioButtonGMaps.TabIndex = 9;
            this.radioButtonGMaps.TabStop = true;
            this.radioButtonGMaps.Text = "Google Maps";
            this.radioButtonGMaps.UseVisualStyleBackColor = true;
            this.radioButtonGMaps.CheckedChanged += new System.EventHandler(this.radioButtonGMaps_CheckedChanged);
            // 
            // radioButtonBingSatellite
            // 
            this.radioButtonBingSatellite.AutoSize = true;
            this.radioButtonBingSatellite.Location = new System.Drawing.Point(23, 368);
            this.radioButtonBingSatellite.Name = "radioButtonBingSatellite";
            this.radioButtonBingSatellite.Size = new System.Drawing.Size(111, 21);
            this.radioButtonBingSatellite.TabIndex = 8;
            this.radioButtonBingSatellite.TabStop = true;
            this.radioButtonBingSatellite.Text = "Bing Satellite";
            this.radioButtonBingSatellite.UseVisualStyleBackColor = true;
            this.radioButtonBingSatellite.CheckedChanged += new System.EventHandler(this.radioButtonBingSatellite_CheckedChanged);
            // 
            // radioButtonOTM
            // 
            this.radioButtonOTM.AutoSize = true;
            this.radioButtonOTM.Location = new System.Drawing.Point(23, 326);
            this.radioButtonOTM.Name = "radioButtonOTM";
            this.radioButtonOTM.Size = new System.Drawing.Size(161, 21);
            this.radioButtonOTM.TabIndex = 7;
            this.radioButtonOTM.TabStop = true;
            this.radioButtonOTM.Text = "Open Transport Map";
            this.radioButtonOTM.UseVisualStyleBackColor = true;
            this.radioButtonOTM.CheckedChanged += new System.EventHandler(this.radioButtonOTM_CheckedChanged);
            // 
            // radioButtonOSM
            // 
            this.radioButtonOSM.AutoSize = true;
            this.radioButtonOSM.Location = new System.Drawing.Point(23, 282);
            this.radioButtonOSM.Name = "radioButtonOSM";
            this.radioButtonOSM.Size = new System.Drawing.Size(137, 21);
            this.radioButtonOSM.TabIndex = 6;
            this.radioButtonOSM.TabStop = true;
            this.radioButtonOSM.Text = "Open Street Map";
            this.radioButtonOSM.UseVisualStyleBackColor = true;
            this.radioButtonOSM.CheckedChanged += new System.EventHandler(this.radioButtonOSM_CheckedChanged);
            // 
            // radioButtonGoogleTerrain
            // 
            this.radioButtonGoogleTerrain.AutoSize = true;
            this.radioButtonGoogleTerrain.Location = new System.Drawing.Point(23, 232);
            this.radioButtonGoogleTerrain.Name = "radioButtonGoogleTerrain";
            this.radioButtonGoogleTerrain.Size = new System.Drawing.Size(125, 21);
            this.radioButtonGoogleTerrain.TabIndex = 5;
            this.radioButtonGoogleTerrain.TabStop = true;
            this.radioButtonGoogleTerrain.Text = "Google Terrain";
            this.radioButtonGoogleTerrain.UseVisualStyleBackColor = true;
            this.radioButtonGoogleTerrain.CheckedChanged += new System.EventHandler(this.radioButtonGoogleTerrain_CheckedChanged);
            // 
            // radioButtonGoogleSatellite
            // 
            this.radioButtonGoogleSatellite.AutoSize = true;
            this.radioButtonGoogleSatellite.Location = new System.Drawing.Point(23, 185);
            this.radioButtonGoogleSatellite.Name = "radioButtonGoogleSatellite";
            this.radioButtonGoogleSatellite.Size = new System.Drawing.Size(129, 21);
            this.radioButtonGoogleSatellite.TabIndex = 4;
            this.radioButtonGoogleSatellite.TabStop = true;
            this.radioButtonGoogleSatellite.Text = "Google Satellite";
            this.radioButtonGoogleSatellite.UseVisualStyleBackColor = true;
            this.radioButtonGoogleSatellite.CheckedChanged += new System.EventHandler(this.radioButtonGoogleSatellite_CheckedChanged);
            // 
            // radioButtonBingHybrid
            // 
            this.radioButtonBingHybrid.AutoSize = true;
            this.radioButtonBingHybrid.Location = new System.Drawing.Point(23, 141);
            this.radioButtonBingHybrid.Name = "radioButtonBingHybrid";
            this.radioButtonBingHybrid.Size = new System.Drawing.Size(102, 21);
            this.radioButtonBingHybrid.TabIndex = 3;
            this.radioButtonBingHybrid.TabStop = true;
            this.radioButtonBingHybrid.Text = "Bing Hybrid";
            this.radioButtonBingHybrid.UseVisualStyleBackColor = true;
            this.radioButtonBingHybrid.CheckedChanged += new System.EventHandler(this.radioButtonBingHybrid_CheckedChanged);
            // 
            // radioButtonBingMaps
            // 
            this.radioButtonBingMaps.AutoSize = true;
            this.radioButtonBingMaps.Location = new System.Drawing.Point(23, 101);
            this.radioButtonBingMaps.Name = "radioButtonBingMaps";
            this.radioButtonBingMaps.Size = new System.Drawing.Size(95, 21);
            this.radioButtonBingMaps.TabIndex = 2;
            this.radioButtonBingMaps.TabStop = true;
            this.radioButtonBingMaps.Text = "Bing Maps";
            this.radioButtonBingMaps.UseVisualStyleBackColor = true;
            this.radioButtonBingMaps.CheckedChanged += new System.EventHandler(this.radioButtonBingMaps_CheckedChanged);
            // 
            // radioButtonOCM
            // 
            this.radioButtonOCM.AutoSize = true;
            this.radioButtonOCM.Location = new System.Drawing.Point(23, 64);
            this.radioButtonOCM.Name = "radioButtonOCM";
            this.radioButtonOCM.Size = new System.Drawing.Size(133, 21);
            this.radioButtonOCM.TabIndex = 1;
            this.radioButtonOCM.TabStop = true;
            this.radioButtonOCM.Text = "Open Cycle Map";
            this.radioButtonOCM.UseVisualStyleBackColor = true;
            this.radioButtonOCM.CheckedChanged += new System.EventHandler(this.radioButtonOCM_CheckedChanged);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(23, 23);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(63, 21);
            this.radioButtonNone.TabIndex = 0;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonNone_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cbAset);
            this.panel5.Controls.Add(this.cbDesa);
            this.panel5.Controls.Add(this.cbKecamatan);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(403, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1022, 48);
            this.panel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(610, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aset :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(334, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kecamatan :";
            // 
            // cbAset
            // 
            this.cbAset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAset.FormattingEnabled = true;
            this.cbAset.Location = new System.Drawing.Point(660, 12);
            this.cbAset.Name = "cbAset";
            this.cbAset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbAset.Size = new System.Drawing.Size(196, 24);
            this.cbAset.TabIndex = 5;
            this.cbAset.SelectedIndexChanged += new System.EventHandler(this.cbAset_SelectedIndexChanged);
            // 
            // cbDesa
            // 
            this.cbDesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDesa.FormattingEnabled = true;
            this.cbDesa.Location = new System.Drawing.Point(389, 12);
            this.cbDesa.Name = "cbDesa";
            this.cbDesa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbDesa.Size = new System.Drawing.Size(196, 24);
            this.cbDesa.TabIndex = 4;
            this.cbDesa.SelectedIndexChanged += new System.EventHandler(this.cbDesa_SelectedIndexChanged);
            // 
            // cbKecamatan
            // 
            this.cbKecamatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKecamatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKecamatan.FormattingEnabled = true;
            this.cbKecamatan.Location = new System.Drawing.Point(108, 12);
            this.cbKecamatan.Name = "cbKecamatan";
            this.cbKecamatan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbKecamatan.Size = new System.Drawing.Size(196, 24);
            this.cbKecamatan.TabIndex = 3;
            this.cbKecamatan.SelectedIndexChanged += new System.EventHandler(this.cbKecamatan_SelectedIndexChanged);
            // 
            // btnNormal
            // 
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(10, 7);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(29, 31);
            this.btnNormal.TabIndex = 11;
            this.btnNormal.Tag = "";
            this.btnNormal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnPan
            // 
            this.btnPan.FlatAppearance.BorderSize = 0;
            this.btnPan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPan.Image = ((System.Drawing.Image)(resources.GetObject("btnPan.Image")));
            this.btnPan.Location = new System.Drawing.Point(61, 7);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(29, 31);
            this.btnPan.TabIndex = 12;
            this.btnPan.Tag = "";
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.Location = new System.Drawing.Point(113, 7);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(29, 31);
            this.btnZoomIn.TabIndex = 13;
            this.btnZoomIn.Tag = "";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.Location = new System.Drawing.Point(162, 6);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(29, 31);
            this.btnZoomOut.TabIndex = 14;
            this.btnZoomOut.Tag = "";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomToExtent
            // 
            this.btnZoomToExtent.FlatAppearance.BorderSize = 0;
            this.btnZoomToExtent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomToExtent.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomToExtent.Image")));
            this.btnZoomToExtent.Location = new System.Drawing.Point(213, 7);
            this.btnZoomToExtent.Name = "btnZoomToExtent";
            this.btnZoomToExtent.Size = new System.Drawing.Size(29, 31);
            this.btnZoomToExtent.TabIndex = 15;
            this.btnZoomToExtent.Tag = "";
            this.btnZoomToExtent.UseVisualStyleBackColor = true;
            this.btnZoomToExtent.Click += new System.EventHandler(this.btnZoomToExtent_Click);
            // 
            // btnIdentify
            // 
            this.btnIdentify.FlatAppearance.BorderSize = 0;
            this.btnIdentify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentify.Image = ((System.Drawing.Image)(resources.GetObject("btnIdentify.Image")));
            this.btnIdentify.Location = new System.Drawing.Point(269, 6);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(29, 31);
            this.btnIdentify.TabIndex = 16;
            this.btnIdentify.Tag = "";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnLength
            // 
            this.btnLength.FlatAppearance.BorderSize = 0;
            this.btnLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLength.Image = ((System.Drawing.Image)(resources.GetObject("btnLength.Image")));
            this.btnLength.Location = new System.Drawing.Point(315, 3);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(48, 39);
            this.btnLength.TabIndex = 17;
            this.btnLength.Tag = "";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 731);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.axMap1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.btnLengthArea);
            this.panel7.Controls.Add(this.btnNormal);
            this.panel7.Controls.Add(this.btnZoomToExtent);
            this.panel7.Controls.Add(this.btnLength);
            this.panel7.Controls.Add(this.btnZoomOut);
            this.panel7.Controls.Add(this.btnPan);
            this.panel7.Controls.Add(this.btnZoomIn);
            this.panel7.Controls.Add(this.btnIdentify);
            this.panel7.Location = new System.Drawing.Point(298, 639);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(418, 44);
            this.panel7.TabIndex = 6;
            // 
            // btnLengthArea
            // 
            this.btnLengthArea.FlatAppearance.BorderSize = 0;
            this.btnLengthArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLengthArea.Image = ((System.Drawing.Image)(resources.GetObject("btnLengthArea.Image")));
            this.btnLengthArea.Location = new System.Drawing.Point(369, 3);
            this.btnLengthArea.Name = "btnLengthArea";
            this.btnLengthArea.Size = new System.Drawing.Size(37, 39);
            this.btnLengthArea.TabIndex = 18;
            this.btnLengthArea.Tag = "";
            this.btnLengthArea.UseVisualStyleBackColor = true;
            this.btnLengthArea.Click += new System.EventHandler(this.btnLengthArea_Click);
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(3, 3);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(1008, 696);
            this.axMap1.TabIndex = 0;
            this.axMap1.MouseUpEvent += new AxMapWinGIS._DMapEvents_MouseUpEventHandler(this.axMap1_MouseUpEvent);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attributes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 696);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(403, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1022, 731);
            this.panel6.TabIndex = 7;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 856);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fakhri Raihan";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrintMap;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnBuffer;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnZoomToExtent;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbAset;
        private System.Windows.Forms.ComboBox cbDesa;
        private System.Windows.Forms.ComboBox cbKecamatan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButtonMapQuestAerial;
        private System.Windows.Forms.RadioButton radioButtonGHybrid;
        private System.Windows.Forms.RadioButton radioButtonGMaps;
        private System.Windows.Forms.RadioButton radioButtonBingSatellite;
        private System.Windows.Forms.RadioButton radioButtonOTM;
        private System.Windows.Forms.RadioButton radioButtonOSM;
        private System.Windows.Forms.RadioButton radioButtonGoogleTerrain;
        private System.Windows.Forms.RadioButton radioButtonGoogleSatellite;
        private System.Windows.Forms.RadioButton radioButtonBingHybrid;
        private System.Windows.Forms.RadioButton radioButtonBingMaps;
        private System.Windows.Forms.RadioButton radioButtonOCM;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.Button btnLengthArea;
        public AxMapWinGIS.AxMap axMap1;
        public System.Windows.Forms.Button btnNormal;
        public MWLite.Symbology.LegendControl.Legend legend1;
    }
}

