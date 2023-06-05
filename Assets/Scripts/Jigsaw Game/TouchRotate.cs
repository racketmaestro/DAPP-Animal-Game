using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchRotate : MonoBehaviour, IPointerClickHandler
{
    public AudioSource clickerFX;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!GameControl.youWin)
        transform.Rotate(0, 0, 90);
        clickerFX.Play();
    }
}
