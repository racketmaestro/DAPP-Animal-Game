using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber = 0;
    

    void Update()
    {
        //Will generate a question only if there is not a question being displayed
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            //questionNumber = Random.Range(1, 3);
            questionNumber++;

            for (int i = 1; i <= 3; i++)
            {
                //int questionNumber = i
                if (questionNumber == 1)
                {
                    QuestionDisplay.newQuestion = "Wild tigers live in Asia, and most populations inhabit tropical regions in countries such as Thailand, Indonesia and India. What kind of habitat do you think Bengal/Bali/etc tiger live in?";
                    QuestionDisplay.newA = "Sahara Desert";
                    QuestionDisplay.newB = "Tropical Jungle";
                    QuestionDisplay.newC = "Arctic Circle";
                    QuestionDisplay.newD = "Pacific Ocean";
                    actualAnswer = "B";
                }
                if (questionNumber == 2)
                {
                    QuestionDisplay.newQuestion = "What is the name of a baby tiger?";
                    QuestionDisplay.newA = "Cub";
                    QuestionDisplay.newB = "Kitten";
                    QuestionDisplay.newC = "Puppy";
                    QuestionDisplay.newD = "Foal";
                    actualAnswer = "A";
                }
            }

        }

        // All questions go above here
        QuestionDisplay.updateQuestion = false;
    }
}
