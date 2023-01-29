using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadARScene()
    {
        SceneManager.LoadScene("Tiger Scene");
    }
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Successfully Quit App");
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu_Scene");
    }
}
