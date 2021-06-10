
namespace Simulation_12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Looses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateB = new System.Windows.Forms.Button();
            this.NextB = new System.Windows.Forms.Button();
            this.labWinner = new System.Windows.Forms.Label();
            this.labDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Wins,
            this.Looses,
            this.Draws,
            this.Goals,
            this.Score,
            this.AvgGoals});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.MinimumWidth = 6;
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Width = 150;
            // 
            // Wins
            // 
            this.Wins.HeaderText = "Wins";
            this.Wins.MinimumWidth = 6;
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            this.Wins.Width = 50;
            // 
            // Looses
            // 
            this.Looses.HeaderText = "Looses";
            this.Looses.MinimumWidth = 6;
            this.Looses.Name = "Looses";
            this.Looses.ReadOnly = true;
            this.Looses.Width = 50;
            // 
            // Draws
            // 
            this.Draws.HeaderText = "Draws";
            this.Draws.MinimumWidth = 6;
            this.Draws.Name = "Draws";
            this.Draws.ReadOnly = true;
            this.Draws.Width = 50;
            // 
            // Goals
            // 
            this.Goals.HeaderText = "Goals";
            this.Goals.MinimumWidth = 6;
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            this.Goals.Width = 50;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 50;
            // 
            // AvgGoals
            // 
            this.AvgGoals.HeaderText = "AvgGoals";
            this.AvgGoals.MinimumWidth = 6;
            this.AvgGoals.Name = "AvgGoals";
            this.AvgGoals.ReadOnly = true;
            this.AvgGoals.Visible = false;
            this.AvgGoals.Width = 50;
            // 
            // CreateB
            // 
            this.CreateB.BackColor = System.Drawing.Color.LightGreen;
            this.CreateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateB.Location = new System.Drawing.Point(26, 304);
            this.CreateB.Name = "CreateB";
            this.CreateB.Size = new System.Drawing.Size(124, 38);
            this.CreateB.TabIndex = 1;
            this.CreateB.Text = "Сreate a Match";
            this.CreateB.UseVisualStyleBackColor = false;
            this.CreateB.Click += new System.EventHandler(this.CreateB_Click);
            // 
            // NextB
            // 
            this.NextB.BackColor = System.Drawing.Color.LightGreen;
            this.NextB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextB.Location = new System.Drawing.Point(181, 304);
            this.NextB.Name = "NextB";
            this.NextB.Size = new System.Drawing.Size(132, 58);
            this.NextB.TabIndex = 2;
            this.NextB.Text = "Next Day";
            this.NextB.UseVisualStyleBackColor = false;
            this.NextB.Click += new System.EventHandler(this.NextB_Click);
            // 
            // labWinner
            // 
            this.labWinner.AutoSize = true;
            this.labWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labWinner.Location = new System.Drawing.Point(357, 322);
            this.labWinner.Name = "labWinner";
            this.labWinner.Size = new System.Drawing.Size(0, 20);
            this.labWinner.TabIndex = 3;
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Location = new System.Drawing.Point(507, 325);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(49, 17);
            this.labDay.TabIndex = 3;
            this.labDay.Text = "Day: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(599, 378);
            this.Controls.Add(this.labDay);
            this.Controls.Add(this.labWinner);
            this.Controls.Add(this.NextB);
            this.Controls.Add(this.CreateB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Championship";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CreateB;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.Label labWinner;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Looses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgGoals;
    }
}

