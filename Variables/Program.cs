using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables!"); // Display the text "Variables!"
            Console.WriteLine(""); // Adding a space on the Display

            // Variables

            // Integers
            int score; // Decaralion -- Declare "score" is an Integer
            int enemyPoints; // Decaralion -- Declare "enemyPoints" is an Integer

            Console.WriteLine("Integers"); // Display the text "Integers"

            score = 0; // Initialization -- Init. "score" to be 0
            enemyPoints = 50; // Initialization -- 50 pts per kill
            
            Console.WriteLine("Score: " + score); // Display Score: "score"
            
            score = score + enemyPoints; // enemy killed
            
            Console.WriteLine("New Score: " + score); // Display New Score: "score"
            Console.WriteLine(""); // Adding a space on the Display

            // Floating points
            float lapTime; // Decaralion -- Declare "lapTime"
            
            Console.WriteLine("Floating points"); // Display the text "Floating points"
            
            lapTime = 0.0f; // Initialization -- Init. "lapTime" to be 0
            
            Console.WriteLine("Laptime: " + lapTime); // Display Laptime: "lapTime"
            
            lapTime = 65.357f; // Set "lapTime" to 65.357
            
            Console.WriteLine("Your new Laptime: " + lapTime); // Display Your new Laptime: "lapTime"
            Console.WriteLine(""); // Adding a space on the Display

            // String (text)
            string title; // Decaralion -- Declare "title"
            
            Console.WriteLine("String (text)"); // Display the text "String (text)"
            
            title = "Newbie"; // Initialization -- Init. "title" to be Newbie

            Console.WriteLine("Your title: " + title); // Display Your title: "title"
            
            title = "Pro"; // Set "title" to be Pro
            
            Console.WriteLine("Your new title: " + title); // Display Your new title: "title"
            Console.WriteLine(""); // Adding a space on the Display


            Console.ReadKey(true); // Read Key-Press
        }
    }
}
