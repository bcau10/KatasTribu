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

namespace TestThreadSurApplication
{
    public partial class Form1 : Form
    {
        private int[] liste = new int[500000];
        private Random random = new Random((int)DateTime.Now.Ticks); //on initialise le générateur aléatoire
        private bool termine = true;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = random.Next(60000); //valeur comprise entre 0 et 60000
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (termine)
            {
                Thread t = new Thread(Traitement);
                termine = false;
                t.Start();
            }
        }
        public void Traitement()
        {
            int total = 0;
            for (int i = 0; i < liste.Length; i++)
            {
                if (liste[i] < 500)
                {
                    ++total;
                    int v = (int)(i / (double)liste.Length * 100);
                    //progressBar1.Value = v; //progressBar composant graphique, les composants graphiques sont gérés par un thread spécial
                    Invoke(new Action<int>(Progress), v); //on passe par la fonction Invoke
                }
            }
            //je ne peux pas écrire labelResultat.Text=total.toString() car je suis à l'intérieur d'un thread et je n'ai pas le droit d'accéder à un composant graphique car ils sont gérés par un autre thread donc je dois passer par Invoke
            //labelResultat.Text = total.toString();
            Invoke(new Action<int>(Resultat), total); //cette classe Action est un delegate
        }
        public void Progress(int v)
        {
            progressBar1.Value = v;
            labelEvolution.Text = v.ToString();
        }
        public void Resultat(int v)
        {
            labelResultat.Text = v.ToString();
            termine = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
