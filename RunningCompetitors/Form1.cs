using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningCompetitors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private SortedList<int, string> RunnerList = new SortedList<int, string>();//Created a new instance

        private void btnLoadRunners_Click(object sender, EventArgs e)
        {
            RunnerList.Add(1, "Sahil");
            RunnerList.Add(2, "Sukhdeep");
            RunnerList.Add(3, "Yogesh");
            LoadLbxRunners();
        }
        private void LoadLbxRunners()
        {
            lbxRunnerList.Items.Clear();
            foreach(KeyValuePair<int, string> Runner in RunnerList)
            {
                lbxRunnerList.Items.Add(Runner.Key + " " + Runner.Value);
            }
        }

        private void btnAddRunner_Click(object sender, EventArgs e)
        {
            //add a new member for the runer list
            int value = 0;
            //loop through each entry, the last one is the max of the loop
            foreach(var pair in RunnerList)
            {
                value = pair.Key;
            }
            while (RunnerList.ContainsKey(value))
            {
                //add 1 to the value
                value += 1;
            }
            RunnerList.Add(value, txtInputRunner.Text);
            //empty the text box and reset the focus to it
            txtInputRunner.Text = "";
            txtInputRunner.Focus();
            LoadLbxRunners(); //call the method we created earlier to load the runners
        }
    }
}
