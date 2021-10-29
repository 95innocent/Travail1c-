using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleList
{
    class Program
    {
     static void Main(string[] args)
     {
         //Les collections  Generiques
         //ArrayList
     //I)Colllections  generiques
            //1)Arraylist
            List<string> names= new List<string>(){"Innocent","Andre","Yvonne","Evelyne"};
            names.Add("Irakoze");
            names.Add("Innocent");
            names.Add("Vincent");
            names.Remove("Yvonne");
            names.RemoveAt(1);
            Console.WriteLine("Liste des noms avec List"); 
            foreach (string nom in names)
            {
               Console.WriteLine(nom); 
            }
            //2)Stack
            Stack<string> languages=new Stack<string>();
            languages.Push("java");
            languages.Push("C");
            languages.Push("C++");
            languages.Push("C#");
            languages.Push("Php");
             Console.WriteLine("Liste des languages de programmation avec Stack"); 
            foreach (string language in languages)
            {
               Console.WriteLine(language); 
            }
            //3)Queue
            Queue<string> languagess=new Queue<string>();
            languagess.Enqueue("java");
            languagess.Enqueue("C");
            languagess.Enqueue("C++");
            languagess.Enqueue("C#");
            languagess.Enqueue("Php");
            Console.WriteLine("Liste des languages de programmation avec Queue"); 
            foreach (string language in languagess)
            {
               Console.WriteLine(language); 
            }
            //4) Dictonnary
            Dictionary<int, string> languagesss = new Dictionary<int, string>(); 
            languagesss.Add(1, "Java");  
            languagesss.Add(2, "C#");                                                                      
            languagesss.Add(3, "Python");  
            languagesss.Add(4, "C++"); 
            Console.WriteLine("Liste des languages avec Dictionary");  
           foreach (KeyValuePair<int, string> language in languagesss)  
                    {  
                    Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);  
                    }
        //5)SortedList
          SortedList<int, string>  Cours = new SortedList<int, string> (); 
          Cours.Add(1, "Programmation web");  
          Cours.Add(2, "Base de donnees2");  
          Cours.Add(3, "Ingenieurie des logiciels");  
          Cours.Add(4, "Intelligence Artificielle");  
          Console.WriteLine("Liste des Cours avec SortedList");
                    foreach (KeyValuePair<int, string> nomcours in Cours)  
                    {  
                    Console.WriteLine("Clé: {0}, Valeur: {1}", nomcours.Key, nomcours.Value);  
                    }
       
     //Les collections Generiques


    }
        
    }
}
