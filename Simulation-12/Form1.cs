using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_12
{
    public partial class Form1 : Form
    {
        private readonly Match match;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = false;
            dataGridView1.RowCount = 8;
            match = new Match();
            Tools.InitGrid(dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            NextB.Visible = false;
        }

        private void CreateB_Click(object sender, EventArgs e)
        {
            Tools.InitGrid(dataGridView1);
            match.Day = 0;
            bool flag = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells["Team"].Value) == string.Empty)
                    flag = true;
            }

            if (flag)
                MessageBox.Show(@"Enter the team names!");
            else
            {
                dataGridView1.ReadOnly = true;
                for (int i = 0; i < dataGridView1.ColumnCount + 1; i++)
                {
                    dataGridView1["AvgGoals", i].Value = Tools.GenerateRandomAvg(); 
                }

                CreateB.Visible = false;
                NextB.Visible = true;
            }

        }

        private void NextB_Click(object sender, EventArgs e)
        {
            if (match.Day < 7)
            {
                match.ListMatches(dataGridView1);
                labDay.Text = "Day: " + match.Day;
            }
            else
            {
                NextB.Visible = false;
                CreateB.Visible = true;
                dataGridView1.ReadOnly = false;
                labWinner.Text = "Winner is " + Match.GetWinner(dataGridView1) + "!";
            }
        }

        public static class Tools
        {
            private static Random random = new Random();

            public static double GenerateRandomAvg()
            {
                return Math.Round(random.NextDouble() * 2, 1);
            }

            private static double GenerateDouble()
            {
                return random.NextDouble();
            }

            public static int GetTeamScore(double lambda)
            {
                int m = 0;
                double S = 0;
                while (S >= -lambda)
                {
                    double alpha = GenerateDouble();
                    S += Math.Log(alpha);
                    m++;
                }

                return m;
            }

            public static void InitGrid(DataGridView dataGrid)
            {
                Console.WriteLine(dataGrid.RowCount);
                Console.WriteLine(dataGrid.ColumnCount);
                for (int i = 0; i < dataGrid.RowCount; i++)
                {
                    for (int j = 1; j < dataGrid.ColumnCount - 1; j++)
                    {
                        dataGrid[j, i].Value = .0f;
                    }
                }
            }
        }

        public class Match
        {
            public int Day = 0;
            private readonly List<string> teams = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7" };
            private readonly List<string> teams2 = new List<string>() { "1", "2", "3", "4", "5", "6", "7" }; //вместо teams.skip(1)

            private static void PlayMatch(DataGridViewRow firstTeam, DataGridViewRow secondTeam)
            {
                int firstTeamScore = Tools.GetTeamScore((double)firstTeam.Cells["AvgGoals"].Value);
                int secondTeamScore = Tools.GetTeamScore((double)secondTeam.Cells["AvgGoals"].Value);

                firstTeam.Cells["Goals"].Value = Convert.ToInt32(firstTeam.Cells["Goals"].Value) + firstTeamScore;
                secondTeam.Cells["Goals"].Value = Convert.ToInt32(secondTeam.Cells["Goals"].Value) + secondTeamScore;

                if (firstTeamScore > secondTeamScore)
                {
                    firstTeam.Cells["Wins"].Value = Convert.ToInt32(firstTeam.Cells["Wins"].Value) + 1;
                    firstTeam.Cells["Score"].Value = Convert.ToInt32(firstTeam.Cells["Score"].Value) + 3;
                    secondTeam.Cells["Looses"].Value = Convert.ToInt32(secondTeam.Cells["Looses"].Value) + 1;
                }
                else if (firstTeamScore < secondTeamScore)

                {
                    secondTeam.Cells["Wins"].Value = Convert.ToInt32(secondTeam.Cells["Wins"].Value) + 1;
                    secondTeam.Cells["Score"].Value = Convert.ToInt32(secondTeam.Cells["Score"].Value) + 3;
                    firstTeam.Cells["Looses"].Value = Convert.ToInt32(firstTeam.Cells["Looses"].Value) + 1;
                }
                else
                {
                    firstTeam.Cells["Score"].Value = Convert.ToInt32(firstTeam.Cells["Score"].Value) + 1;
                    secondTeam.Cells["Score"].Value = Convert.ToInt32(secondTeam.Cells["Score"].Value) + 1;
                    firstTeam.Cells["Draws"].Value = Convert.ToInt32(firstTeam.Cells["Draws"].Value) + 1;
                    secondTeam.Cells["Draws"].Value = Convert.ToInt32(secondTeam.Cells["Draws"].Value) + 1;
                }
            }

            public static string GetWinner(DataGridView table)
            {
                int max = 0;
                List<int> indexes = new List<int>();
                for (int i = 0; i < table.RowCount; i++)
                {
                    if (max < Convert.ToInt32(table.Rows[i].Cells["Score"].Value))
                    {
                        max = Convert.ToInt32(table.Rows[i].Cells["Score"].Value);
                    }
                }

                for (int i = 0; i < table.RowCount; i++)
                {
                    if (max == Convert.ToInt32(table.Rows[i].Cells["Score"].Value))
                    {
                        indexes.Add(i);
                    }
                }

                if (indexes.Count == 1)
                {
                    return table.Rows[indexes[0]].Cells["Team"].Value.ToString();
                }
                else
                {
                    max = 0;
                    int index = 0;
                    foreach (var i in indexes.Where(i => max < Convert.ToInt32(table.Rows[i].Cells["Goals"].Value)))
                    {
                        max = Convert.ToInt32(table.Rows[i].Cells["Goals"].Value);
                        index = i;
                    }

                    return table.Rows[index].Cells["Team"].Value.ToString();
                }
            }

            public void ListMatches(DataGridView mat)
            {
                Console.WriteLine("Day {0}", (Day + 1));
                PlayMatch(mat.Rows[Convert.ToInt32(teams2[Day])], (mat.Rows[Convert.ToInt32(teams[0])]));
                Console.WriteLine("{0} vs {1}", teams2[Day], teams[0]);

                for (int idx = 1; idx < 4; idx++)
                {
                    int firstTeam = Convert.ToInt32(teams2[(Day + idx) % 7]);
                    int secondTeam = Convert.ToInt32(teams2[(Day + 7 - idx) % 7]);
                    Console.WriteLine("{0} vs {1}", firstTeam, secondTeam);     
                    PlayMatch(mat.Rows[firstTeam], (mat.Rows[secondTeam]));     
                }

                Day++;
            }
        }

    }
}
