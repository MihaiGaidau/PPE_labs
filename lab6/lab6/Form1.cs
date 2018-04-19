using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        private Color _myColor;
        public Form1()
        {
            InitializeComponent();
            _myColor = NameTB.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameLb_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SurnameTB.BackColor = _myColor;
            NameTB.BackColor = _myColor;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!IsInList(new User(NameTB.Text, SurnameTB.Text, HobbyTB.Text, ProffTB.Text)) && NameTB.Text != "" && SurnameTB.Text != "")
            {
                users.Add(new User(NameTB.Text, SurnameTB.Text, HobbyTB.Text, ProffTB.Text));
                DataLB.Items.Add(NameTB.Text + ' ' + SurnameTB.Text);
                NameTB.ResetText();
                SurnameTB.ResetText();
                HobbyTB.ResetText();
                ProffTB.ResetText();
                SurnameTB.BackColor = _myColor;
                NameTB.BackColor = _myColor;
            }
            else
            {
                if (NameTB.Text != "" && SurnameTB.Text != "")
                {
                    NameTB.BackColor = Color.Coral;
                    SurnameTB.BackColor = Color.Coral;
                }
                if (NameTB.Text == "")
                    NameTB.BackColor = Color.Coral;
                if (SurnameTB.Text == "")
                    SurnameTB.BackColor = Color.Coral;
//                System.Media.SoundPlayer player = new System.Media.SoundPlayer("SolutionItems/error.wav");
//                player.Play();
            }


        }

        private bool IsInList(User myUser)
        {
            foreach (User user in users)
            {
                if (String.Equals(myUser.Name, user.Name, StringComparison.CurrentCultureIgnoreCase) && String.Equals(myUser.Surname, user.Surname, StringComparison.CurrentCultureIgnoreCase))
                    return true;
            }

            return false;
        }

//        private String CreateStringList()
//        {
//            String myString = null;
//            foreach (User user in users)
//            {
//                myString += user.Name + " " + user.Surname + '\n';
//
//            }
//            return myString;
//        }

        private void DataLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected_text = null;
            OutTB.Show();
            if (DataLB.SelectedItem == null)
            {
                selected_text = "";
            }
            else
            {
                selected_text = DataLB.SelectedItem.ToString();
                selected_text = selected_text.Replace(" ", "");
                foreach (User user in users)
                {
                    if (selected_text == user.Name + user.Surname)
                    {
                        OutTB.Text = user.Name + ' ' + user.Surname + Environment.NewLine + user.Hobby + Environment.NewLine + user.Proffesion;
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataLB.SelectedItem != null)
            {
                users.Remove(users[GetUserID(DataLB.SelectedItem.ToString().Replace(" ", ""))]);
                DataLB.Items.Remove(DataLB.SelectedItem);
                OutTB.Hide();
            }
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DataLB.Items.Clear();
            users.Clear();
            OutTB.Hide();
        }

        private int GetUserID(String nameSurname)
        {
            for (int i = 0; i < users.Count; i++)
                if (nameSurname == users[i].Name + users[i].Surname) return i;
            return -1;
        }

        private void NameTB_MouseClick(object sender, MouseEventArgs e)
        {
//            SurnameTB.BackColor = myColor;
//            NameTB.BackColor = myColor;
        }

        private void SurnameTB_MouseClick(object sender, MouseEventArgs e)
        {
//            SurnameTB.BackColor = myColor;
//            NameTB.BackColor = myColor;
        }

        private void SurnameTB_TextChanged(object sender, EventArgs e)
        {
            SurnameTB.BackColor = _myColor;
            NameTB.BackColor = _myColor;
        }
    }
}
