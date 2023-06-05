using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class XXDialogue : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public GameObject DialogueBox;
    public string[] sentences;
    private int Index = 0;
    public float DialogueSpeed;
    public Animator DialogueAnimator;
    private bool StartDialogue = true;
    private bool nextText = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (StartDialogue)
            {
                DialogueAnimator.SetTrigger("Enter");
                StartDialogue = false;
            }
            if (nextText == true)
            {
                nextText = false;
                NextSentence();
            }

        }


    }
    void NextSentence()
    {
        if (Index <= sentences.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentence());

        }
        else
        {
            DialogueText.text = "";
            DialogueAnimator.SetTrigger("Exit");
            StartCoroutine(DestroyObject());
        }
    }
    IEnumerator WriteSentence()
    {
        foreach (char Character in sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        nextText = true;
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(1f);
        /*Destroy(DialogueBox);*/
        DialogueBox.SetActive(false);
    }
}
