namespace szemelyzetGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            rb_mindenki = new RadioButton();
            rb_kileptek = new RadioButton();
            rb_aktiv = new RadioButton();
            DGV = new DataGridView();
            dolgozoneve = new DataGridViewTextBoxColumn();
            szulido = new DataGridViewTextBoxColumn();
            eletkor = new DataGridViewTextBoxColumn();
            fizetes = new DataGridViewTextBoxColumn();
            bedatum = new DataGridViewTextBoxColumn();
            beosztas = new DataGridViewTextBoxColumn();
            kidatum = new DataGridViewTextBoxColumn();
            telephely = new DataGridViewTextBoxColumn();
            tb_kereses = new TextBox();
            panel1 = new Panel();
            l_atlagber = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 77);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Keresés";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleTurquoise;
            groupBox1.Controls.Add(rb_mindenki);
            groupBox1.Controls.Add(rb_kileptek);
            groupBox1.Controls.Add(rb_aktiv);
            groupBox1.Location = new Point(588, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Státusz";
            // 
            // rb_mindenki
            // 
            rb_mindenki.AutoSize = true;
            rb_mindenki.Location = new Point(6, 72);
            rb_mindenki.Name = "rb_mindenki";
            rb_mindenki.Size = new Size(77, 19);
            rb_mindenki.TabIndex = 0;
            rb_mindenki.TabStop = true;
            rb_mindenki.Text = "Mindenki";
            rb_mindenki.UseVisualStyleBackColor = true;
            rb_mindenki.CheckedChanged += rb_mindenki_CheckedChanged;
            // 
            // rb_kileptek
            // 
            rb_kileptek.AutoSize = true;
            rb_kileptek.Location = new Point(6, 47);
            rb_kileptek.Name = "rb_kileptek";
            rb_kileptek.Size = new Size(72, 19);
            rb_kileptek.TabIndex = 0;
            rb_kileptek.TabStop = true;
            rb_kileptek.Text = "Kiléptek";
            rb_kileptek.UseVisualStyleBackColor = true;
            rb_kileptek.CheckedChanged += rb_kileptek_CheckedChanged;
            // 
            // rb_aktiv
            // 
            rb_aktiv.AutoSize = true;
            rb_aktiv.Location = new Point(6, 22);
            rb_aktiv.Name = "rb_aktiv";
            rb_aktiv.Size = new Size(68, 19);
            rb_aktiv.TabIndex = 0;
            rb_aktiv.TabStop = true;
            rb_aktiv.Text = "Aktívak";
            rb_aktiv.UseVisualStyleBackColor = true;
            rb_aktiv.CheckedChanged += rb_aktiv_CheckedChanged;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { dolgozoneve, szulido, eletkor, fizetes, bedatum, beosztas, kidatum, telephely });
            DGV.Location = new Point(12, 118);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(843, 236);
            DGV.TabIndex = 2;
            // 
            // dolgozoneve
            // 
            dolgozoneve.HeaderText = "Dolgozó neve";
            dolgozoneve.Name = "dolgozoneve";
            dolgozoneve.ReadOnly = true;
            // 
            // szulido
            // 
            szulido.HeaderText = "Születési idő";
            szulido.Name = "szulido";
            szulido.ReadOnly = true;
            // 
            // eletkor
            // 
            eletkor.HeaderText = "Életkor";
            eletkor.Name = "eletkor";
            eletkor.ReadOnly = true;
            // 
            // fizetes
            // 
            fizetes.HeaderText = "Fizetés";
            fizetes.Name = "fizetes";
            fizetes.ReadOnly = true;
            // 
            // bedatum
            // 
            bedatum.HeaderText = "Belépés dátuma";
            bedatum.Name = "bedatum";
            bedatum.ReadOnly = true;
            // 
            // beosztas
            // 
            beosztas.HeaderText = "Beosztás";
            beosztas.Name = "beosztas";
            beosztas.ReadOnly = true;
            // 
            // kidatum
            // 
            kidatum.HeaderText = "Kilépés dátuma";
            kidatum.Name = "kidatum";
            kidatum.ReadOnly = true;
            // 
            // telephely
            // 
            telephely.HeaderText = "Telephely neve";
            telephely.Name = "telephely";
            telephely.ReadOnly = true;
            // 
            // tb_kereses
            // 
            tb_kereses.Location = new Point(102, 74);
            tb_kereses.Name = "tb_kereses";
            tb_kereses.Size = new Size(140, 23);
            tb_kereses.TabIndex = 3;
            tb_kereses.TextChanged += tb_kereses_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(l_atlagber);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 360);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 78);
            panel1.TabIndex = 4;
            // 
            // l_atlagber
            // 
            l_atlagber.AutoSize = true;
            l_atlagber.Location = new Point(172, 35);
            l_atlagber.Name = "l_atlagber";
            l_atlagber.Size = new Size(26, 15);
            l_atlagber.TabIndex = 0;
            l_atlagber.Text = "- Ft";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 35);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 0;
            label2.Text = "A dolgozók átlag fizetése:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(867, 450);
            Controls.Add(panel1);
            Controls.Add(tb_kereses);
            Controls.Add(DGV);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "Form1";
            Text = "Dolgozói adatok";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rb_mindenki;
        private RadioButton rb_kileptek;
        private RadioButton rb_aktiv;
        private DataGridView DGV;
        private TextBox tb_kereses;
        private Panel panel1;
        private Label l_atlagber;
        private Label label2;
        private DataGridViewTextBoxColumn dolgozoneve;
        private DataGridViewTextBoxColumn szulido;
        private DataGridViewTextBoxColumn eletkor;
        private DataGridViewTextBoxColumn fizetes;
        private DataGridViewTextBoxColumn bedatum;
        private DataGridViewTextBoxColumn beosztas;
        private DataGridViewTextBoxColumn kidatum;
        private DataGridViewTextBoxColumn telephely;
    }
}
