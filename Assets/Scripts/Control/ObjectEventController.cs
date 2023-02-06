using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEventController : MonoBehaviour
{
    public GameObject[] objects;
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
        if (objects[currentObject] == null || !objects[currentObject].activeSelf)
        {
            currentObject++;

            if (currentObject >= objects.Length)
            {
                return;
            }

            objects[currentObject].SetActive(true);
        }
    }
}
