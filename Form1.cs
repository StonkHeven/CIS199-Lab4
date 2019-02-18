//GradingID: N7573
//CIS199-75
//Lab 4
//Due date: Feb 17, 2019
//Admissions calculator using GPA and test scores with running total of acceptances and rejections
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int totalAccepted = 0; //Variable for incremental total of acceptances
        int totalRejected = 0; //Variable for incremental total of rejections

        public Form1()
        {
            InitializeComponent();
        }
        
        private void CalculateButton_Click(object sender, EventArgs e)  //Event handler - CalculateButton "Click for results" 
        {
            //Variables
            float GPA;      //Variable for GPA
            int TestScore;  //Variable for TestScore

            //Parses
            //GPA input TryParse
            if (float.TryParse(GPA_input.Text, out GPA))                
            {
                MessageBox.Show("GPA input successful!");
            }
            else
            {
                MessageBox.Show("Must enter a valid GPA");
            }
            //testScore input TryParse
            if (int.TryParse(TestScore_input.Text, out TestScore))      
            {
                MessageBox.Show("Test score input successful!");
            }
            else
            {
                MessageBox.Show("Must enter a valid test score");
            }

            //Calculations and outputs
            if (GPA >= 3.0 && TestScore >= 60)                          //Test of first acceptance criteria
            {
                totalAccepted++;                                        //Incremental increase per acceptance
                AcceptReject_Output.Text = "Accepted";                  //"Accepted" string to appear in AcceptReject_Output label
                Acceptances_Output.Text = totalAccepted.ToString();     //Output for total number of acceptances
            }
            else if ((GPA < 3.0) && (TestScore >= 80))                  //Test of second acceptance criteria
            {
                totalAccepted++;                                        //Incremental increase per acceptance
                AcceptReject_Output.Text = "Accepted";                  //"Accepted" string to appear in AcceptReject_Output label
                Acceptances_Output.Text = totalAccepted.ToString();     //Output for total number of acceptances
            }
            else                                                        //Default rejection for not fulfilling either criteria
            {
                totalRejected++;                                        //Incremental increase per rejection
                AcceptReject_Output.Text = "Rejected";                  //"Rejected" string to appear in AcceptReject_Output label
                Rejections_Output.Text = totalRejected.ToString();      //Output for total number of rejections
            }
        }
    }
}
