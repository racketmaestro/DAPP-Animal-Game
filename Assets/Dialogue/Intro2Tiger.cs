using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro2Tiger : MonoBehaviour
{
    // Start is called before the first frame update
    public void SkipButton()
    {
        SceneManager.LoadScene("Tiger Scene");
    }

}

