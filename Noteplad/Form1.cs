using System;
using System.IO;
using System.Windows.Forms;

namespace Noteplad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string retezec;
        int velikost = 0; 

        private void btn_konec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_caps_Click(object sender, EventArgs e)
        {
            if (velikost == 0)
            {
                velikost++;
                btn_a.Text = "A";
                btn_b.Text = "B";
                btn_c.Text = "C";
                btn_d.Text = "D";
                btn_e.Text = "E";
                btn_f.Text = "F";
                btn_g.Text = "G";
                btn_h.Text = "H";
                btn_i.Text = "I";
                btn_j.Text = "J";
                btn_k.Text = "K";
                btn_l.Text = "L";
                btn_m.Text = "M";
                btn_n.Text = "N";
                btn_o.Text = "O";
                btn_p.Text = "P";
                btn_q.Text = "Q";
                btn_r.Text = "R";
                btn_s.Text = "S";
                btn_t.Text = "T";
                btn_u.Text = "U";
                btn_v.Text = "V";
                btn_w.Text = "W";
                btn_x.Text = "X";
                btn_y.Text = "Y";
                btn_z.Text = "Z";
            }
            else
            {
                velikost--;
                btn_a.Text = "a";
                btn_b.Text = "b";
                btn_c.Text = "c";
                btn_d.Text = "d";
                btn_e.Text = "e";
                btn_f.Text = "f";
                btn_g.Text = "g";
                btn_h.Text = "h";
                btn_i.Text = "i";
                btn_j.Text = "j";
                btn_k.Text = "k";
                btn_l.Text = "l";
                btn_m.Text = "m";
                btn_n.Text = "n";
                btn_o.Text = "o";
                btn_p.Text = "p";
                btn_q.Text = "q";
                btn_r.Text = "r";
                btn_s.Text = "s";
                btn_t.Text = "t";
                btn_u.Text = "u";
                btn_v.Text = "v";
                btn_w.Text = "w";
                btn_x.Text = "x";
                btn_y.Text = "y";
                btn_z.Text = "z";
            }
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "a";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "A";
                scrn.Text = retezec;
            }
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "b";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "B";
                scrn.Text = retezec;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "c";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "C";
                scrn.Text = retezec;
            }
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "d";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "D";
                scrn.Text = retezec;
            }
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "e";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "E";
                scrn.Text = retezec;
            }
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "f";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "F";
                scrn.Text = retezec;
            }
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "g";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "G";
                scrn.Text = retezec;
            }
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "h";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "H";
                scrn.Text = retezec;
            }
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "i";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "I";
                scrn.Text = retezec;
            }
        }

        private void btn_j_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "j";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "J";
                scrn.Text = retezec;
            }
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "k";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "K";
                scrn.Text = retezec;
            }
        }

        private void btn_l_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "l";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "L";
                scrn.Text = retezec;
            }
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "m";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "M";
                scrn.Text = retezec;
            }
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "n";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "N";
                scrn.Text = retezec;
            }
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "o";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "O";
                scrn.Text = retezec;
            }
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "p";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "P";
                scrn.Text = retezec;
            }
        }

        private void btn_q_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "q";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "Q";
                scrn.Text = retezec;
            }
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "r";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "R";
                scrn.Text = retezec;
            }
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "s";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "S";
                scrn.Text = retezec;
            }
        }

        private void btn_t_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "t";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "T";
                scrn.Text = retezec;
            }
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "u";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "U";
                scrn.Text = retezec;
            }
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "v";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "V";
                scrn.Text = retezec;
            }
        }

        private void btn_w_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "w";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "W";
                scrn.Text = retezec;
            }
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "y";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "Y";
                scrn.Text = retezec;
            }
        }

        private void btn_z_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "z";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "Z";
                scrn.Text = retezec;
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            retezec = retezec + "\r\n";
            scrn.Text = retezec;
        }

        private void btn_space_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            retezec = retezec + " ";
            scrn.Text = retezec;
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            retezec = retezec + ",";
            scrn.Text = retezec;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            retezec = retezec + ".";
            scrn.Text = retezec;
        }

        private void btn_vykrk_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            retezec = retezec + "!";
            scrn.Text = retezec;
        }

        private void btn_otazk_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            retezec = retezec + "?";
            scrn.Text = retezec;
        }

        

        private void btn_x_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (velikost == 0)
            {
                retezec = retezec + "x";
                scrn.Text = retezec;
            }
            else
            {
                retezec = retezec + "X";
                scrn.Text = retezec;
            }
        }

        private void btn_bckspc_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            if (retezec.EndsWith("\r\n") == true)
            {
                retezec = retezec.Remove(retezec.Length - 2, 2);
                scrn.Text = retezec;
            }
            else if (retezec != "")
            {
                retezec = retezec.Remove(retezec.Length - 1, 1);
                scrn.Text = retezec;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            retezec = "";
            scrn.Text = retezec;
        }

        private void btn_uloz_Click(object sender, EventArgs e)
        {
            retezec = scrn.Text;
            StreamWriter sw = new StreamWriter("lol.txt");
            sw.WriteLine(retezec);
            sw.Close();
        }

        private void Btn_nact_Click(object sender, EventArgs e)
        {
            retezec = File.ReadAllText("lol.txt");
            scrn.Text = retezec;
        }
    }
}
