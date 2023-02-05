/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber = 0;
    public string NextScene;
    

    void Update()
    {
        //Will generate a question only if there is not a question being displayed
   
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber++;


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
                if (questionNumber == 3)
                {
                    SceneManager.LoadScene(NextScene);
                }
            //}

        }

        // All questions go above here
        QuestionDisplay.updateQuestion = false;
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionGenerator : MonoBehaviour
{
    public int totalQuestions;
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    private int questionNumber = 0;
    public string NextScene;
    public Question[] questions;
    

    [System.Serializable]
    public class Question
    {
        public string questionText;
        public string optionA;
        public string optionB;
        public string optionC;
        public string optionD;
        public string correctAnswer;
    }

    void Update()
    {
        //Will generate a question only if there is not a question being displayed
        if (displayingQuestion == false && questionNumber <= totalQuestions)
        {
            displayingQuestion = true;
            questionNumber++;
            QuestionDisplay.newQuestion = questions[questionNumber - 1].questionText;
            QuestionDisplay.newA = questions[questionNumber - 1].optionA;
            QuestionDisplay.newB = questions[questionNumber - 1].optionB;
            QuestionDisplay.newC = questions[questionNumber - 1].optionC;
            QuestionDisplay.newD = questions[questionNumber - 1].optionD;
            actualAnswer = questions[questionNumber - 1].correctAnswer;
        }
        else if (questionNumber > totalQuestions)
        {
            SceneManager.LoadScene(NextScene);
        }
        QuestionDisplay.updateQuestion = false;
    }

}
