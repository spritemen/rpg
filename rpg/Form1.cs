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
        bool nh = true; 
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
        List<Charecter> targets = new List<Charecter>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Hero_death()
        {
            if (titan1.Hp <= 0)
            {
                titan1.Hp=0;
                this.Controls.Remove(label_t1a);
                this.Controls.Remove(label_t1h);
                this.Controls.Remove(label_t1m);
                this.Controls.Remove(progressBar1);
                this.Controls.Remove(progressBar20);
            }
            if (titan1.Hp > progressBar1.Maximum)
            {
                titan1.Hp = progressBar1.Maximum;
            } 

            if (titan2.Hp <= 0)
            {
                titan2.Hp = 0;
                this.Controls.Remove(label_t2a);
                this.Controls.Remove(label_t2h);
                this.Controls.Remove(label_t2m);
                this.Controls.Remove(progressBar9);
                this.Controls.Remove(progressBar8);
            }
            if (titan2.Hp > progressBar9.Maximum)
            {
                titan2.Hp = progressBar9.Maximum;
            }

            if (ninja1.Hp <= 0)
            {
                ninja1.Hp = 0;
                this.Controls.Remove(label_n1a);
                this.Controls.Remove(label_n1h);
                this.Controls.Remove(label_n1m);
                this.Controls.Remove(progressBar19);
                this.Controls.Remove(progressBar18);
            }
            if (ninja1.Hp > progressBar18.Maximum)
            {
                ninja1.Hp = progressBar18.Maximum;
            }

            if (ninja2.Hp <= 0)
            {
                ninja2.Hp = 0;
                this.Controls.Remove(label_n2a);
                this.Controls.Remove(label_n2h);
                this.Controls.Remove(label_n2m);
                this.Controls.Remove(progressBar11);
                this.Controls.Remove(progressBar10);
            }
            if (ninja2.Hp > progressBar11.Maximum)
            {
                ninja2.Hp = progressBar11.Maximum;
            }

            if (astronomer1.Hp <= 0)
            {
                astronomer1.Hp = 0;
                this.Controls.Remove(label_a1a);
                this.Controls.Remove(label_a1h);
                this.Controls.Remove(label_a1m);
                this.Controls.Remove(progressBar17);
                this.Controls.Remove(progressBar16);
            }
            if (astronomer1.Hp > progressBar17.Maximum)
            {
                astronomer1.Hp = progressBar17.Maximum;
            }

            if (astronomer2.Hp <= 0)
            {
                astronomer2.Hp = 0;
                this.Controls.Remove(label_a2a);
                this.Controls.Remove(label_a2h);
                this.Controls.Remove(label_a2m);
                this.Controls.Remove(progressBar7);
                this.Controls.Remove(progressBar6);
            }
            if (astronomer2.Hp > progressBar7.Maximum)
            {
                astronomer2.Hp = progressBar7.Maximum;
            }

            if (sisadmin1.Hp <= 0)
            {
                sisadmin1.Hp = 0;
                this.Controls.Remove(label_s1a);
                this.Controls.Remove(label_s1h);
                this.Controls.Remove(label_s1m);
                this.Controls.Remove(progressBar15);
                this.Controls.Remove(progressBar14);
            }
            if (sisadmin1.Hp > progressBar15.Maximum)
            {
                sisadmin1.Hp = progressBar15.Maximum;
            }

            if (sisadmin2.Hp <= 0)
            {
                sisadmin2.Hp = 0;
                this.Controls.Remove(label_s2a);
                this.Controls.Remove(label_s2h);
                this.Controls.Remove(label_s2m);
                this.Controls.Remove(progressBar5);
                this.Controls.Remove(progressBar4);
            }
            if (sisadmin2.Hp > progressBar5.Maximum)
            {
                sisadmin2.Hp = progressBar5.Maximum;
            }

            if (halk1.Hp <= 0)
            {
                halk1.Hp = 0;
                this.Controls.Remove(label_h1a);
                this.Controls.Remove(label_h1h);
                this.Controls.Remove(label_h1m);
                this.Controls.Remove(progressBar13);
                this.Controls.Remove(progressBar12);
            }
            if (halk1.Hp > progressBar13.Maximum)
            {
                halk1.Hp = progressBar13.Maximum;
            }

            if (halk2.Hp <= 0)
            {
                halk2.Hp = 0;
                this.Controls.Remove(label_h2a);
                this.Controls.Remove(label_h2h);
                this.Controls.Remove(label_h2m);
                this.Controls.Remove(progressBar3);
                this.Controls.Remove(progressBar2);
            }
            if (halk2.Hp > progressBar3.Maximum)
            {
                halk2.Hp = progressBar3.Maximum;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            progressBar1.Maximum = titan1.Hp;
            progressBar20.Maximum = titan1.Mp;

            progressBar18.Maximum = ninja1.Hp;
            progressBar19.Maximum = ninja1.Mp;

            progressBar11.Maximum = ninja2.Hp;
            progressBar10.Maximum = ninja2.Mp;

            progressBar9.Maximum = titan2.Hp;
            progressBar8.Maximum = titan2.Mp;

            progressBar17.Maximum = astronomer1.Hp;
            progressBar16.Maximum = astronomer1.Mp;

            progressBar7.Maximum = astronomer2.Hp;
            progressBar6.Maximum = astronomer2.Mp;

            progressBar15.Maximum = sisadmin1.Hp;
            progressBar14.Maximum = sisadmin1.Mp;

            progressBar5.Maximum = sisadmin2.Hp;
            progressBar4.Maximum = sisadmin2.Mp;

            progressBar13.Maximum = halk1.Hp;
            progressBar12.Maximum = halk1.Mp;

            progressBar3.Maximum = halk2.Hp;
            progressBar2.Maximum = halk2.Mp;

            LabelUpdate();
        }
        void LabelUpdate()
        {
            Hero_death();
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
        
        private void ninja1_button_Click(object sender, EventArgs e)
        {
            nh = true;
            ninja2_button.Visible = true;
            titan2_button.Visible = true;
            astronomer2_button.Visible = true;
            sisadmin2_button.Visible = true;
            halk2_button.Visible = true;
            
        }

        private void titan1_button_Click(object sender, EventArgs e)
        {
            List<Charecter> targets = new List<Charecter>();            
            targets.Add(titan1);
            listBox1.Items.Add(titan1.Skill1(targets));
            LabelUpdate();
        }

        private void astronomer1_button_Click(object sender, EventArgs e)
        {

            List<Charecter> targets = new List<Charecter>();            
            targets.Add(titan2);
            targets.Add(astronomer2);
            targets.Add(astronomer1);
            targets.Add(sisadmin2);
            targets.Add(ninja2);
            targets.Add(halk2);
            listBox1.Items.Add(astronomer1.Skill1(targets));
            LabelUpdate();
        }

        private void sisadmin1_button_Click(object sender, EventArgs e)
        {
            List<Charecter> targets = new List<Charecter>();
            ninja2_button.Visible = true;
            titan2_button.Visible = true;
            astronomer2_button.Visible = true;
            sisadmin2_button.Visible = true;
            halk2_button.Visible = true;
            targets.Add(titan1);
            listBox1.Items.Add(sisadmin1.Skill1(targets));
            LabelUpdate();
        }

        private void halk1_button_Click(object sender, EventArgs e)
        {
            nh = false;
            List<Charecter> targets = new List<Charecter>();
            ninja2_button.Visible = true;
            titan2_button.Visible = true;
            astronomer2_button.Visible = true;
            sisadmin2_button.Visible = true;
            halk2_button.Visible = true;
            targets.Add(titan1);
            listBox1.Items.Add(halk1.Skill1(targets));
            LabelUpdate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nh)
            {
                targets.Clear();
                targets.Add(ninja2);
                listBox1.Items.Add(ninja1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
            else
            {
                targets.Clear();
                targets.Add(ninja2);
                listBox1.Items.Add(halk1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nh)
            {
                targets.Clear();
                targets.Add(titan2);
                listBox1.Items.Add(ninja1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
            else
            {
                targets.Clear();
                targets.Add(titan2);
                listBox1.Items.Add(halk1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nh)
            {
                targets.Clear();
                targets.Add(astronomer2);
                listBox1.Items.Add(ninja1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
            else
            {
                targets.Clear();
                targets.Add(astronomer2);
                listBox1.Items.Add(halk1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nh)
            {
                targets.Clear();
                targets.Add(sisadmin2);
                listBox1.Items.Add(ninja1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
            else
            {
                targets.Clear();
                targets.Add(sisadmin2);
                listBox1.Items.Add(halk1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (nh)
            {
                targets.Clear();
                targets.Add(halk2);
                listBox1.Items.Add(ninja1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
            else
            {
                targets.Clear();
                targets.Add(halk2);
                listBox1.Items.Add(halk1.Skill1(targets));
                LabelUpdate();
                ninja2_button.Visible = false;
                titan2_button.Visible = false;
                astronomer2_button.Visible = false;
                sisadmin2_button.Visible = false;
                halk2_button.Visible = false;
            }
        }

    }
}