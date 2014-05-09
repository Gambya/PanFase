using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PanFASE.com.merda.panfase.ADO
{
    class TConnect
    {
        private SQLiteConnection connect;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        private string source;
        private string banco;
        public string Sql { get; set; }
        public TConnect()
        {
            this.banco = "dbPanFase.s3db";
            if (!File.Exists(banco))
            {
                MessageBox.Show("Banco de dados " + this.banco + " não existe.");
                Application.Exit();
            }
            else
            {
                this.source = "Data Source=" + this.banco+";Version=3;";
            }
        }

        public long Inserir()
        {
            long id = 0;
            if (this.Sql != null)
            {
                try
                {
                    this.connect = new SQLiteConnection(this.source);
                    this.connect.Open();
                    this.cmd = this.connect.CreateCommand();
                    this.cmd.CommandText = this.Sql;
                    this.cmd.ExecuteNonQuery();
                    id = this.connect.LastInsertRowId;
                    this.connect.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Problemas ao conectar com banco de dados: " +e.Message+"\nStack: "+e.StackTrace+"\nSource: "+e.Source);
                    Application.Exit();
                }
            }
            return id;
        }

        public long UpdateSql()
        {
            long id = 0;
            if (this.Sql != null)
            {
                try
                {
                    this.connect = new SQLiteConnection(this.source);
                    this.connect.Open();
                    this.cmd = this.connect.CreateCommand();
                    this.cmd.CommandText = this.Sql;
                    this.cmd.ExecuteNonQuery();
                    id = this.connect.LastInsertRowId;
                    this.connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problemas ao conectar com banco de dados: " + e.Message);
                    Application.Exit();
                }
            }
            return id;
        }

        public DataTable selecionar()
        {
            DataTable dt = new DataTable();
            if (this.Sql != null)
            {
                try
                {
                    this.connect = new SQLiteConnection(this.source);
                    this.connect.Open();
                    this.cmd = this.connect.CreateCommand();
                    this.cmd.CommandText = this.Sql;
                    this.reader = this.cmd.ExecuteReader();
                    dt.Load(this.reader);
                    this.reader.Close();
                    this.connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problemas ao conectar com banco de dados: " + e.Message);
                    Application.Exit();
                }
            }
            return dt;
        }
    }
}
