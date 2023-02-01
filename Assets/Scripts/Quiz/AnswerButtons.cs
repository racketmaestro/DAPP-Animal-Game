using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackBlue; //Blue is waiting
    public GameObject answerAbackGreen; //Green is correct
    public GameObject answerAbackRed; //Red is wrong

    public GameObject answerBbackBlue; //Blue is waiting
    public GameObject answerBbackGreen; //Green is correct
    public GameObject answerBbackRed; //Red is wrong

    public GameObject answerCbackBlue; //Blue is waiting
    public GameObject answerCbackGreen; //Green is correct
    public GameObject answerCbackRed; //Red is wrong

    public GameObject answerDbackBlue; //Blue is waiting
    public GameObject answerDbackGreen; //Green is correct
    public GameObject answerDbackRed; //Red is wrong


    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;


    public void AnswerA()
    {
        if (QuestionGenerator.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
        }
        StartCoroutine(NextQuestion());

        // Only allows you to press one button
        /*
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        */
    }

    public void AnswerB()
    {
        if (QuestionGenerator.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
        }

        StartCoroutine(NextQuestion());
        /*
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        */
    }

    public void AnswerC()
    {
        if (QuestionGenerator.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
        }
        StartCoroutine(NextQuestion());
        /*
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        */
    }

    public void AnswerD()
    {
        if (QuestionGenerator.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
        }
        StartCoroutine(NextQuestion());
        /*
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        */
    }

    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(2);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerator.displayingQuestion = false;
    }
}
