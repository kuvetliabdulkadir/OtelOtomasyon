namespace otel_otomasyon.presentation_layer
{
    partial class fatura_yonetimi_form
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
            this.faturaDataGrifView = new System.Windows.Forms.DataGridView();
            this.geribtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faturaDataGrifView)).BeginInit();
            this.SuspendLayout();
            // 
            // faturaDataGrifView
            // 
            this.faturaDataGrifView.AllowUserToAddRows = false;
            this.faturaDataGrifView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.faturaDataGrifView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.faturaDataGrifView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faturaDataGrifView.Location = new System.Drawing.Point(105, 38);
            this.faturaDataGrifView.MultiSelect = false;
            this.faturaDataGrifView.Name = "faturaDataGrifView";
            this.faturaDataGrifView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.faturaDataGrifView.Size = new System.Drawing.Size(562, 264);
            this.faturaDataGrifView.TabIndex = 0;
            this.faturaDataGrifView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.faturaDataGrifView_CellDoubleClick);
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
            // fatura_yonetimi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.faturaDataGrifView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fatura_yonetimi_form";
            this.Text = "FATURA GÖRÜNTÜLE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            this.Load += new System.EventHandler(this.fatura_yonetimi_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faturaDataGrifView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView faturaDataGrifView;
        private System.Windows.Forms.Button geribtn;
    }
}