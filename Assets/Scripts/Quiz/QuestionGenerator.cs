
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionGenerator : MonoBehaviour
{
    public int totalQuestions;
    public GameObject questionPanel;
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    private int questionNumber = 0;
 /*   public string NextScene;*/
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
            /*SceneManager.LoadScene(NextScene);*/
            questionPanel.SetActive(false);
        }
        QuestionDisplay.updateQuestion = false;
    }

}
