using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;


namespace PanFase.Data
{
    class AcessoDados
    {
        private SQLiteConnection sQLiteConnection;
        private SQLiteCommand sQLiteCommand;
        private SQLiteDataReader sQLiteDataReader;
        private string source;
        private string banco;
        public string Sql { get; set; }
        public AcessoDados()
        {
            banco = "dbPanFase.s3db";
            if (!File.Exists(banco))
            {
                MessageBox.Show("Banco de dados " + banco + " não existe.");
                Application.Exit();
            }
            else
            {
                source = "Data Source=" + banco +";Version=3;";
            }
        }

        public long Inserir()
        {
            long id = 0;
            if (Sql != null)
            {
                try
                {
                    sQLiteConnection = new SQLiteConnection(source);
                    sQLiteConnection.Open();
                    sQLiteCommand = sQLiteConnection.CreateCommand();
                    sQLiteCommand.CommandText = Sql;
                    sQLiteCommand.ExecuteNonQuery();
                    id = sQLiteConnection.LastInsertRowId;
                    this.sQLiteConnection.Close();
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
            if (Sql != null)
            {
                try
                {
                    sQLiteConnection = new SQLiteConnection(source);
                    sQLiteConnection.Open();
                    sQLiteCommand = sQLiteConnection.CreateCommand();
                    sQLiteCommand.CommandText = Sql;
                    sQLiteCommand.ExecuteNonQuery();
                    id = sQLiteConnection.LastInsertRowId;
                    this.sQLiteConnection.Close();
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
            var dataTable = new DataTable();
            if (this.Sql != null)
            {
                try
                {
                    sQLiteConnection = new SQLiteConnection(source);
                    sQLiteConnection.Open();
                    sQLiteCommand = sQLiteConnection.CreateCommand();
                    sQLiteCommand.CommandText = Sql;
                    sQLiteDataReader = sQLiteCommand.ExecuteReader();
                    dataTable.Load(sQLiteDataReader);
                    this.sQLiteDataReader.Close();
                    this.sQLiteConnection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problemas ao conectar com banco de dados: " + e.Message);
                    Application.Exit();
                }
            }
            return dataTable;
        }
    }
}
