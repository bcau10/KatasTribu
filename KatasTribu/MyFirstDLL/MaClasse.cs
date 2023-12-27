using System.IO;

namespace MyFirstDLL
{
    public class MaClasse
    { //même si on ne peut pas le lancer car il n'y a pas d'exe, il faut générer la solution une première fois pour générer le dll dans le bin, au même endroit le pdb est un fichier qui permet le débogage
        public static string GetFileName(string dir)
        {
            if (File.Exists(dir))
            {
                return (Path.GetFileName(dir));
            }
            else
            {
                return ("File not found");
            }
        }
    }
}

