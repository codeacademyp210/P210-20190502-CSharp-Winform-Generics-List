using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ListExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateButtons();
        }

        private void GenerateButtons()
        {



            List<int> scores = new List<int>();

            //List<int> importedScores = new List<int> {
            //    66,
            //    77
            //};

            scores.Add(12);
            scores.Add(20);
            scores.Add(50);
            scores.Add(3);
            scores.Add(12);

            scores.Insert(1, 80);
            //scores.InsertRange(3, importedScores);

            //scores.Remove(12);
            //scores.RemoveAt(0);
            //scores.RemoveRange(1, 2);
            //scores.RemoveAll( item => item > 40 || item < 10);


            List<User> users = new List<User>
            {
                new User{age = 20, Name = "Rauf"},
                new User{age = 25, Name = "Heyder"},
                new User{age = 17, Name = "Parvin"},
                new User{age = 33, Name = "Qeshem"}
            };

            for (int i = 0; i < users.Count; i++)
            {
                if (users.Exists(u => u.age < 22))
                {
                    users.RemoveAt(i);
                }
            }




            int x = 10, y = 20;

            foreach (var item in users)
            {
                Button button = new Button();
                button.Text = item.Name.ToString();
                button.Location = new Point(x, y);
                button.Size = new Size(80, 30);

                button.Click += new EventHandler(Button_Click);

                pnlButtons.Controls.Add(button);
                x += 90;
                //y += 50;
            }
        }

        private void Button_Click(object a, EventArgs e)
        {
            Button btn = a as Button;
            MessageBox.Show(btn.Text);
        }
    }
}
