using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformProject
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
            //GenerateGrid();

            TestGeneric();
        }


        //private void GenerateGrid()
        //{
        //    dgvUsers.Rows.Add("Ayaz", "Mehdiyev", "ayaz@email.com");
        //    //dgvUsers.Rows.Add();
        //    //dgvUsers.Rows.Add(10);

        //    DataGridViewRow row = (DataGridViewRow) dgvUsers.Rows[0].Clone();
        //    DataGridViewRow row2 = new DataGridViewRow();
            
            
        //    row.Cells[0].Value = "Togrul";

        //    //row.SetValues("Togrul", 123, true);

        //    dgvUsers.Rows.Add(row);
        //}

        private void TestGeneric()
        {
            //Student<int> student = new Student<int>();
            //student.GetScore(100, 20);

            //Student<string> student2 = new Student<string>();
            //student2.GetScore("test", "t");

            //StudentP210<string> studentP = new StudentP210<string>();
            //studentP.GetScore();

            //GenericClass<int, string> genericClass = new GenericClass<int, string>();

            List<int> scores = new List<int>();

            List<int> importedScores = new List<int> {
                66,
                77
            };

            scores.Add(12);
            scores.Add(20);
            scores.Add(50);
            scores.Add(3);
            scores.Insert(1, 80);
            scores.InsertRange(3, importedScores);

            foreach (var item in scores)
            {
                Button button = new Button();
                button.Text = item.ToString();
                button.Location = new Point(10, 20);
                button.Size = new Size(50, 50);
                
            }


        }

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
