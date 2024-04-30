using System.Windows.Forms;

namespace szemelyzetGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_mindenki.Checked = true;
        }
        private void DGVLoad()
        {
            DGV.Rows.Clear();
            if (rb_mindenki.Checked)
            {
                Database db = new Database("SELECT szemelytorzs.nev as szemelynev, szulido, ROUND(DATEDIFF(CURDATE(),szulido)) as eletkor, fizetes, belepdatum, beosztas, kilepdatum, telephelytorzs.nev as telepnev FROM szemelytorzs, szemely_telep, telephelytorzs WHERE szemelytorzs.szemid = szemely_telep.szemid AND szemely_telep.tid = telephelytorzs.tid");
                while (db.Dr.Read())
                {
                    //string beosztas = db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi":"Vezetõi";
                    DGV.Rows.Add(db.Dr["szemelynev"], db.Dr["szulido"], db.Dr["eletkor"], db.Dr["fizetes"], db.Dr["belepdatum"], db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi" : "Vezetõi", db.Dr["kilepdatum"], db.Dr["telepnev"]);
                }
                l_atlagber.Text = DGV.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList().Average(x => (int)x[3]).ToString();
            }
            else if (rb_aktiv.Checked)
            {
                Database db = new Database("SELECT szemelytorzs.nev as szemelynev, szulido, ROUND(DATEDIFF(CURDATE(),szulido)) as eletkor, fizetes, belepdatum, beosztas, kilepdatum, telephelytorzs.nev as telepnev FROM szemelytorzs, szemely_telep, telephelytorzs WHERE szemelytorzs.szemid = szemely_telep.szemid AND szemely_telep.tid = telephelytorzs.tid AND kilepdatum is null");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["szemelynev"], db.Dr["szulido"], db.Dr["eletkor"], db.Dr["fizetes"], db.Dr["belepdatum"], db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi" : "Vezetõi", db.Dr["kilepdatum"], db.Dr["telepnev"]);
                }
                l_atlagber.Text = DGV.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList().Average(x => (int)x[3]).ToString();
            }
            else
            {
                Database db = new Database("SELECT szemelytorzs.nev as szemelynev, szulido, ROUND(DATEDIFF(CURDATE(),szulido)) as eletkor, fizetes, belepdatum, beosztas, kilepdatum, telephelytorzs.nev as telepnev FROM szemelytorzs, szemely_telep, telephelytorzs WHERE szemelytorzs.szemid = szemely_telep.szemid AND szemely_telep.tid = telephelytorzs.tid AND kilepdatum is not null");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["szemelynev"], db.Dr["szulido"], db.Dr["eletkor"], db.Dr["fizetes"], db.Dr["belepdatum"], db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi" : "Vezetõi", db.Dr["kilepdatum"], db.Dr["telepnev"]);
                }
                l_atlagber.Text = DGV.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList().Average(x => (int)x[3]).ToString();
            }
        }

        private void DGVLoad(string search)
        {
            DGV.Rows.Clear();
            if (rb_mindenki.Checked)
            {
                Database db = new Database($"SELECT szemelytorzs.nev as szemelynev, szulido, ROUND(DATEDIFF(CURDATE(),szulido)) as eletkor, fizetes, belepdatum, beosztas, kilepdatum, telephelytorzs.nev as telepnev FROM szemelytorzs, szemely_telep, telephelytorzs WHERE szemelytorzs.szemid = szemely_telep.szemid AND szemely_telep.tid = telephelytorzs.tid AND szemelytorzs.nev LIKE '{search}%'");
                while (db.Dr.Read())
                {
                    //string beosztas = db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi":"Vezetõi";
                    DGV.Rows.Add(db.Dr["szemelynev"], db.Dr["szulido"], db.Dr["eletkor"], db.Dr["fizetes"], db.Dr["belepdatum"], db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi" : "Vezetõi", db.Dr["kilepdatum"], db.Dr["telepnev"]);
                }
                l_atlagber.Text = DGV.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList().Average(x => (int)x[3]).ToString();
            }
            else if (rb_aktiv.Checked)
            {
                Database db = new Database($"SELECT szemelytorzs.nev as szemelynev, szulido, ROUND(DATEDIFF(CURDATE(),szulido)) as eletkor, fizetes, belepdatum, beosztas, kilepdatum, telephelytorzs.nev as telepnev FROM szemelytorzs, szemely_telep, telephelytorzs WHERE szemelytorzs.szemid = szemely_telep.szemid AND szemely_telep.tid = telephelytorzs.tid AND kilepdatum is null AND szemelytorzs.nev LIKE '{search}%'");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["szemelynev"], db.Dr["szulido"], db.Dr["eletkor"], db.Dr["fizetes"], db.Dr["belepdatum"], db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi" : "Vezetõi", db.Dr["kilepdatum"], db.Dr["telepnev"]);
                }
                l_atlagber.Text = DGV.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList().Average(x => (int)x[3]).ToString();
            }
            else
            {
                Database db = new Database($"SELECT szemelytorzs.nev as szemelynev, szulido, ROUND(DATEDIFF(CURDATE(),szulido)) as eletkor, fizetes, belepdatum, beosztas, kilepdatum, telephelytorzs.nev as telepnev FROM szemelytorzs, szemely_telep, telephelytorzs WHERE szemelytorzs.szemid = szemely_telep.szemid AND szemely_telep.tid = telephelytorzs.tid AND kilepdatum is not null AND szemelytorzs.nev LIKE '{search}%'");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["szemelynev"], db.Dr["szulido"], db.Dr["eletkor"], db.Dr["fizetes"], db.Dr["belepdatum"], db.Dr["beosztas"].ToString() == "f" ? "fizikai" : db.Dr["beosztas"].ToString() == "s" ? "Szellemi" : "Vezetõi", db.Dr["kilepdatum"], db.Dr["telepnev"]);
                }
                l_atlagber.Text = DGV.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList().Average(x => (int)x[3]).ToString();
            }
        }

        private void rb_mindenki_CheckedChanged(object sender, EventArgs e)
        {
            DGVLoad();
        }


        private void rb_kileptek_CheckedChanged(object sender, EventArgs e)
        {
            DGVLoad();
        }

        private void rb_aktiv_CheckedChanged(object sender, EventArgs e)
        {
            DGVLoad();
        }

        private void tb_kereses_TextChanged(object sender, EventArgs e)
        {
            if (tb_kereses.Text!="")
            {
                DGVLoad(tb_kereses.Text);
            }
            else
            {
                DGVLoad();
            }
        }
    }
}
