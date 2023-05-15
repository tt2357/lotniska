namespace lotniska
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.woj = new System.Windows.Forms.CheckBox();
            this.ICAO = new System.Windows.Forms.CheckBox();
            this.IATA = new System.Windows.Forms.CheckBox();
            this.nazwa = new System.Windows.Forms.CheckBox();
            this.lpas = new System.Windows.Forms.CheckBox();
            this.zmiana = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(442, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // woj
            // 
            this.woj.AutoSize = true;
            this.woj.Location = new System.Drawing.Point(575, 44);
            this.woj.Name = "woj";
            this.woj.Size = new System.Drawing.Size(112, 20);
            this.woj.TabIndex = 1;
            this.woj.Text = "Województwo";
            this.woj.UseVisualStyleBackColor = true;
            this.woj.CheckedChanged += new System.EventHandler(this.woj_CheckedChanged);
            // 
            // ICAO
            // 
            this.ICAO.AutoSize = true;
            this.ICAO.Location = new System.Drawing.Point(575, 90);
            this.ICAO.Name = "ICAO";
            this.ICAO.Size = new System.Drawing.Size(60, 20);
            this.ICAO.TabIndex = 2;
            this.ICAO.Text = "ICAO";
            this.ICAO.UseVisualStyleBackColor = true;
            this.ICAO.CheckedChanged += new System.EventHandler(this.ICAO_CheckedChanged);
            // 
            // IATA
            // 
            this.IATA.AutoSize = true;
            this.IATA.Location = new System.Drawing.Point(575, 143);
            this.IATA.Name = "IATA";
            this.IATA.Size = new System.Drawing.Size(59, 20);
            this.IATA.TabIndex = 4;
            this.IATA.Text = "IATA";
            this.IATA.UseVisualStyleBackColor = true;
            this.IATA.CheckedChanged += new System.EventHandler(this.IATA_CheckedChanged);
            // 
            // nazwa
            // 
            this.nazwa.AutoSize = true;
            this.nazwa.Location = new System.Drawing.Point(575, 194);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(69, 20);
            this.nazwa.TabIndex = 3;
            this.nazwa.Text = "Miasto";
            this.nazwa.UseVisualStyleBackColor = true;
            this.nazwa.CheckedChanged += new System.EventHandler(this.nazwa_CheckedChanged);
            // 
            // lpas
            // 
            this.lpas.AutoSize = true;
            this.lpas.Location = new System.Drawing.Point(575, 244);
            this.lpas.Name = "lpas";
            this.lpas.Size = new System.Drawing.Size(162, 20);
            this.lpas.TabIndex = 6;
            this.lpas.Text = "Ofic. liczba pasażerów";
            this.lpas.UseVisualStyleBackColor = true;
            this.lpas.CheckedChanged += new System.EventHandler(this.lpas_CheckedChanged);
            // 
            // zmiana
            // 
            this.zmiana.AutoSize = true;
            this.zmiana.Location = new System.Drawing.Point(575, 297);
            this.zmiana.Name = "zmiana";
            this.zmiana.Size = new System.Drawing.Size(145, 20);
            this.zmiana.TabIndex = 5;
            this.zmiana.Text = "Zmiana (2018-2019)";
            this.zmiana.UseVisualStyleBackColor = true;
            this.zmiana.CheckedChanged += new System.EventHandler(this.zmiana_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pokaż";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lpas);
            this.Controls.Add(this.zmiana);
            this.Controls.Add(this.IATA);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.ICAO);
            this.Controls.Add(this.woj);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox woj;
        private System.Windows.Forms.CheckBox ICAO;
        private System.Windows.Forms.CheckBox IATA;
        private System.Windows.Forms.CheckBox nazwa;
        private System.Windows.Forms.CheckBox lpas;
        private System.Windows.Forms.CheckBox zmiana;
        private System.Windows.Forms.Button button1;
    }
}

