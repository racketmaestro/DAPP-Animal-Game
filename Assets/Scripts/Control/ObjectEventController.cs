using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectEventController : MonoBehaviour
{
    public GameObject[] objects; // List of gameobjects to be controlled
    public string nextScene; // Name of the scene to load after the last object is destroyed or deactivated

    private int currentObject = 0;

    private void Start()
    {
        for (int i = 1; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
        }
    }

    private void Update()
    {
        // Check if the current object is either null or inactive
        if (objects[currentObject] == null || !objects[currentObject].activeSelf)
        {
            currentObject++;

            // Check if all objects have been processed
            if (currentObject >= objects.Length)
            {
                // Load the next scene
                SceneManager.LoadScene(nextScene);
                return;
            }

            objects[currentObject].SetActive(true);
        }
    }
}
