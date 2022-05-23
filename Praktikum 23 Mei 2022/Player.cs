using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Praktikum_23_Mei_2022
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        int PosisiSekarang = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            sqlQuery = "select player.player_id, player.player_name, player.birthdate, nationality.nation, team.team_name, player.team_number from player, nationality, team where player.nationality_id = nationality.nationality_id and player.team_id = team.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            IsiDataPemain(0);
        }

        public void IsiDataPemain(int Posisi)
        {
            tBoxPlayerID.Text = dtTypePemain.Rows[Posisi][0].ToString();
            tBoxPlayerName.Text = dtTypePemain.Rows[Posisi][1].ToString();
            dTPBirthDate.Text = dtTypePemain.Rows[Posisi][2].ToString();
            cBoxNationality.Text = dtTypePemain.Rows[Posisi][3].ToString();
            cBoxTeam.Text = dtTypePemain.Rows[Posisi][4].ToString();
            listBoxTeamNumber.Text = dtTypePemain.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }

            private void buttonPertama_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void buttonTerakhir_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTypePemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void dTPBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
