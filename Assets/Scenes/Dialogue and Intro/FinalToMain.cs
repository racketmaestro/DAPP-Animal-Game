using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalToMain : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitButton()
    {
        SceneManager.LoadScene("main screen");
    }

}

