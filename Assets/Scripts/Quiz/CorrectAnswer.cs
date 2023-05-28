using UnityEngine;
using UnityEngine.UI;

public class CorrectAnswer : MonoBehaviour
{
    // Reference to the Text component of the button
    private Text buttonText;

    private void Start()
    {
        // Get the Text component of the button
        buttonText = GetComponentInChildren<Text>();
    }

    public void OnClick()
    {
        // Change the text of the button to "Correct"
        buttonText.text = "Correct";
    }
}