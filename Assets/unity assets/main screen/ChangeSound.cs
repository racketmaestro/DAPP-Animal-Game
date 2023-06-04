using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    // Start is called before the first frame update
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource;

    void Start()
    {
        soundOnImage = button.image.sprite;
        // button.image.sprite = soundOnImage;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        if (isOn)
        {
            // button.image.sprite = soundOffImage;
            soundOffImage = button.image.sprite;

            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            // button.image.sprite = soundOnImage;
            soundOnImage = button.image.sprite;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
