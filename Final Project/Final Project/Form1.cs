using System;
using System.Collections.Generic;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPlanetData();
           

            textBox2.Text = ("Planet types: " +
              "-Terrestrial     " +
            "-Gas giant     " +
            "-Ice giant");

        }

        Planet[] planetArray = new Planet[8];
        private int index = 0;

        public void loadPlanetData()
        {
            string[] lines = System.IO.File.ReadAllLines("planet-data -Sheet1.csv");
            
            for (int i = 0; i < planetArray.Length; i++)
            {

                string line = lines[i];
                String[] data = line.Split(",");
                Planet p1 = new Planet(data[0], data[1], data[2], data[3]);
                planetArray[i] = (p1);
            }

        }

        public void showPlanet()
        {
            Planet p = planetArray[index];
            string imagefile = p.getImage_file();
            pictureBox1.Image = Image.FromFile("planets/" + imagefile);
        }


        private void next_button_Click(object sender, EventArgs e)
        {
            index++;
            if (index > 7)
                index = 0;

            label.Text=("");
            label2.Text=("");
            textBox1.Clear();

            showPlanet();
        }

        private void review_button_Click(object sender, EventArgs e)
        {
            Planet p = planetArray[index];
            label.Text=(p.ToString());
        }

        int count = 1;

        private void quiz_button_Click(object sender, EventArgs e)
        {
            Planet p = planetArray[index];
            label.Text = ("");
            label2.Text = ("What planet is this? (Spelling counts)");
            
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            Planet p = planetArray[index];
            if (count == 1)
            {


                if (textBox1.Text.ToLower() == (p.getName().ToLower()))
                {
                    MessageBox.Show("You are correct! Answer next question.");
                }
                else
                {
                    MessageBox.Show("Incorrect. Answer question 2.");
                }
                label2.Text = ("What planet type is this planet?");
                count++;
                textBox1.Clear();
            }


            else if (count == 2)
            { 


                if (textBox1.Text.ToLower() == (p.getType().ToLower()))
                {
                    MessageBox.Show("You are correct!");
                }
                else
                {
                    MessageBox.Show("Incorrect try again.");
                }
                count = 1;

            }


        }









        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
           

        }
    }
}