using System;
using System.Threading;
namespace MonApplication2
{
    class Program
    {
        private static int compteur;
        private static object verrou = new object();
        private static SemaphoreSlim salleAttente=new SemaphoreSlim(3); //3=nb de threads à accéder au bloc d'instruction maximum ici 3
        public static void affiche(object obj)
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(obj);
            }
        }
        public static void afficheCompteur() //plusieurs threads agissent sur la même variable et la modifie ->compteur, il y a donc un problème de synchronisation à corriger
        {
            //lock (verrou)
            //{
                for (int i = 0; i < 100000; i++)
                {
                    {
                        compteur++;
                    }
                }
            //}
            Console.WriteLine(Thread.CurrentThread.Name + " Compteur=" + compteur);
        }
        public static void afficheCompteurPriseEnCompteVerrou() //plusieurs threads agissent sur la même variable et la modifie ->compteur, il y a donc un problème de synchronisation à corriger
        { //lock permet d'instaurer un verrou, cependant il autorise qu'un thread à la fois à accéder à un bloc d'instruction en l'ocurrence incrémenter la valeur compteur
            
            for (int i = 0; i < 100000; i++)
            {
                lock (verrou)
                {
                    compteur++;
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name + " Compteur=" + compteur);
        }
        public static void afficheCompteurPriseEnCompteVerrouPlusHaut() //plusieurs threads agissent sur la même variable et la modifie ->compteur, il y a donc un problème de synchronisation à corriger
        { //lock permet d'instaurer un verrou, cependant il autorise qu'un thread à la fois à accéder à un bloc d'instruction en l'ocurrence incrémenter la valeur compteur
            //quand un premier trade est en train d'exécuter la boucle automatiquement l'autre va attendre
            lock (verrou)
            {
                for (int i = 0; i < 100000; i++)
                { 
                    compteur++;
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name + " Compteur=" + compteur);
        }
        public static void AfficheSemaphoreSlim()
        {
            salleAttente.Wait();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Thread.CurrentThread.Name + "___");
                Thread.Sleep(1000);
            }
            salleAttente.Release();
        }
        public static void Exo1()
        {
            Thread t1 = new Thread(afficheCompteur);
            Thread t2 = new Thread(afficheCompteur);

            t1.Name = "T1";
            t2.Name = "T2";
            //Les priorités , par defaut meme priorité
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;

            t1.Start();//démarre le thread au niveau system et donc le thread fait parti de la liste d'attente et exécute la fonction
            t2.Start();
            
            //Synchronisation : parfois certains threads partagent des variables en commun et peuvent se lancer en commun

            //Console.ReadLine();
        }
        public static void Exo2() //lock dans la boucle 
        {
            Thread t1 = new Thread(afficheCompteurPriseEnCompteVerrou);
            Thread t2 = new Thread(afficheCompteurPriseEnCompteVerrou);

            t1.Name = "T1";
            t2.Name = "T2";
            //Les priorités , par defaut meme priorité
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            //Synchronisation : parfois certains threads partagent des variables en commun et peuvent se lancer en commun

            //Console.ReadLine();
        }
        public static void Exo3() //lock en dehors de la boucle
        {
            Thread t1 = new Thread(afficheCompteurPriseEnCompteVerrouPlusHaut);
            Thread t2 = new Thread(afficheCompteurPriseEnCompteVerrouPlusHaut);

            t1.Name = "T1";
            t2.Name = "T2";
            //Les priorités , par defaut meme priorité
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            //Synchronisation : parfois certains threads partagent des variables en commun et peuvent se lancer en commun

            //Console.ReadLine();
        }
        public static void Exo4() //autoriser un certain nb de thread à accéder à un bloc d'instruction avec SemaphoreSlim -> il crée une sorte de salle d'attente
        {// différence entre lock et Sémaphore ->
            Thread[] threads = new Thread[10];
            for (int i=0;i<threads.Length;i++)
            {
                threads[i] = new Thread(AfficheSemaphoreSlim);
                threads[i].Name = "T" + i;
                threads[i].Start();
            }
            Console.ReadLine();
        }
        public static void ExoAbstractClass()
        {
            Person p1 = new Employee();
            p1.Work();
            p1 = new Student();
            p1.Work();
            p1 = new Manager();
            p1.Work();
            //Person p2 = new Person();
            //p2.Work();
        }
        public static void test()
        {
            Console.WriteLine("Hello");
        }
        public static void testCreationDLL()
        {

        }
        static void Main(string[] args)
        {
            //pour synchroniser 2 possibilités, la fonction lock ou bien SemaphoreSlim
            //pour synchroniser on délimite le bloc soit avec lock pour que seulement 1 thread accès au bloc d'instruction ou bien par salleAttente.Wait() et salleAttente.Release()
            //Exo1();
            //Exo2();
            //Exo3();
            //Exo4();
            ExoAbstractClass();
        }
    }
}
