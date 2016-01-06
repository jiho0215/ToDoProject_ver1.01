using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToDoProject_ver1._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialDisplayDesign();
        }
        public void InitialDisplayDesign()
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width * 90 / 100;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height * 90 / 100;
            this.StartPosition = FormStartPosition.CenterScreen;

            Panel TopPanel = new Panel();
            TopPanel.Size = new Size(this.ClientSize.Width, 50);
            TopPanel.Location = new Point(0, 0);
            TopPanel.BorderStyle = BorderStyle.FixedSingle;
            TopPanel.Parent = this;
            {
                PictureBox AddSchedule = new PictureBox();
                AddSchedule.Size = new Size(TopPanel.Height * 90 / 100, TopPanel.Height * 90 / 100);
                AddSchedule.Location = new Point(TopPanel.Height * 5 / 100, TopPanel.Height * 5 / 100);
                AddSchedule.Image = Properties.Resources.Plus_High;
                AddSchedule.SizeMode = PictureBoxSizeMode.Zoom;
                AddSchedule.Parent = TopPanel;

                Label DateLabel = new Label();
                DateLabel.Size = new Size(200, TopPanel.Height * 90 / 100);
                DateLabel.Location = new Point((TopPanel.Width / 2) - (DateLabel.Width / 2), TopPanel.Height * 5 / 100);
                DateLabel.ForeColor = Color.Black;
                DateLabel.Font = new Font("arial", 17, FontStyle.Bold);
                DateLabel.TextAlign = ContentAlignment.MiddleCenter;
                DateLabel.Text = DateTime.Now.ToString("yyyy-MMM-dd");
                DateLabel.Parent = TopPanel;

                PictureBox Calendar = new PictureBox();
                Calendar.Size = new Size(TopPanel.Height * 90 / 100, TopPanel.Height * 90 / 100);
                Calendar.Location = new Point(DateLabel.Left - Calendar.Width, TopPanel.Height * 5 / 100);
                Calendar.Image = Properties.Resources.Cal_High;
                Calendar.SizeMode = PictureBoxSizeMode.Zoom;
                Calendar.Parent = TopPanel;

                PictureBox Setting = new PictureBox();
                Setting.Size = new Size(TopPanel.Height * 90 / 100, TopPanel.Height * 90 / 100);
                Setting.Location = new Point(DateLabel.Right, TopPanel.Height * 5 / 100);
                Setting.Image = Properties.Resources.Setting_High;
                Setting.SizeMode = PictureBoxSizeMode.Zoom;
                Setting.Parent = TopPanel;

                PictureBox AddToDo = new PictureBox();
                AddToDo.Size = new Size(TopPanel.Height * 90 / 100, TopPanel.Height * 90 / 100);
                AddToDo.Location = new Point(TopPanel.Width - (AddToDo.Width + TopPanel.Height * 5 / 100 + 2), TopPanel.Height * 5 / 100);
                AddToDo.Image = Properties.Resources.Plus_High;
                AddToDo.SizeMode = PictureBoxSizeMode.Zoom;
                AddToDo.Parent = TopPanel;

                Label ScheduleLabel = new Label();
                ScheduleLabel.Size = new Size(100, TopPanel.Height * 90 / 100);
                ScheduleLabel.Location = new Point((Calendar.Left/2 - AddSchedule.Right), TopPanel.Height * 5 / 100);
                ScheduleLabel.ForeColor = Color.Black;
                ScheduleLabel.Font = new Font("arial", 15, FontStyle.Regular);
                ScheduleLabel.TextAlign = ContentAlignment.MiddleCenter;
                ScheduleLabel.Text = "Schedule";
                ScheduleLabel.Parent = TopPanel;

                Label ToDoLabel = new Label();
                ToDoLabel.Size = new Size(200, TopPanel.Height * 90 / 100);
                ToDoLabel.Location = new Point(this.Width * 3 / 4 - ScheduleLabel.Width / 2, TopPanel.Height * 5 / 100);
                ToDoLabel.ForeColor = Color.Black;
                ToDoLabel.Font = new Font("arial", 15, FontStyle.Regular);
                ToDoLabel.TextAlign = ContentAlignment.MiddleCenter;
                ToDoLabel.Text = "To Do List";
                ToDoLabel.Parent = TopPanel;
            }

            Panel TimeColumn = new Panel();
            TimeColumn.Size = new Size(100, this.ClientSize.Height - TopPanel.Height + 2);
            TimeColumn.Location = new Point(this.ClientSize.Width / 2 - TimeColumn.Width / 2, TopPanel.Bottom - 1);
            TimeColumn.BorderStyle = BorderStyle.FixedSingle;
            TimeColumn.Parent = this;

            Panel ScheduleColumn = new Panel();
            ScheduleColumn.Size = new Size((this.ClientSize.Width - TimeColumn.Width) / 2 + 2, this.ClientSize.Height - TopPanel.Height + 2);
            ScheduleColumn.Location = new Point(0, TopPanel.Bottom - 1);
            ScheduleColumn.BorderStyle = BorderStyle.FixedSingle;
            ScheduleColumn.Parent = this;

            Panel ToDoColumn = new Panel();
            ToDoColumn.Size = new Size((this.ClientSize.Width - TimeColumn.Width) / 2 + 2, this.ClientSize.Height - TopPanel.Height + 2);
            ToDoColumn.Location = new Point(TimeColumn.Right - 1, TopPanel.Bottom - 1);
            ToDoColumn.BorderStyle = BorderStyle.FixedSingle;
            ToDoColumn.Parent = this;
        }
    }
}
