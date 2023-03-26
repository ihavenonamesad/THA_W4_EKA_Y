using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace THA_WEEK4_EKA_Y
{
    public partial class Form1 : Form
    {
        
        public List<Team> teamlist = new List<Team>();
        public Form1()

        {
            InitializeComponent();
            Presett preset = new Presett();
            teamlist.Add(preset.BD());
            teamlist.Add(preset.AF());
            teamlist.Add(preset.EF());
            Updater();
        }

        private void PlayName_txt_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void AddTeam_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TeamName_txt.Text) && !string.IsNullOrEmpty(TeamCount_txt.Text) &&
               !string.IsNullOrEmpty(TeamCity_txt.Text))
            {
                Team team = new Team();
                team.teamName = TeamName_txt.Text;
                team.teamCity = TeamCity_txt.Text;
                team.teamCountry = TeamCount_txt.Text;
                team.Playerslist = new List<Player>();
                teamlist.Add(team);

                //clear
                TeamName_txt.Clear();
                TeamCount_txt.Clear();
                TeamCity_txt.Clear();
                Updater();
            }
            else
            {
                MessageBox.Show("All Fields must be fiiled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            string all = All_list.SelectedItem.ToString();
            for (int i = 0; i < teamlist.Count; i++)
            {
                if (teamlist[i].teamName == ChooTeam_comb.SelectedItem.ToString())
                {
                    if (teamlist[i].Playerslist.Count <= 11)
                    {
                        MessageBox.Show("Players less than 11");
                        break;
                    }
                    for (int jd21 = 0; jd21 < teamlist[i].Playerslist.Count; jd21++)
                    {
                        if ($"[{teamlist[i].Playerslist[jd21].playerNum}] {teamlist[i].Playerslist[jd21].playerName}, {teamlist[i].Playerslist[jd21].playerPos}" == all)
                        {
                            
                            teamlist[i].Playerslist.Remove(teamlist[i].Playerslist[jd21]);
                            Playerup();
                        }
                    }
                }
            }
        }

        private void cosingcont(object sender, EventArgs e)
        {
            TeamUdapter();
        }        
        

        private async void Updater()
        {
            ChooCount_comb.Items.Clear();
            foreach (Team a in teamlist)
            {
                if (ChooCount_comb.Items.Contains(a.teamCountry))
                {
                    
                }
                else
                {
                    ChooCount_comb.Items.Add(a.teamCountry);
                }               
            }           
        }
        private async void TeamUdapter()
        {
            ChooTeam_comb.Items.Clear();
            foreach (Team a in teamlist)
            {
                if (a.teamCountry == ChooCount_comb.SelectedItem.ToString())
                {
                    ChooTeam_comb.Items.Add(a.teamName);
                }
            }

        }
        private void Playerup()
        {
            All_list.Items.Clear();
            {
                 foreach (Team  a in teamlist)
                 {
                      if (a.teamName == ChooTeam_comb.SelectedItem.ToString())
                      {
                            foreach(Player b in a.Playerslist)
                            {
                                All_list.Items.Add($"[{b.playerNum}] {b.playerName}, {b.playerPos}");
                                All_list.Sorted = true;
                                All_list.Sorted = false;
                            }
                      }
                 }
            }
                    
        }
           

        private void AddPlay_btn_Click(object sender, EventArgs e)
        {
            Player pl = new Player();
            pl.playerName = PlayName_txt.Text;
            pl.playerNum = PlayNumb_txt.Text;
            pl.playerPos = PlayPos_comb.Text;
            bool SameName = false;
            bool SameNumb = false;
            if (!string.IsNullOrEmpty(PlayName_txt.Text) && !string.IsNullOrEmpty(PlayNumb_txt.Text) &&
               !string.IsNullOrEmpty(PlayPos_comb.Text))
            {
               
                foreach (Team a in teamlist)
                {
                    if (a.teamName == ChooTeam_comb.SelectedItem.ToString())
                    {
                        foreach (Player ppppp in a.Playerslist)
                        {
                            if (ppppp.playerName == PlayName_txt.Text)
                            {
                                SameName = true;
                                break;
                            }
                            if (ppppp.playerNum == PlayNumb_txt.Text)
                            {
                                SameNumb = true;
                                break;
                            }
                        }
                        if (SameName == false && SameNumb == false)
                        {
                            a.Playerslist.Add(pl);
                            
                            TeamName_txt.Clear();
                            TeamCount_txt.Clear();
                            TeamCity_txt.Clear();
                            Updater();
                            Playerup();
                        }
                        else if (SameName == true)
                        {
                            MessageBox.Show("Same Name");
                        }
                        else if (SameNumb == true){
                            MessageBox.Show("Same Number");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("All Fields must be fiiled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Choosing(object sender, EventArgs e)
        {
            Playerup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            All_list.Sorted = true;
            All_list.Sorted = false;
        }
    }

}



