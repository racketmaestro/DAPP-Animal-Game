using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIntroScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextButton()
    {
        SceneManager.LoadScene("Intro Scene");
    }

}
