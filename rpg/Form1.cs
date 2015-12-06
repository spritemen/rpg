using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace rpg
{
    public partial class Form1 : Form
    {
        Charecter titan1 = new Titan(500, 300, 30, 15, 0);
        Charecter titan2 = new Titan(500, 300, 30, 15, 0);
        Charecter sisadmin1 = new Sisadmin(250, 500, 20, 5, 0);
        Charecter sisadmin2 = new Sisadmin(250, 500, 20, 5, 0);
        Charecter ninja2 = new Ninja(300, 400, 100, 3, 0.1);
        Charecter ninja1 = new Ninja(300, 400, 100, 3, 0.1);
        Charecter astronomer1 = new Astronomer(350, 700, 50, 10, 0);
        Charecter astronomer2 = new Astronomer(350, 700, 50, 10, 0);
        Charecter halk1 = new Halk(350, 500, 40, 13, 0);
        Charecter halk2 = new Halk(350, 500, 40, 13, 0);

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            progressBar1.Maximum = titan1.Hp;
            progressBar20.Maximum = titan1.Mp;
            progressBar18.Maximum = ninja1.Hp;
            progressBar19.Maximum = ninja1.Mp;
            LabelUpdate();
        }
        void LabelUpdate()
        {
            label_n1a.Text = "броня: " + ninja1.Armor.ToString();
            label_n1h.Text = "здоровье: " + ninja1.Hp.ToString();
            progressBar18.Value = ninja1.Hp;
            label_n1m.Text = "мана: " + ninja1.Mp.ToString();
            progressBar19.Value = ninja1.Mp;

            label_n2a.Text = "броня: " + ninja2.Armor.ToString();
            label_n2h.Text = "здоровье: " + ninja2.Hp.ToString();
            progressBar11.Value = ninja2.Hp;
            label_n2m.Text = "мана: " + ninja2.Mp.ToString();
            progressBar10.Value = ninja2.Mp;

            label_t1a.Text = "броня: " + titan1.Armor.ToString();
            label_t1h.Text = "здоровье: " + titan1.Hp.ToString();
            progressBar1.Value = titan1.Hp;
            label_t1m.Text = "мана: " + titan1.Mp.ToString();
            progressBar20.Value = titan1.Mp;

            label_t2a.Text = "броня: " + titan2.Armor.ToString();
            label_t2h.Text = "здоровье: " + titan2.Hp.ToString();
            progressBar9.Value = titan2.Hp;
            label_t2m.Text = "мана: " + titan2.Mp.ToString();
            progressBar8.Value = titan2.Mp;

            label_a1a.Text = "броня: " + astronomer1.Armor.ToString();
            label_a1h.Text = "здоровье: " + astronomer1.Hp.ToString();
            progressBar17.Value = astronomer1.Hp;
            label_a1m.Text = "мана: " + astronomer1.Mp.ToString();
            progressBar16.Value = astronomer1.Mp;

            label_a2a.Text = "броня: " + astronomer2.Armor.ToString();
            label_a2h.Text = "здоровье: " + astronomer2.Hp.ToString();
            progressBar7.Value = astronomer2.Hp;
            label_a2m.Text = "мана: " + astronomer2.Mp.ToString();
            progressBar6.Value = astronomer2.Mp;

            label_s1a.Text = "броня: " + sisadmin1.Armor.ToString();
            label_s1h.Text = "здоровье: " + sisadmin1.Hp.ToString();
            progressBar15.Value = sisadmin1.Hp;
            label_s1m.Text = "мана: " + sisadmin1.Mp.ToString();
            progressBar14.Value = sisadmin1.Mp;

            label_s2a.Text = "броня: " + sisadmin2.Armor.ToString();
            label_s2h.Text = "здоровье: " + sisadmin2.Hp.ToString();
            progressBar5.Value = sisadmin2.Hp;
            label_s2m.Text = "мана: " + sisadmin2.Mp.ToString();
            progressBar4.Value = sisadmin2.Mp;

            label_h1a.Text = "броня: " + halk1.Armor.ToString();
            label_h1h.Text = "здоровье: " + halk1.Hp.ToString();
            progressBar13.Value = halk1.Hp;
            label_h1m.Text = "мана: " + halk1.Mp.ToString();
            progressBar12.Value = halk1.Mp;

            label_h2a.Text = "броня: " + halk2.Armor.ToString();
            label_h2h.Text = "здоровье: " + halk2.Hp.ToString();
            progressBar3.Value = halk2.Hp;
            label_h2m.Text = "мана: " + halk2.Mp.ToString();
            progressBar2.Value = halk2.Mp;

        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ninja_button1_Click(object sender, EventArgs e)
        {
            List<Charecter> targets = new List<Charecter>();
            targets.Add(titan1);
            listBox1.Items.Add(ninja1.Skill1(targets));           
            LabelUpdate();

        }

        private void titan_button2_Click(object sender, EventArgs e)
        {
            List<Charecter> targets = new List<Charecter>();
            targets.Add(titan1);
            listBox1.Items.Add(titan1.Skill1(targets));
            LabelUpdate();
        }

        private void astronomer_button3_Click(object sender, EventArgs e)
        {

            List<Charecter> targets = new List<Charecter>();
            targets.Add(titan1);
            listBox1.Items.Add(astronomer1.Skill1(targets));
            LabelUpdate();
        }

        private void sisadmin_button4_Click(object sender, EventArgs e)
        {
            List<Charecter> targets = new List<Charecter>();
            targets.Add(titan1);
            listBox1.Items.Add(sisadmin1.Skill1(targets));
            LabelUpdate();
        }

        private void halk_button5_Click_1(object sender, EventArgs e)
        {
            List<Charecter> targets = new List<Charecter>();
            targets.Add(titan1);
            listBox1.Items.Add(halk1.Skill1(targets));
            LabelUpdate();
        }

    }
}
