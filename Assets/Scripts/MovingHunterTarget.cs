using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MovingHunterTarget : MonoBehaviour
{
    private RectTransform rectTransform;
    private Vector2 targetPosition;
    private RectTransform canvasRectTransform;
    public float moveSpeed = 1f;
    public GameObject animationObject;
    private Animator animator;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasRectTransform = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
        SetNewTargetPosition();
        animator = animationObject.GetComponent<Animator>();
    }

    void Update()
    {
        rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, targetPosition, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(rectTransform.anchoredPosition, targetPosition) < 0.1f)
        {
            SetNewTargetPosition();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 tapPoint = Input.mousePosition;
            if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, tapPoint))
            {
                Destroy(gameObject);
                //animator.SetTrigger("Fall Trigger");
                animationObject.GetComponent<Animator>().Play("Stumble Backwards");

            }
        }
    }

    private void SetNewTargetPosition()
    {
        Vector2 canvasSize = new Vector2(canvasRectTransform.rect.width, canvasRectTransform.rect.height) / 2f;
        targetPosition = new Vector2(Random.Range(-canvasSize.x, canvasSize.x), Random.Range(-canvasSize.y, canvasSize.y));
    }

}
