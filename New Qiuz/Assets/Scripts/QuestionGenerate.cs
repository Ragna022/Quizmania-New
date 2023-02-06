using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
  
    void Update()
    {
        if (displayingQuestion == false)
        {   
            displayingQuestion = true;
            questionNumber = Random.Range(1, 6);
            if (questionNumber == 1)
            {
              
                QuestionDisplay.newQuestion = "HOW MANY PAPER DO YOU NEED TO CRAFT A BOOK?";
                QuestionDisplay.newA = "7";
                QuestionDisplay.newB = "4";
                QuestionDisplay.newC = "3";
                actualAnswer = "C";
                

            }
            if (questionNumber == 2)
            {
                
                QuestionDisplay.newQuestion = "HOW MANY ORES ARE THERE?";
                QuestionDisplay.newA = "6";
                QuestionDisplay.newB = "4";
                QuestionDisplay.newC = "7";
                actualAnswer = "A";
            }
            if (questionNumber == 3)
            {
                
                QuestionDisplay.newQuestion = "WATCH THE VIDEO AND ANSWER THE QUESTION. What is Notch’s real name?";
                QuestionDisplay.newA = "Markus Persson";
                QuestionDisplay.newB = "Mojang Mineo";
                QuestionDisplay.newC = "Steve Jobs";
                actualAnswer = "A";
            }
            if (questionNumber == 4)
            {
                
                QuestionDisplay.newQuestion = "WHICH GAME MODE HAS PLAYERS COLLECT RESOURCES, BUILD STRUCTURES, BATTLE MOBS, EAT, AND EXPLORE THE WORLD?";
                QuestionDisplay.newA = "Creative";
                QuestionDisplay.newB = "Survival";
                QuestionDisplay.newC = "Spectator";
                actualAnswer = "B";
            }
            if (questionNumber == 5)
            {
                
                QuestionDisplay.newQuestion = "WHICH GAME MODE ALLOWS PLAYERS TO CREATE WITH UNLIMITED RESOURCES?";
                QuestionDisplay.newA = "Survival";
                QuestionDisplay.newB = "Hardcore";
                QuestionDisplay.newC = "Creative";
                actualAnswer = "C";
            }
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
