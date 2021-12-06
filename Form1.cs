using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class cityViewer : Form
    {
        public cityViewer()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string attractionName = null;
            string highway = null;



            //Selecting a picture for the picture box
            // 0 = San Antonio || 1 = Austin || 2 = Houston || 3 = Dallas

            if (cityList.SelectedIndex == 0)
            {
                if (dayRadio.Checked)
                {
                    pictureBox1.Image = Properties.Resources.SanAntonioDay;
                    highway = "Highway IH-35";
                    attractionName = "San Antonio Riverwalk";

                }
                else
                {
                    pictureBox1.Image = Properties.Resources.SanAntonioNight;
                    highway = "Highway IH-35";
                    attractionName = "The Alamo in San Antonio";
                }
            }

            if (cityList.SelectedIndex == 1)
            {
                if (dayRadio.Checked)
                {
                    pictureBox1.Image = Properties.Resources.AustinDayTime;
                    highway = "Highway 620";
                    attractionName = "Lake Travis in Austin Daytime";
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.AustinNightTime;
                    highway = "Highway 620";
                    attractionName = "Lake Travis in Austin Nighttime";
                }
            }

            if (cityList.SelectedIndex == 2)
            {
                if (dayRadio.Checked)
                { pictureBox1.Image = Properties.Resources.houstonDaytime;
                    highway = "Highway I-45";
                    attractionName = "Space Center in Houston, TX Daytime";
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.HoustonNight;
                    highway = "Highway I-45";
                    attractionName = "Space Center in Houston, TX Nighttime";
                }
            }

            if (cityList.SelectedIndex == 3)
            {
                if (dayRadio.Checked)
                {
                    pictureBox1.Image = Properties.Resources.DallasDay;
                    highway = "Highway 12";
                    attractionName = "Dallas Arboretum and Botanical Garden Daytime";
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.DallasNight;
                    highway = "Highway 12";
                    attractionName = "Dallas Arboretum and Botanical Garden Nighttime";
                }
            }

            //Show Details

            if (attractionCheck.Checked)
            {
                if (highwayCheck.Checked)
                {
                    detailsLabel.Text = "Attraction Name: " + attractionName + " Closest Highway: " + highway;
                }
                else
                {
                    detailsLabel.Text = "Attraction Name: " + attractionName;
                }
            } else if (highwayCheck.Checked)
            {
                detailsLabel.Text = "Closest Highway: " + highway;
            }
            else
            {
                detailsLabel.Text = "";
            }
            
    
        }
    }
}
