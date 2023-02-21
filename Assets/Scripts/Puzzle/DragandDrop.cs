

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject target;

    private RectTransform sourceRectTransform;
    private RectTransform targetRectTransform;
    private Canvas canvas;
    private Vector2 originalPosition;

    private void Start()
    {
        sourceRectTransform = GetComponent<RectTransform>();
        targetRectTransform = target.GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        originalPosition = sourceRectTransform.anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Move the source UI image along with the mouse
        sourceRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // If the source UI image is close enough to the target UI image, snap it to the target
        if (Vector2.Distance(sourceRectTransform.anchoredPosition, targetRectTransform.anchoredPosition) < 50f)
        {
            sourceRectTransform.anchoredPosition = targetRectTransform.anchoredPosition;
        }
        else
        {
            // If the source UI image is not close enough to the target, reset its position to the original
            sourceRectTransform.anchoredPosition = originalPosition;
        }
    }
}

