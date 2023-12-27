using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralsImpl
    {
        private const string connectionString = ConfigurationManager[""];
        public static string EnChiffreRomain(int chiffre)
        {
            string chiffreRomain = string.Empty;

            // Tableau des différentes numération
            uint[] numeration = new uint[4] { 1000, 100, 10, 1 };
            // Tableau milliers, centaines, dizaines, unité des caractére utilisé en chiffre romain pour former les chiffres
            char[,] chiffreRomainLettre = new char[4, 3]
            {
        { 'M', '\0', '\0' },
        { 'C', 'D', 'M'},
        { 'X', 'L', 'C'},
        { 'I', 'V', 'X'}
            };

            for (int i = 0; i < numeration.Length; i++)
            {
                if (chiffre >= numeration[i])
                {
                    // Prend le premier nombre du chiffre pour pouvoir le traiter
                    int firstChiffre = Convert.ToInt32(chiffre.ToString()[0].ToString());

                    // Ajoute les bon caractère romain en fonction du premier chiffre
                    switch (firstChiffre)
                    {
                        case 1:
                        case 2:
                        case 3:
                            // S'occupe des formats 1000: M, MM, MM; 100: C, CC, CCC; 10: X, XX, XXX; 1: I, II, III
                            for (int j = 0; j < firstChiffre; j++)
                            {
                                chiffreRomain += chiffreRomainLettre[i, 0];
                            }
                            break;
                        case 4:
                            // S'occupe des formats 100: CD; 10: XL; 1: IV
                            chiffreRomain += chiffreRomainLettre[i, 0];
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            break;
                        case 5:
                            // S'occupe des formats 100: D; 10: L; 1: V
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            break;
                        case 6:
                        case 7:
                        case 8:
                            // S'occupe des formats 100: DC, DCC, DCCC; 10: LX, LXX, LXX; 1: VI, VII, VIII
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            for (int j = 0; j < firstChiffre - 5; j++)
                            {
                                chiffreRomain += chiffreRomainLettre[i, 0];
                            }
                            break;
                        case 9:
                            // S'occupe des formats 100: CM; 10: XC; 1: IX;
                            chiffreRomain += chiffreRomainLettre[i, 0];
                            chiffreRomain += chiffreRomainLettre[i, 2];
                            break;
                    }
                }

                // Réduit à la numération inférieur
                chiffre %= (int)numeration[i];
            }

            return chiffreRomain;
        }
        //construction dictionnaire
        Dictionary<int, string> d1 = new Dictionary<int, string>() { };
        //d1.Add(2, "eetd");
        public static string EnChiffresRomains(long monEntier)
        {

            string chiffreRomain = "";
            //Tuple<long>[] chiffre =  {
            //new Tuple<long>(1000),
            //new Tuple<long>(900),
            //new Tuple<long>(500),
            //new Tuple<long>(100),
            //new Tuple<long>(50),
            //new Tuple<long>(10),
            //new Tuple<long>(9),
            //new Tuple<long>(5),
            //new Tuple<long>(1) };

            Tuple<int, string>[] chiffre3 =
            {
                Tuple.Create(1000,"M"),
                Tuple.Create(900,"CM"),
                Tuple.Create(500,"D"),
                Tuple.Create(100,"C"),
                Tuple.Create(90,"XC"),
                Tuple.Create(50,"L"),
                Tuple.Create(10,"X"),
                Tuple.Create(9,"IX"),
                Tuple.Create(5,"V"),
                Tuple.Create(4,"IV"),
                Tuple.Create(1,"I")
             };

            //Dictionary<int, string> chiffre2 = new Dictionary<int, string>();
            //chiffre2.Add(1000, "M");
            //chiffre2.Add(900, "CM");
            //chiffre2.Add(500, "D");
            //chiffre2.Add(100, "C");
            //chiffre2.Add(90, "XC");
            //chiffre2.Add(50, "L");
            //chiffre2.Add(10, "X");
            //chiffre2.Add(9, "IX");
            //chiffre2.Add(5, "V");
            //chiffre2.Add(1, "I");


            int i = 0;
            //Console.WriteLine(chiffre2[10]);  //GetValue(i)
            //Console.WriteLine(chiffre2[10].Equals("C"));  //GetValue(i)
            //Console.WriteLine(chiffre2.GetValueOrDefault(10));  //GetValue(i)
            ////Console.WriteLine(chiffre2.Keys);  //GetValue(i)
            //Console.WriteLine("hey : "+chiffre3[1].Item2);
            //foreach (int key in chiffre2.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            while (monEntier != 0)
            {
                while (monEntier - chiffre3[i].Item1 >= 0)
                {
                    monEntier = monEntier - chiffre3[i].Item1;
                    chiffreRomain = chiffreRomain + chiffre3[i].Item2;
                }
                i++;
            }
            return (chiffreRomain);

        }
        public static void RecuperationDonneeEnBase()
        {
            using(SqlConnection conn=new SqlConnection(connectionString))
            { 
            
            }
        }
    }
}
