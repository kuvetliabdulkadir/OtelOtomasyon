namespace otel_otomasyon.presentation_layer
{
    partial class oda_yonetimi_form
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
            this.odaeklebtn = new System.Windows.Forms.Button();
            this.odanumaratxt = new System.Windows.Forms.TextBox();
            this.odafiyattxt = new System.Windows.Forms.TextBox();
            this.odaeklegrpbox = new System.Windows.Forms.GroupBox();
            this.odadurumtxt = new System.Windows.Forms.TextBox();
            this.odatipitxt = new System.Windows.Forms.TextBox();
            this.odadurumbtn = new System.Windows.Forms.Button();
            this.odaDataGridView = new System.Windows.Forms.DataGridView();
            this.odasilbtn = new System.Windows.Forms.Button();
            this.geribtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.odaduzenlebtn = new System.Windows.Forms.Button();
            this.odaeklegrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // odaeklebtn
            // 
            this.odaeklebtn.BackColor = System.Drawing.Color.Transparent;
            this.odaeklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaeklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaeklebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.odaeklebtn.Location = new System.Drawing.Point(27, 292);
            this.odaeklebtn.Name = "odaeklebtn";
            this.odaeklebtn.Size = new System.Drawing.Size(147, 39);
            this.odaeklebtn.TabIndex = 0;
            this.odaeklebtn.Text = "ODA EKLE";
            this.odaeklebtn.UseVisualStyleBackColor = false;
            this.odaeklebtn.Click += new System.EventHandler(this.odaeklebtn_Click);
            // 
            // odanumaratxt
            // 
            this.odanumaratxt.ForeColor = System.Drawing.Color.Gray;
            this.odanumaratxt.Location = new System.Drawing.Point(15, 37);
            this.odanumaratxt.Multiline = true;
            this.odanumaratxt.Name = "odanumaratxt";
            this.odanumaratxt.Size = new System.Drawing.Size(143, 36);
            this.odanumaratxt.TabIndex = 1;
            this.odanumaratxt.Text = "Oda Numarası";
            this.odanumaratxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // odafiyattxt
            // 
            this.odafiyattxt.ForeColor = System.Drawing.Color.Gray;
            this.odafiyattxt.Location = new System.Drawing.Point(15, 203);
            this.odafiyattxt.Multiline = true;
            this.odafiyattxt.Name = "odafiyattxt";
            this.odafiyattxt.Size = new System.Drawing.Size(143, 38);
            this.odafiyattxt.TabIndex = 3;
            this.odafiyattxt.Text = "Oda Fiyat";
            this.odafiyattxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // odaeklegrpbox
            // 
            this.odaeklegrpbox.BackColor = System.Drawing.Color.Transparent;
            this.odaeklegrpbox.Controls.Add(this.odadurumtxt);
            this.odaeklegrpbox.Controls.Add(this.odatipitxt);
            this.odaeklegrpbox.Controls.Add(this.odafiyattxt);
            this.odaeklegrpbox.Controls.Add(this.odanumaratxt);
            this.odaeklegrpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaeklegrpbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.odaeklegrpbox.Location = new System.Drawing.Point(12, 12);
            this.odaeklegrpbox.Name = "odaeklegrpbox";
            this.odaeklegrpbox.Size = new System.Drawing.Size(189, 274);
            this.odaeklegrpbox.TabIndex = 5;
            this.odaeklegrpbox.TabStop = false;
            this.odaeklegrpbox.Text = "Oda Ekle";
            this.odaeklegrpbox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.odaeklegrpbox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // odadurumtxt
            // 
            this.odadurumtxt.ForeColor = System.Drawing.Color.Gray;
            this.odadurumtxt.Location = new System.Drawing.Point(15, 152);
            this.odadurumtxt.Multiline = true;
            this.odadurumtxt.Name = "odadurumtxt";
            this.odadurumtxt.Size = new System.Drawing.Size(143, 35);
            this.odadurumtxt.TabIndex = 5;
            this.odadurumtxt.Text = "Available";
            this.odadurumtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.odadurumtxt.TextChanged += new System.EventHandler(this.odadurumtxt_TextChanged);
            // 
            // odatipitxt
            // 
            this.odatipitxt.ForeColor = System.Drawing.Color.Gray;
            this.odatipitxt.Location = new System.Drawing.Point(15, 95);
            this.odatipitxt.Multiline = true;
            this.odatipitxt.Name = "odatipitxt";
            this.odatipitxt.Size = new System.Drawing.Size(143, 34);
            this.odatipitxt.TabIndex = 4;
            this.odatipitxt.Text = "Oda Tipi";
            this.odatipitxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // odadurumbtn
            // 
            this.odadurumbtn.BackColor = System.Drawing.Color.Transparent;
            this.odadurumbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odadurumbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odadurumbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.odadurumbtn.Location = new System.Drawing.Point(210, 247);
            this.odadurumbtn.Name = "odadurumbtn";
            this.odadurumbtn.Size = new System.Drawing.Size(147, 39);
            this.odadurumbtn.TabIndex = 7;
            this.odadurumbtn.Text = "ODA DURUMUNU DEĞİŞTİR";
            this.odadurumbtn.UseVisualStyleBackColor = false;
            this.odadurumbtn.Click += new System.EventHandler(this.odauygunbtn_Click);
            // 
            // odaDataGridView
            // 
            this.odaDataGridView.AllowUserToAddRows = false;
            this.odaDataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.odaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odaDataGridView.GridColor = System.Drawing.Color.FloralWhite;
            this.odaDataGridView.Location = new System.Drawing.Point(210, 12);
            this.odaDataGridView.MultiSelect = false;
            this.odaDataGridView.Name = "odaDataGridView";
            this.odaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.odaDataGridView.Size = new System.Drawing.Size(565, 220);
            this.odaDataGridView.TabIndex = 9;
            this.odaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // odasilbtn
            // 
            this.odasilbtn.BackColor = System.Drawing.Color.Transparent;
            this.odasilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odasilbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odasilbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.odasilbtn.Location = new System.Drawing.Point(657, 247);
            this.odasilbtn.Name = "odasilbtn";
            this.odasilbtn.Size = new System.Drawing.Size(118, 39);
            this.odasilbtn.TabIndex = 11;
            this.odasilbtn.Text = "ODAYI SİL";
            this.odasilbtn.UseVisualStyleBackColor = false;
            this.odasilbtn.Click += new System.EventHandler(this.odasilbtn_Click);
            // 
            // geribtn
            // 
            this.geribtn.BackColor = System.Drawing.Color.FloralWhite;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geribtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geribtn.Location = new System.Drawing.Point(22, 374);
            this.geribtn.Name = "geribtn";
            this.geribtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geribtn.Size = new System.Drawing.Size(93, 52);
            this.geribtn.TabIndex = 13;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = false;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(190, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 125);
            this.label1.TabIndex = 14;
            this.label1.Text = " MAVİ PERA OTEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // odaduzenlebtn
            // 
            this.odaduzenlebtn.BackColor = System.Drawing.Color.Transparent;
            this.odaduzenlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaduzenlebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaduzenlebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.odaduzenlebtn.Location = new System.Drawing.Point(424, 247);
            this.odaduzenlebtn.Name = "odaduzenlebtn";
            this.odaduzenlebtn.Size = new System.Drawing.Size(136, 39);
            this.odaduzenlebtn.TabIndex = 15;
            this.odaduzenlebtn.Text = "DÜZENLE";
            this.odaduzenlebtn.UseVisualStyleBackColor = false;
            this.odaduzenlebtn.Click += new System.EventHandler(this.odaduzenlebtn_Click);
            // 
            // oda_yonetimi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.odaduzenlebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.odasilbtn);
            this.Controls.Add(this.odaDataGridView);
            this.Controls.Add(this.odadurumbtn);
            this.Controls.Add(this.odaeklegrpbox);
            this.Controls.Add(this.odaeklebtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "oda_yonetimi_form";
            this.Text = "ODA YÖNETİMİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            this.Load += new System.EventHandler(this.oda_yonetimi_form_Load);
            this.odaeklegrpbox.ResumeLayout(false);
            this.odaeklegrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odaeklebtn;
        private System.Windows.Forms.TextBox odanumaratxt;
        private System.Windows.Forms.TextBox odafiyattxt;
        private System.Windows.Forms.GroupBox odaeklegrpbox;
        private System.Windows.Forms.TextBox odadurumtxt;
        private System.Windows.Forms.TextBox odatipitxt;
        private System.Windows.Forms.Button odadurumbtn;
        private System.Windows.Forms.DataGridView odaDataGridView;
        private System.Windows.Forms.Button odasilbtn;
        private System.Windows.Forms.Button geribtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odaduzenlebtn;
    }
}