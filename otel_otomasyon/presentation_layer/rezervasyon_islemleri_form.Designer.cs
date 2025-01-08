namespace otel_otomasyon.presentation_layer
{
    partial class rezervasyon_islemleri_form
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
            this.rzvDataGridView = new System.Windows.Forms.DataGridView();
            this.rzvsilbtn = new System.Windows.Forms.Button();
            this.geribtn = new System.Windows.Forms.Button();
            this.rzvolusturyonlendirbrn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rzvDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rzvDataGridView
            // 
            this.rzvDataGridView.AllowUserToAddRows = false;
            this.rzvDataGridView.AllowUserToDeleteRows = false;
            this.rzvDataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.rzvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rzvDataGridView.GridColor = System.Drawing.Color.FloralWhite;
            this.rzvDataGridView.Location = new System.Drawing.Point(60, 30);
            this.rzvDataGridView.MultiSelect = false;
            this.rzvDataGridView.Name = "rzvDataGridView";
            this.rzvDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rzvDataGridView.Size = new System.Drawing.Size(654, 182);
            this.rzvDataGridView.TabIndex = 0;
            // 
            // rzvsilbtn
            // 
            this.rzvsilbtn.BackColor = System.Drawing.Color.Transparent;
            this.rzvsilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rzvsilbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rzvsilbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rzvsilbtn.Location = new System.Drawing.Point(539, 231);
            this.rzvsilbtn.Name = "rzvsilbtn";
            this.rzvsilbtn.Size = new System.Drawing.Size(139, 41);
            this.rzvsilbtn.TabIndex = 1;
            this.rzvsilbtn.Text = "SİL";
            this.rzvsilbtn.UseVisualStyleBackColor = false;
            this.rzvsilbtn.Click += new System.EventHandler(this.rzvsilbtn_Click);
            // 
            // geribtn
            // 
            this.geribtn.BackColor = System.Drawing.Color.FloralWhite;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geribtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geribtn.Location = new System.Drawing.Point(12, 386);
            this.geribtn.Name = "geribtn";
            this.geribtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geribtn.Size = new System.Drawing.Size(93, 52);
            this.geribtn.TabIndex = 14;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = false;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // rzvolusturyonlendirbrn
            // 
            this.rzvolusturyonlendirbrn.BackColor = System.Drawing.Color.Transparent;
            this.rzvolusturyonlendirbrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rzvolusturyonlendirbrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rzvolusturyonlendirbrn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rzvolusturyonlendirbrn.Location = new System.Drawing.Point(123, 231);
            this.rzvolusturyonlendirbrn.Name = "rzvolusturyonlendirbrn";
            this.rzvolusturyonlendirbrn.Size = new System.Drawing.Size(156, 41);
            this.rzvolusturyonlendirbrn.TabIndex = 15;
            this.rzvolusturyonlendirbrn.Text = "REZERVASYON OLUŞTUR";
            this.rzvolusturyonlendirbrn.UseVisualStyleBackColor = false;
            this.rzvolusturyonlendirbrn.Click += new System.EventHandler(this.rzvolusturyonlendirbrn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(163, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 125);
            this.label1.TabIndex = 16;
            this.label1.Text = " MAVİ  PERA OTEL";
            // 
            // rezervasyon_islemleri_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rzvolusturyonlendirbrn);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.rzvsilbtn);
            this.Controls.Add(this.rzvDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rezervasyon_islemleri_form";
            this.Text = "REZERVASYON İŞLEMLERİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            this.Load += new System.EventHandler(this.rezervasyon_islemleri_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rzvDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rzvDataGridView;
        private System.Windows.Forms.Button rzvsilbtn;
        private System.Windows.Forms.Button geribtn;
        private System.Windows.Forms.Button rzvolusturyonlendirbrn;
        private System.Windows.Forms.Label label1;
    }
}