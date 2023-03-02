/*using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MovingHunterTarget : MonoBehaviour
{
    private RectTransform rectTransform;
    private Vector2 targetPosition;
    private RectTransform canvasRectTransform;
    public float moveSpeed = 1f;
    public GameObject animationObject;
    public GameObject CanvasObject;
    private Animator animator;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        *//*canvasRectTransform = GetComponentInParent<Canvas>().GetComponent<RectTransform>();*//*
        canvasRectTransform = CanvasObject.GetComponent<RectTransform>();
        Debug.Log(canvasRectTransform);
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


}*/


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
    public GameObject CanvasObject;
    public GameObject ObjectToDestroy;
    private Animator animator;
    private Image image;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasRectTransform = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
        SetNewTargetPosition();
        animator = animationObject.GetComponent<Animator>();
        image = GetComponent<Image>();
    }

    /*    void Update()
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
                    animationObject.GetComponent<Animator>().Play("Stumble Backwards");
                }
            }
        }*/
    private bool isDestroying = false;

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
                image.color = new Color(0, 0, 0, 0);
                if (!isDestroying)
                {
                    isDestroying = true;
                    StartCoroutine(DestroyObjectAfterDelay());
                    animationObject.GetComponent<Animator>().Play("Stumble Backwards");
                }
            }
        }
    }

    private IEnumerator DestroyObjectAfterDelay()
    {
        yield return new WaitForSeconds(6f);
        Destroy(ObjectToDestroy);
    }




    private void SetNewTargetPosition()
    {
        RectTransform canvasObjectRectTransform = CanvasObject.GetComponent<RectTransform>();
        Vector2 canvasSize = new Vector2(canvasObjectRectTransform.rect.width, canvasObjectRectTransform.rect.height) / 2f;
        float x = Random.Range(-canvasSize.x + rectTransform.sizeDelta.x / 2, canvasSize.x - rectTransform.sizeDelta.x / 2);
        float y = Random.Range(-canvasSize.y + rectTransform.sizeDelta.y / 2, canvasSize.y - rectTransform.sizeDelta.y / 2);
        targetPosition = new Vector2(x, y);
    }
}

