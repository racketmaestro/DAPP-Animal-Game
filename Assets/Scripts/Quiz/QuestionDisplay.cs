using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;
    public static bool updateQuestion = false;

    void Update()
    {
        if (updateQuestion == false)
        {
            updateQuestion = true;
            StartCoroutine(PushTextOnScreen());
        }
    }

    // Using coroutines
    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<TMPro.TextMeshProUGUI>().text = newQuestion;
        answerA.GetComponent<TMPro.TextMeshProUGUI>().text = newA;
        answerB.GetComponent<TMPro.TextMeshProUGUI>().text = newB;
        answerC.GetComponent<TMPro.TextMeshProUGUI>().text = newC;
        answerD.GetComponent<TMPro.TextMeshProUGUI>().text = newD;
    }
}
