namespace otel_otomasyon.presentation_layer
{
    partial class musteri_rezervasyon_form
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
            this.mstrrzvDatagridView = new System.Windows.Forms.DataGridView();
            this.mstrzvrsilbtn = new System.Windows.Forms.Button();
            this.geribtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mstrrzvDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mstrrzvDatagridView
            // 
            this.mstrrzvDatagridView.AllowUserToAddRows = false;
            this.mstrrzvDatagridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.mstrrzvDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mstrrzvDatagridView.Location = new System.Drawing.Point(104, 21);
            this.mstrrzvDatagridView.MultiSelect = false;
            this.mstrrzvDatagridView.Name = "mstrrzvDatagridView";
            this.mstrrzvDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mstrrzvDatagridView.Size = new System.Drawing.Size(539, 229);
            this.mstrrzvDatagridView.TabIndex = 0;
            // 
            // mstrzvrsilbtn
            // 
            this.mstrzvrsilbtn.BackColor = System.Drawing.Color.Transparent;
            this.mstrzvrsilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mstrzvrsilbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mstrzvrsilbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mstrzvrsilbtn.Location = new System.Drawing.Point(336, 276);
            this.mstrzvrsilbtn.Name = "mstrzvrsilbtn";
            this.mstrzvrsilbtn.Size = new System.Drawing.Size(82, 48);
            this.mstrzvrsilbtn.TabIndex = 4;
            this.mstrzvrsilbtn.Text = "SİL";
            this.mstrzvrsilbtn.UseVisualStyleBackColor = false;
            this.mstrzvrsilbtn.Click += new System.EventHandler(this.mstrzvrsilbtn_Click);
            // 
            // geribtn
            // 
            this.geribtn.BackColor = System.Drawing.Color.Transparent;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.geribtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geribtn.Location = new System.Drawing.Point(12, 386);
            this.geribtn.Name = "geribtn";
            this.geribtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geribtn.Size = new System.Drawing.Size(93, 52);
            this.geribtn.TabIndex = 15;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = false;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // musteri_rezervasyon_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.mstrzvrsilbtn);
            this.Controls.Add(this.mstrrzvDatagridView);
            this.Name = "musteri_rezervasyon_form";
            this.Text = "MÜŞTERİNİN REZERVASYONLARI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            this.Load += new System.EventHandler(this.musteri_rezervasyon_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mstrrzvDatagridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mstrrzvDatagridView;
        private System.Windows.Forms.Button mstrzvrsilbtn;
        private System.Windows.Forms.Button geribtn;
    }
}