using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tastaturatelefon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int counter = 0;
        public int CURRENTBUTONPRESSED = -1;

        public char[] butoane = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', '*' };
        public char[] letters = {
    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
    'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
    'U', 'V', 'X', 'Z', 'W', 'Y', 
    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
    '-', '+', '*', '/', '=', '?', '!', ' ', '(', ')',
    '@', '#', '$', '%', '^', '&', '[', ']', '{', '}',
    ';', '\'', '\\', '|', '"', ':', '<', '>', '/', '`',
    ' ',' ',' ',' ',' ',' ',
    ' ',' ',' ',' ',' ',' ',
        ' ',' ',' ',' ',' ',' ',
        ' ',' ',' ',' ',' ',' ',
        ' ',' ',' ',' ',' ',' ',
        ' ',' ',' ',' ',' ',' '
                                };

        public string[] cuvinte = { "alfa", "beta", "gamma", "delta", "epsilon", "iotta", "miu", "pi", "tetta", "zero" };

        List<buton> listabutoane = new List<buton>();

        // la apasarea unei taste se verifica daca cuvintele din lista 
        // se pot forma in functie de numarul de taste apasate dupa spatiu

        public int pressedbuton(int i)
        {
            CURRENTBUTONPRESSED = i;
            Text = i.ToString();
            if (i < 9)
            {
                textBox1.Text += (i + 1).ToString();
            }
            else
            {
                if (i == 9) { textBox1.Text += "#"; }
                else if (i == 10) { textBox1.Text += "0"; }
                else if (i == 11) { textBox1.Text += "*"; }
            }
            return i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Text = letters.Length.ToString(); //=72 / 12 = 6
            //adauga noi butoane la lista de butoane
            //si adauga literele in fiecare buton
            int k = -1;
            for (int i = 0; i < butoane.Length; i++)
            {
                listabutoane.Add(new buton());
                //trebuie sa adaugi un buton
                listabutoane[i].nr = butoane[i];
                for (int j = 0; j < 3; j++)
                {
                    k++;
                    try
                    {
                        listabutoane[i].litere.Add(letters[k]); //k++ va genera o eroare la fiecare try error
                    }
                    catch { }
                }

            }
            try
            {
                ctrlbuton1.setctrlbuton(0);
                ctrlbuton2.setctrlbuton(1);
                ctrlbuton3.setctrlbuton(2);
                ctrlbuton4.setctrlbuton(3);
                ctrlbuton5.setctrlbuton(4);
                ctrlbuton6.setctrlbuton(5);
                ctrlbuton7.setctrlbuton(6);
                ctrlbuton8.setctrlbuton(7);
                ctrlbuton9.setctrlbuton(8);
                ctrlbuton10.setctrlbuton(9);
                ctrlbuton11.setctrlbuton(10);
                ctrlbuton12.setctrlbuton(11);
                //pe fiecare buton adauga literele


                //adauga literele si numerele pe butoane
                ctrlbuton1.setLabel1("1");
                ctrlbuton2.setLabel1("2");
                ctrlbuton3.setLabel1("3");
                ctrlbuton4.setLabel1("4");
                ctrlbuton5.setLabel1("5");
                ctrlbuton6.setLabel1("6");
                ctrlbuton7.setLabel1("7");
                ctrlbuton8.setLabel1("8");
                ctrlbuton9.setLabel1("9");
                ctrlbuton10.setLabel1("#");
                ctrlbuton11.setLabel1("0");
                ctrlbuton12.setLabel1("*");



                ctrlbuton1.setLabel2(listabutoane[0].litere[0].ToString() + " ");
                ctrlbuton2.setLabel2(listabutoane[1].litere[0].ToString() + " ");
                ctrlbuton3.setLabel2(listabutoane[2].litere[0].ToString() + " ");
                ctrlbuton4.setLabel2(listabutoane[3].litere[0].ToString() + " ");
                ctrlbuton5.setLabel2(listabutoane[4].litere[0].ToString() + " ");
                ctrlbuton6.setLabel2(listabutoane[5].litere[0].ToString() + " ");
                ctrlbuton7.setLabel2(listabutoane[6].litere[0].ToString() + " ");
                ctrlbuton8.setLabel2(listabutoane[7].litere[0].ToString() + " ");
                ctrlbuton9.setLabel2(listabutoane[8].litere[0].ToString() + " ");
                ctrlbuton10.setLabel2(listabutoane[9].litere[0].ToString() + " ");
                ctrlbuton11.setLabel2(listabutoane[10].litere[0].ToString() + " ");
                ctrlbuton12.setLabel2(listabutoane[11].litere[0].ToString() + " ");

                ctrlbuton1.setLabel2(listabutoane[0].litere[1].ToString() + " ");
                ctrlbuton2.setLabel2(listabutoane[1].litere[1].ToString() + " ");
                ctrlbuton3.setLabel2(listabutoane[2].litere[1].ToString() + " ");
                ctrlbuton4.setLabel2(listabutoane[3].litere[1].ToString() + " ");
                ctrlbuton5.setLabel2(listabutoane[4].litere[1].ToString() + " ");
                ctrlbuton6.setLabel2(listabutoane[5].litere[1].ToString() + " ");
                ctrlbuton7.setLabel2(listabutoane[6].litere[1].ToString() + " ");
                ctrlbuton8.setLabel2(listabutoane[7].litere[1].ToString() + " ");
                ctrlbuton9.setLabel2(listabutoane[8].litere[1].ToString() + " ");
                ctrlbuton10.setLabel2(listabutoane[9].litere[1].ToString() + " ");
                ctrlbuton11.setLabel2(listabutoane[10].litere[1].ToString() + " ");
                ctrlbuton12.setLabel2(listabutoane[11].litere[1].ToString() + " ");

                ctrlbuton1.setLabel2(listabutoane[0].litere[2].ToString() + " ");
                ctrlbuton2.setLabel2(listabutoane[1].litere[2].ToString() + " ");
                ctrlbuton3.setLabel2(listabutoane[2].litere[2].ToString() + " ");
                ctrlbuton4.setLabel2(listabutoane[3].litere[2].ToString() + " ");
                ctrlbuton5.setLabel2(listabutoane[4].litere[2].ToString() + " ");
                ctrlbuton6.setLabel2(listabutoane[5].litere[2].ToString() + " ");
                ctrlbuton7.setLabel2(listabutoane[6].litere[2].ToString() + " ");
                ctrlbuton8.setLabel2(listabutoane[7].litere[2].ToString() + " ");
                ctrlbuton9.setLabel2(listabutoane[8].litere[2].ToString() + " ");
                ctrlbuton10.setLabel2(listabutoane[9].litere[2].ToString() + " ");
                ctrlbuton11.setLabel2(listabutoane[10].litere[2].ToString() + " ");
                ctrlbuton12.setLabel2(listabutoane[11].litere[2].ToString() + " ");

                ctrlbuton1.setLabel2(listabutoane[0].litere[3].ToString() + " ");
                ctrlbuton2.setLabel2(listabutoane[1].litere[3].ToString() + " ");
                ctrlbuton3.setLabel2(listabutoane[2].litere[3].ToString() + " ");
                ctrlbuton4.setLabel2(listabutoane[3].litere[3].ToString() + " ");
                ctrlbuton5.setLabel2(listabutoane[4].litere[3].ToString() + " ");
                ctrlbuton6.setLabel2(listabutoane[5].litere[3].ToString() + " ");
                ctrlbuton7.setLabel2(listabutoane[6].litere[3].ToString() + " ");
                ctrlbuton8.setLabel2(listabutoane[7].litere[3].ToString() + " ");
                ctrlbuton9.setLabel2(listabutoane[8].litere[3].ToString() + " ");
                ctrlbuton10.setLabel2(listabutoane[9].litere[3].ToString() + " ");
                ctrlbuton11.setLabel2(listabutoane[10].litere[3].ToString() + " ");
                ctrlbuton12.setLabel2(listabutoane[11].litere[3].ToString() + " ");

                ctrlbuton1.setLabel2(listabutoane[0].litere[4].ToString() + " ");
                ctrlbuton2.setLabel2(listabutoane[1].litere[4].ToString() + " ");
                ctrlbuton3.setLabel2(listabutoane[2].litere[4].ToString() + " ");
                ctrlbuton4.setLabel2(listabutoane[3].litere[4].ToString() + " ");
                ctrlbuton5.setLabel2(listabutoane[4].litere[4].ToString() + " ");
                ctrlbuton6.setLabel2(listabutoane[5].litere[4].ToString() + " ");
                ctrlbuton7.setLabel2(listabutoane[6].litere[4].ToString() + " ");
                ctrlbuton8.setLabel2(listabutoane[7].litere[4].ToString() + " ");
                ctrlbuton9.setLabel2(listabutoane[8].litere[4].ToString() + " ");
                ctrlbuton10.setLabel2(listabutoane[9].litere[4].ToString() + " ");
                ctrlbuton11.setLabel2(listabutoane[10].litere[4].ToString() + " ");
                ctrlbuton12.setLabel2(listabutoane[11].litere[4].ToString() + " ");

                ctrlbuton1.setLabel2(listabutoane[0].litere[5].ToString() + " ");
                ctrlbuton2.setLabel2(listabutoane[1].litere[5].ToString() + " ");
                ctrlbuton3.setLabel2(listabutoane[2].litere[5].ToString() + " ");
                ctrlbuton4.setLabel2(listabutoane[3].litere[5].ToString() + " ");
                ctrlbuton5.setLabel2(listabutoane[4].litere[5].ToString() + " ");
                ctrlbuton6.setLabel2(listabutoane[5].litere[5].ToString() + " ");
                ctrlbuton7.setLabel2(listabutoane[6].litere[5].ToString() + " ");
                ctrlbuton8.setLabel2(listabutoane[7].litere[5].ToString() + " ");
                ctrlbuton9.setLabel2(listabutoane[8].litere[5].ToString() + " ");
                ctrlbuton10.setLabel2(listabutoane[9].litere[5].ToString() + " ");
                ctrlbuton11.setLabel2(listabutoane[10].litere[5].ToString() + " ");
                ctrlbuton12.setLabel2(listabutoane[11].litere[5].ToString() + " ");

                ctrlbuton1.setLabel2(listabutoane[0].litere[6].ToString() + " ");
                ctrlbuton2.setLabel2(listabutoane[1].litere[6].ToString() + " ");
                ctrlbuton3.setLabel2(listabutoane[2].litere[6].ToString() + " ");
                ctrlbuton4.setLabel2(listabutoane[3].litere[6].ToString() + " ");
                ctrlbuton5.setLabel2(listabutoane[4].litere[6].ToString() + " ");
                ctrlbuton6.setLabel2(listabutoane[5].litere[6].ToString() + " ");
                ctrlbuton7.setLabel2(listabutoane[6].litere[6].ToString() + " ");
                ctrlbuton8.setLabel2(listabutoane[7].litere[6].ToString() + " ");
                ctrlbuton9.setLabel2(listabutoane[8].litere[6].ToString() + " ");
                ctrlbuton10.setLabel2(listabutoane[9].litere[6].ToString() + " ");
                ctrlbuton11.setLabel2(listabutoane[10].litere[6].ToString() + " ");
                ctrlbuton12.setLabel2(listabutoane[11].litere[6].ToString() + " ");
                /*  */
                //la tastarea unei litere verifica daca poate forma un cuvant din lista de cuvinte
                //in functie de counterul de litere cauta daca exista un cuvant care sa aiba pe pozitia x litera respectiva
            }
            catch { }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                counter = textBox1.Text.Length;
                textBox2.Text = counter.ToString();

                // stiind acuma a cata tasta si ce cifra scrie pe tasta
                // si faptul ca una dintre literele de pe tasta apasata trebuie
                // sa fie a counter 'a ditrun cuvant dat atunci se poate face cautari
                // daca litera counter 'a din cuvinat este litera 1,2,3...n de pe tasta

                /*
                 exemplu este pentru un singur cuvant
                 se testeaza daca pe pozitia i exista litera c 
                 */

                string cuvants = "ALFA";

                int l = counter - 1;

                // exista cate n litere pe fiecare tasta
                // verifica pentru fiecare litera in parte

                char c0 = listabutoane[CURRENTBUTONPRESSED].litere[0];
                char c1 = listabutoane[CURRENTBUTONPRESSED].litere[1];
                char c2 = listabutoane[CURRENTBUTONPRESSED].litere[2];

                Text = cuvants[l].ToString() + c0.ToString();

                if (cuvants[l] == c0) { textBox3.Text += "c0"; }
                else if (cuvants[l] == c1) { textBox3.Text += "c1"; }
                else if (cuvants[l] == c2) { textBox3.Text += "c2"; }
                textBox3.Text += " ";
            }
            catch { }
        }
    }
}
