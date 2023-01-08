
namespace SI_TEMAN2
{
    partial class FormAddPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPoint));
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.RadioButton_Input = new System.Windows.Forms.RadioButton();
            this.RadioButton_Digitasi = new System.Windows.Forms.RadioButton();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtSumber = new System.Windows.Forms.TextBox();
            this.lblSumber = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtNamaAset = new System.Windows.Forms.TextBox();
            this.lblNamaAset = new System.Windows.Forms.Label();
            this.cmdPan = new System.Windows.Forms.Button();
            this.cmdZoomOut = new System.Windows.Forms.Button();
            this.cmdZoomIn = new System.Windows.Forms.Button();
            this.cmdFullExtent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.button10 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(428, 52);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 64;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(397, 54);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 17);
            this.lblY.TabIndex = 63;
            this.lblY.Text = "Y :";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(279, 52);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 62;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(248, 54);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 17);
            this.lblX.TabIndex = 61;
            this.lblX.Text = "X :";
            // 
            // RadioButton_Input
            // 
            this.RadioButton_Input.AutoSize = true;
            this.RadioButton_Input.Location = new System.Drawing.Point(25, 52);
            this.RadioButton_Input.Name = "RadioButton_Input";
            this.RadioButton_Input.Size = new System.Drawing.Size(217, 21);
            this.RadioButton_Input.TabIndex = 60;
            this.RadioButton_Input.TabStop = true;
            this.RadioButton_Input.Text = "Input menggunakan keyboard";
            this.RadioButton_Input.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Digitasi
            // 
            this.RadioButton_Digitasi.AutoSize = true;
            this.RadioButton_Digitasi.Location = new System.Drawing.Point(25, 21);
            this.RadioButton_Digitasi.Name = "RadioButton_Digitasi";
            this.RadioButton_Digitasi.Size = new System.Drawing.Size(280, 21);
            this.RadioButton_Digitasi.TabIndex = 59;
            this.RadioButton_Digitasi.TabStop = true;
            this.RadioButton_Digitasi.Text = "Digitasi on screen menggunakan cursor";
            this.RadioButton_Digitasi.UseVisualStyleBackColor = true;
            this.RadioButton_Digitasi.CheckedChanged += new System.EventHandler(this.RadioButton_Digitasi_CheckedChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(385, 472);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(63, 32);
            this.cmdSave.TabIndex = 58;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(454, 472);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(74, 32);
            this.cmdCancel.TabIndex = 57;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(29, 472);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(74, 22);
            this.txtIndex.TabIndex = 56;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(438, 425);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(90, 29);
            this.cmdBrowse.TabIndex = 55;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(157, 428);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(275, 22);
            this.txtFoto.TabIndex = 54;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(26, 434);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(36, 17);
            this.lblFoto.TabIndex = 53;
            this.lblFoto.Text = "Foto";
            // 
            // txtSumber
            // 
            this.txtSumber.Location = new System.Drawing.Point(157, 400);
            this.txtSumber.Name = "txtSumber";
            this.txtSumber.Size = new System.Drawing.Size(371, 22);
            this.txtSumber.TabIndex = 52;
            // 
            // lblSumber
            // 
            this.lblSumber.AutoSize = true;
            this.lblSumber.Location = new System.Drawing.Point(26, 406);
            this.lblSumber.Name = "lblSumber";
            this.lblSumber.Size = new System.Drawing.Size(57, 17);
            this.lblSumber.TabIndex = 51;
            this.lblSumber.Text = "Sumber";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(26, 378);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(61, 17);
            this.lblKategori.TabIndex = 49;
            this.lblKategori.Text = "Kategori";
            // 
            // txtNamaAset
            // 
            this.txtNamaAset.Location = new System.Drawing.Point(157, 344);
            this.txtNamaAset.Name = "txtNamaAset";
            this.txtNamaAset.Size = new System.Drawing.Size(371, 22);
            this.txtNamaAset.TabIndex = 48;
            // 
            // lblNamaAset
            // 
            this.lblNamaAset.AutoSize = true;
            this.lblNamaAset.Location = new System.Drawing.Point(26, 350);
            this.lblNamaAset.Name = "lblNamaAset";
            this.lblNamaAset.Size = new System.Drawing.Size(77, 17);
            this.lblNamaAset.TabIndex = 47;
            this.lblNamaAset.Text = "Nama Aset";
            // 
            // cmdPan
            // 
            this.cmdPan.Image = ((System.Drawing.Image)(resources.GetObject("cmdPan.Image")));
            this.cmdPan.Location = new System.Drawing.Point(157, 294);
            this.cmdPan.Name = "cmdPan";
            this.cmdPan.Size = new System.Drawing.Size(38, 42);
            this.cmdPan.TabIndex = 46;
            this.cmdPan.UseVisualStyleBackColor = true;
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomOut.Image")));
            this.cmdZoomOut.Location = new System.Drawing.Point(113, 294);
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.Size = new System.Drawing.Size(38, 42);
            this.cmdZoomOut.TabIndex = 45;
            this.cmdZoomOut.UseVisualStyleBackColor = true;
            // 
            // cmdZoomIn
            // 
            this.cmdZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomIn.Image")));
            this.cmdZoomIn.Location = new System.Drawing.Point(69, 294);
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.Size = new System.Drawing.Size(38, 42);
            this.cmdZoomIn.TabIndex = 44;
            this.cmdZoomIn.UseVisualStyleBackColor = true;
            // 
            // cmdFullExtent
            // 
            this.cmdFullExtent.Image = ((System.Drawing.Image)(resources.GetObject("cmdFullExtent.Image")));
            this.cmdFullExtent.Location = new System.Drawing.Point(25, 294);
            this.cmdFullExtent.Name = "cmdFullExtent";
            this.cmdFullExtent.Size = new System.Drawing.Size(38, 42);
            this.cmdFullExtent.TabIndex = 43;
            this.cmdFullExtent.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 11);
            this.panel2.TabIndex = 4;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(416, 0);
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
            this.metroSetControlBox1.TabIndex = 5;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 27);
            this.button10.TabIndex = 4;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.txtY);
            this.panel3.Controls.Add(this.txtX);
            this.panel3.Controls.Add(this.cboKategori);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblY);
            this.panel3.Controls.Add(this.lblX);
            this.panel3.Controls.Add(this.RadioButton_Input);
            this.panel3.Controls.Add(this.RadioButton_Digitasi);
            this.panel3.Controls.Add(this.cmdSave);
            this.panel3.Controls.Add(this.cmdCancel);
            this.panel3.Controls.Add(this.txtIndex);
            this.panel3.Controls.Add(this.cmdBrowse);
            this.panel3.Controls.Add(this.txtFoto);
            this.panel3.Controls.Add(this.lblFoto);
            this.panel3.Controls.Add(this.txtSumber);
            this.panel3.Controls.Add(this.lblSumber);
            this.panel3.Controls.Add(this.lblKategori);
            this.panel3.Controls.Add(this.txtNamaAset);
            this.panel3.Controls.Add(this.lblNamaAset);
            this.panel3.Controls.Add(this.cmdPan);
            this.panel3.Controls.Add(this.cmdZoomOut);
            this.panel3.Controls.Add(this.cmdZoomIn);
            this.panel3.Controls.Add(this.cmdFullExtent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 535);
            this.panel3.TabIndex = 5;
            // 
            // cboKategori
            // 
            this.cboKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Location = new System.Drawing.Point(157, 371);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(371, 24);
            this.cboKategori.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 208);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.metroSetControlBox1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 37);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // FormAddPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddPoint";
            this.Text = "FormAddPoint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddPoint_FormClosing);
            this.Load += new System.EventHandler(this.FormAddPoint_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label lblY;
        internal System.Windows.Forms.Label lblX;
        internal System.Windows.Forms.RadioButton RadioButton_Input;
        internal System.Windows.Forms.RadioButton RadioButton_Digitasi;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.TextBox txtIndex;
        internal System.Windows.Forms.Button cmdBrowse;
        internal System.Windows.Forms.TextBox txtFoto;
        internal System.Windows.Forms.Label lblFoto;
        internal System.Windows.Forms.TextBox txtSumber;
        internal System.Windows.Forms.Label lblSumber;
        internal System.Windows.Forms.Label lblKategori;
        internal System.Windows.Forms.TextBox txtNamaAset;
        internal System.Windows.Forms.Label lblNamaAset;
        internal System.Windows.Forms.Button cmdPan;
        internal System.Windows.Forms.Button cmdZoomOut;
        internal System.Windows.Forms.Button cmdZoomIn;
        internal System.Windows.Forms.Button cmdFullExtent;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboKategori;
        internal System.Windows.Forms.TextBox txtY;
        internal System.Windows.Forms.TextBox txtX;
    }
}