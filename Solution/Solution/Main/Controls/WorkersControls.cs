using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution.Main.Controls
{
    public partial class WorkersControls : UserControl
    {
        List<Other.Worker> WorkersList = new List<Other.Worker>();
        int SaveSelectedIndex = -1;
        bool clickAdd = false, clickRedact = false, clickDelete = false, RedactMode = false;
        public WorkersControls()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(SaveData);
            DateOfEmploymentDateTimePicker.Value = DateTime.Now;
            AddPictureBox.Image = Properties.Resources.Add;
            AddPictureBox.MouseDown += AddPictureBox_MouseDown;
            AddPictureBox.MouseUp += AddPictureBox_MouseUp;
            AddPictureBox.MouseMove += AddPictureBox_MouseMove;
            AddPictureBox.MouseLeave += AddPictureBox_MouseLeave;
            RedactPictureBox.Image = Properties.Resources.Redact;
            RedactPictureBox.MouseDown += RedactPictureBox_MouseDown;
            RedactPictureBox.MouseUp += RedactPictureBox_MouseUp;
            RedactPictureBox.MouseMove += RedactPictureBox_MouseMove;
            RedactPictureBox.MouseLeave += RedactPictureBox_MouseLeave;
            DeletePictureBox.Image = Properties.Resources.Delete;
            DeletePictureBox.MouseDown += DeletePictureBox_MouseDown;
            DeletePictureBox.MouseUp += DeletePictureBox_MouseUp;
            DeletePictureBox.MouseMove += DeletePictureBox_MouseMove;
            DeletePictureBox.MouseLeave += DeletePictureBox_MouseLeave;
            FullNameTextBox.ReadOnly = true;
            PostTextBox.ReadOnly = true;
            DateOfEmploymentDateTimePicker.Enabled = false;
            SalaryTextBox.ReadOnly = true;
        }
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WorkersList[WorkersListBox.SelectedIndex].FullName = FullNameTextBox.Text;
                WorkersListBox.Items[WorkersListBox.SelectedIndex] = WorkersList[WorkersListBox.SelectedIndex].FullName;
                FullNameTextBox.BackColor = Color.White;
                FullNameTextBox.SelectionStart = FullNameTextBox.Text.Length;
                SortWorkersListBox();
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }
        private void PostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WorkersList[WorkersListBox.SelectedIndex].Post = PostTextBox.Text;
                PostTextBox.BackColor = Color.White;
            }
            catch
            {
                PostTextBox.BackColor = Color.LightPink;
            }
        }
        private void DateOfEmploymentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (WorkersListBox.SelectedIndex != -1)
            {
                try
                {
                    WorkersList[WorkersListBox.SelectedIndex].Date = DateOfEmploymentDateTimePicker.Value;
                    ErrorCalendarPanel.BackColor = Color.White;
                    ErrorCalendarLabel.Text = "";
                }
                catch
                {
                    ErrorCalendarPanel.BackColor = Color.LightPink;
                    ErrorCalendarLabel.Text = "Неверная дата";
                }
            }
        }
        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WorkersList[WorkersListBox.SelectedIndex].Salary = Convert.ToInt32(SalaryTextBox.Text);
                SalaryTextBox.BackColor = Color.White;
            }
            catch
            {
                SalaryTextBox.BackColor = Color.LightPink;
            }
        }
        private void WorkersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkersListBox.SelectedIndex != -1)
            {
                if (SaveSelectedIndex != WorkersListBox.SelectedIndex)
                {
                    FullNameTextBox.ReadOnly = true;
                    PostTextBox.ReadOnly = true;
                    DateOfEmploymentDateTimePicker.Enabled = false;
                    SalaryTextBox.ReadOnly = true;
                    RedactMode = false;
                    RedactPictureBox.Image = Properties.Resources.Redact;
                }
                SaveSelectedIndex = WorkersListBox.SelectedIndex;
                FullNameTextBox.Text = WorkersList[WorkersListBox.SelectedIndex].FullName;
                PostTextBox.Text = WorkersList[WorkersListBox.SelectedIndex].Post;
                DateOfEmploymentDateTimePicker.Value = WorkersList[WorkersListBox.SelectedIndex].Date;
                SalaryTextBox.Text = Convert.ToString(WorkersList[WorkersListBox.SelectedIndex].Salary);
            }
        }
        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            WorkersList.Add(new Other.Worker());
            WorkersListBox.Items.Add(WorkersList[WorkersList.Count - 1].FullName);
            SortWorkersListBox();
            clickAdd = false;
        }
        private void AddPictureBox_MouseDown(object sende, MouseEventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.AddClick;
            clickAdd = true;
        }
        private void AddPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.AddNavodka;
            clickAdd = false;
        }
        private void AddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(clickAdd == false)
            {
                AddPictureBox.Image = Properties.Resources.AddNavodka;
            }
        }
        private void AddPictureBox_MouseLeave(object Sender, System.EventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.Add;
        }
        private void RedactPictureBox_Click(object sender, EventArgs e)
        {
            if (WorkersListBox.SelectedIndex != -1)
            {
                if (RedactMode == false)
                {
                    FullNameTextBox.ReadOnly = false;
                    PostTextBox.ReadOnly = false;
                    DateOfEmploymentDateTimePicker.Enabled = true;
                    SalaryTextBox.ReadOnly = false;
                    RedactMode = true;
                }
                else
                {
                    FullNameTextBox.ReadOnly = true;
                    PostTextBox.ReadOnly = true;
                    DateOfEmploymentDateTimePicker.Enabled = false;
                    SalaryTextBox.ReadOnly = true;
                    RedactMode = false;
                }
                SortWorkersListBox();
            }
        }
        private void RedactPictureBox_MouseDown(object sende, MouseEventArgs e)
        {
            if (RedactMode == true)
            {
                RedactPictureBox.Image = Properties.Resources.RedactModeClick;
            }
            else
            {
                RedactPictureBox.Image = Properties.Resources.RedactClick;
            }
            clickRedact = true;
        }
        private void RedactPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (RedactMode == true)
            {
                RedactPictureBox.Image = Properties.Resources.RedactNavodka;
            }
            else
            {
                RedactPictureBox.Image = Properties.Resources.RedactModeNavodka;
            }
            clickRedact = false;
        }
        private void RedactPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickRedact == false)
            {
                if (RedactMode == true)
                {
                    RedactPictureBox.Image = Properties.Resources.RedactModeNavodka;
                }
                else
                {
                    RedactPictureBox.Image = Properties.Resources.RedactNavodka;
                }
            }
        }
        private void RedactPictureBox_MouseLeave(object Sender, System.EventArgs e)
        {
            if (RedactMode == true)
            {
                RedactPictureBox.Image = Properties.Resources.RedactMode;
            }
            else
            {
                RedactPictureBox.Image = Properties.Resources.Redact;
            }
        }
        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            if (WorkersListBox.SelectedIndex != -1)
            {
                WorkersList.RemoveAt(WorkersListBox.SelectedIndex);
                WorkersListBox.Items.RemoveAt(WorkersListBox.SelectedIndex);
                FullNameTextBox.Text = "";
                PostTextBox.Text = "";
                DateOfEmploymentDateTimePicker.Value = new DateTime(2001,1,1);
                SalaryTextBox.Text = "";
                FullNameTextBox.BackColor = Color.White;
                PostTextBox.BackColor = Color.White;
                SalaryTextBox.BackColor = Color.White;
            }
        }
        private void DeletePictureBox_MouseDown(object sende, MouseEventArgs e)
        {
            DeletePictureBox.Image = Properties.Resources.DeleteClick;
            clickDelete = true;
        }
        private void DeletePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            DeletePictureBox.Image = Properties.Resources.DeleteNavodka;
            clickDelete = false;
        }
        private void DeletePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickDelete == false)
            {
                DeletePictureBox.Image = Properties.Resources.DeleteNavodka;
            }
        }
        private void DeletePictureBox_MouseLeave(object Sender, System.EventArgs e)
        {
            DeletePictureBox.Image = Properties.Resources.Delete;
        }
        private void SortWorkersListBox()
        {
            int selected_index = WorkersListBox.SelectedIndex;
            List<List<string>> FIO = new List<List<string>>();
            for(int i = 0;i < WorkersListBox.Items.Count;i++)
            {
                FIO.Add(new List<string>(3));
                char[] fio = Convert.ToString(WorkersListBox.Items[i]).ToCharArray();
                string word = "";
                for(int j = 0;j < fio.Length;j++)
                {
                    if(fio[j] == ' ')
                    {
                        FIO[i].Add(word);
                        word = "";
                    }
                    else if(j == fio.Length - 1)
                    {
                        word += fio[j];
                        FIO[i].Add(word);
                    }
                    else
                    {
                        word += fio[j];
                    }
                }
            }
            string alf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            for(int i = 0;i < FIO.Count - 1;i++)
            {
                int MinIndex = 33, index = -1;
                for(int j = i;j < FIO.Count;j++)
                {
                    if(alf.IndexOf(FIO[j][0][0]) < MinIndex)
                    {
                        MinIndex = alf.IndexOf(FIO[j][0][0]);
                        index = j;
                    }
                }
                if(selected_index == i)
                {
                    selected_index = index;
                }
                if(selected_index == index)
                {
                    selected_index = i;
                }
                object obmenStr = WorkersListBox.Items[i];
                WorkersListBox.Items[i] = WorkersListBox.Items[index];
                WorkersListBox.Items[index] = obmenStr;
                List<string> obmen = new List<string>() {FIO[i][0], FIO[i][1], FIO[i][2]};
                FIO[i][0] = FIO[index][0];
                FIO[i][1] = FIO[index][1];
                FIO[i][2] = FIO[index][2];
                FIO[index][0] = obmen[0];
                FIO[index][1] = obmen[1];
                FIO[index][2] = obmen[2];
                Other.Worker obmenWorker = new Other.Worker(WorkersList[i].FullName, WorkersList[i].Post, WorkersList[i].Date, WorkersList[i].Salary);
                WorkersList[i].FullName = WorkersList[index].FullName;
                WorkersList[i].Post = WorkersList[index].Post;
                WorkersList[i].Date = WorkersList[index].Date;
                WorkersList[i].Salary = WorkersList[index].Salary;
                WorkersList[index].FullName = obmenWorker.FullName;
                WorkersList[index].Post = obmenWorker.Post;
                WorkersList[index].Date = obmenWorker.Date;
                WorkersList[index].Salary = obmenWorker.Salary;
            }
            List<int> Indexes = new List<int>();
            Indexes.Add(0);
            for (int i = 1; i < FIO.Count; i++)
            {
                if(FIO[i][0][0] != FIO[i-1][0][0])
                {
                    Indexes.Add(i);
                }
            }
            Indexes.Add(FIO.Count);
            for(int i = 0;i < Indexes.Count - 1;i++)
            {
                for (int j = Indexes[i]; j < Indexes[i + 1] - 1; j++)
                {
                    int MinIndex = 33, index = -1;
                    for (int k = j; k < Indexes[i + 1]; k++)
                    {
                        if (alf.IndexOf(FIO[k][1][0]) < MinIndex)
                        {
                            MinIndex = alf.IndexOf(FIO[k][1][0]);
                            index = k;
                        }
                    }
                    if (selected_index == j)
                    {
                        selected_index = index;
                    }
                    if (selected_index == index)
                    {
                        selected_index = j;
                    }
                    object obmenStr = WorkersListBox.Items[j];
                    WorkersListBox.Items[j] = WorkersListBox.Items[index];
                    WorkersListBox.Items[index] = obmenStr;
                    List<string> obmen = new List<string>() { FIO[j][0], FIO[j][1], FIO[j][2] };
                    FIO[j][0] = FIO[index][0];
                    FIO[j][1] = FIO[index][1];
                    FIO[j][2] = FIO[index][2];
                    FIO[index][0] = obmen[0];
                    FIO[index][1] = obmen[1];
                    FIO[index][2] = obmen[2];
                    Other.Worker obmenWorker = new Other.Worker(WorkersList[j].FullName, WorkersList[j].Post, WorkersList[j].Date, WorkersList[j].Salary);
                    WorkersList[j].FullName = WorkersList[index].FullName;
                    WorkersList[j].Post = WorkersList[index].Post;
                    WorkersList[j].Date = WorkersList[index].Date;
                    WorkersList[j].Salary = WorkersList[index].Salary;
                    WorkersList[index].FullName = obmenWorker.FullName;
                    WorkersList[index].Post = obmenWorker.Post;
                    WorkersList[index].Date = obmenWorker.Date;
                    WorkersList[index].Salary = obmenWorker.Salary;
                }
            }
            Indexes.Clear();
            Indexes.Add(0);
            for (int i = 1; i < FIO.Count; i++)
            {
                if (FIO[i][1][0] != FIO[i - 1][1][0])
                {
                    Indexes.Add(i);
                }
            }
            Indexes.Add(FIO.Count);
            for (int i = 0; i < Indexes.Count - 1; i++)
            {
                for (int j = Indexes[i]; j < Indexes[i + 1] - 1; j++)
                {
                    int MinIndex = 33, index = -1;
                    for (int k = j; k < Indexes[i + 1]; k++)
                    {
                        if (alf.IndexOf(FIO[k][2][0]) < MinIndex)
                        {
                            MinIndex = alf.IndexOf(FIO[k][2][0]);
                            index = k;
                        }
                    }
                    if (selected_index == j)
                    {
                        selected_index = index;
                    }
                    if (selected_index == index)
                    {
                        selected_index = j;
                    }
                    object obmenStr = WorkersListBox.Items[j];
                    WorkersListBox.Items[j] = WorkersListBox.Items[index];
                    WorkersListBox.Items[index] = obmenStr;
                    List<string> obmen = new List<string>() { FIO[j][0], FIO[j][1], FIO[j][2] };
                    FIO[j][0] = FIO[index][0];
                    FIO[j][1] = FIO[index][1];
                    FIO[j][2] = FIO[index][2];
                    FIO[index][0] = obmen[0];
                    FIO[index][1] = obmen[1];
                    FIO[index][2] = obmen[2];
                    Other.Worker obmenWorker = new Other.Worker(WorkersList[j].FullName, WorkersList[j].Post, WorkersList[j].Date, WorkersList[j].Salary);
                    WorkersList[j].FullName = WorkersList[index].FullName;
                    WorkersList[j].Post = WorkersList[index].Post;
                    WorkersList[j].Date = WorkersList[index].Date;
                    WorkersList[j].Salary = WorkersList[index].Salary;
                    WorkersList[index].FullName = obmenWorker.FullName;
                    WorkersList[index].Post = obmenWorker.Post;
                    WorkersList[index].Date = obmenWorker.Date;
                    WorkersList[index].Salary = obmenWorker.Salary;
                }
            }
            WorkersListBox.SelectedIndex = selected_index;
        }
        private void SaveData(object sender, EventArgs e)
        {
            MessageBox.Show("Конец");
        }
    }
}
