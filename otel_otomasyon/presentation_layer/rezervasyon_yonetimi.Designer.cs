namespace otel_otomasyon.presentation_layer
{
    partial class rezervasyon_yonetimi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mstridtxt = new System.Windows.Forms.TextBox();
            this.uygunodagetirbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.checkInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rzvolusturbtn = new System.Windows.Forms.Button();
            this.odaUygunDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odaUygunDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mstridtxt);
            this.groupBox1.Controls.Add(this.uygunodagetirbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkOutDatePicker);
            this.groupBox1.Controls.Add(this.checkInDatePicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Tarih Seçimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(479, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri ID";
            // 
            // mstridtxt
            // 
            this.mstridtxt.Enabled = false;
            this.mstridtxt.Location = new System.Drawing.Point(482, 59);
            this.mstridtxt.Multiline = true;
            this.mstridtxt.Name = "mstridtxt";
            this.mstridtxt.Size = new System.Drawing.Size(130, 31);
            this.mstridtxt.TabIndex = 5;
            // 
            // uygunodagetirbtn
            // 
            this.uygunodagetirbtn.BackColor = System.Drawing.Color.Transparent;
            this.uygunodagetirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uygunodagetirbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uygunodagetirbtn.Location = new System.Drawing.Point(240, 125);
            this.uygunodagetirbtn.Name = "uygunodagetirbtn";
            this.uygunodagetirbtn.Size = new System.Drawing.Size(224, 47);
            this.uygunodagetirbtn.TabIndex = 3;
            this.uygunodagetirbtn.Text = "UYGUN ODALARI GETİR";
            this.uygunodagetirbtn.UseVisualStyleBackColor = false;
            this.uygunodagetirbtn.Click += new System.EventHandler(this.uygunodagetirbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(51, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ÇIKIŞ TARİHİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "GİRİŞ TARİHİ:";
            // 
            // checkOutDatePicker
            // 
            this.checkOutDatePicker.Location = new System.Drawing.Point(204, 78);
            this.checkOutDatePicker.Name = "checkOutDatePicker";
            this.checkOutDatePicker.Size = new System.Drawing.Size(223, 21);
            this.checkOutDatePicker.TabIndex = 2;
            this.checkOutDatePicker.ValueChanged += new System.EventHandler(this.checkOutDatePicker_ValueChanged);
            // 
            // checkInDatePicker
            // 
            this.checkInDatePicker.CustomFormat = "";
            this.checkInDatePicker.Location = new System.Drawing.Point(204, 25);
            this.checkInDatePicker.Name = "checkInDatePicker";
            this.checkInDatePicker.Size = new System.Drawing.Size(223, 21);
            this.checkInDatePicker.TabIndex = 1;
            this.checkInDatePicker.ValueChanged += new System.EventHandler(this.checkInDatePicker_ValueChanged);
            // 
            // rzvolusturbtn
            // 
            this.rzvolusturbtn.BackColor = System.Drawing.Color.Transparent;
            this.rzvolusturbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rzvolusturbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rzvolusturbtn.Location = new System.Drawing.Point(318, 394);
            this.rzvolusturbtn.Name = "rzvolusturbtn";
            this.rzvolusturbtn.Size = new System.Drawing.Size(176, 44);
            this.rzvolusturbtn.TabIndex = 2;
            this.rzvolusturbtn.Text = "REZERVASYON OLUŞTUR";
            this.rzvolusturbtn.UseVisualStyleBackColor = false;
            this.rzvolusturbtn.Click += new System.EventHandler(this.rzvolusturbtn_Click);
            // 
            // odaUygunDataGridView
            // 
            this.odaUygunDataGridView.AllowUserToAddRows = false;
            this.odaUygunDataGridView.AllowUserToDeleteRows = false;
            this.odaUygunDataGridView.AllowUserToResizeColumns = false;
            this.odaUygunDataGridView.AllowUserToResizeRows = false;
            this.odaUygunDataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.odaUygunDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odaUygunDataGridView.GridColor = System.Drawing.Color.FloralWhite;
            this.odaUygunDataGridView.Location = new System.Drawing.Point(118, 206);
            this.odaUygunDataGridView.MultiSelect = false;
            this.odaUygunDataGridView.Name = "odaUygunDataGridView";
            this.odaUygunDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.odaUygunDataGridView.Size = new System.Drawing.Size(552, 181);
            this.odaUygunDataGridView.TabIndex = 8;
            // 
            // rezervasyon_yonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odaUygunDataGridView);
            this.Controls.Add(this.rzvolusturbtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rezervasyon_yonetimi";
            this.Text = "REZERVASYON İŞLEMLERİ";
            this.Load += new System.EventHandler(this.rezervasyon_yonetimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odaUygunDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker checkOutDatePicker;
        private System.Windows.Forms.DateTimePicker checkInDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uygunodagetirbtn;
        private System.Windows.Forms.Button rzvolusturbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mstridtxt;
        private System.Windows.Forms.DataGridView odaUygunDataGridView;
    }
}