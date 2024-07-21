using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PageMove : MonoBehaviour
{

    public float fadeDuration = 3f;

    public Transform topLeftPoint;
    public Transform topRightPoint;
    public Transform bottomLeftPoint;
    public Transform bottomRightPoint;

    public float movementSpeed = 150f;
    public Image ImageToFadeIn;
    public Image ImageToFadeOut;

    private Transform targetPoint;
    private bool isMoving = true;
    private bool isFadeInFaded = false;
    private bool isFadeOutFaded = true;
    private bool isSecond = false;


    void Start()
    {
        targetPoint = topLeftPoint;

    }

    void Update()
    {
        if (isMoving && isFadeOutFaded)
        {
            MoveCamera();
        }
        else if (!isSecond)
        {
            ChangeImages();
        }
        else if (!isMoving && isSecond)
        {

            SceneManager.LoadScene(3);//Need to write number of scene with level 1
        }

    }

    void MoveCamera()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, movementSpeed * Time.deltaTime);

        if (transform.position == targetPoint.position)
        {
            ChangeTargetPoint();
        }
    }

    void ChangeTargetPoint()
    {
        if (targetPoint == topLeftPoint)
        {
            targetPoint = topRightPoint;
        }
        else if (targetPoint == topRightPoint)
        {
            targetPoint = bottomRightPoint;
        }
        else if (targetPoint == bottomRightPoint)
        {
            targetPoint = bottomLeftPoint;
        }
        else
        {
            targetPoint = topRightPoint;
            isMoving = false; // Закончили движение
        }
    }

    void ChangeImages()
    {
        StartCoroutine(FadeInSecond());
        StartCoroutine(FadeInFirst());
        if (isFadeInFaded)
        {
            NewImage();
            StartCoroutine(FadeOut());
        }
    }

    void NewImage()
    {
        if (ImageToFadeIn != null)
        {
            Destroy(ImageToFadeIn);
        }
        transform.position = topLeftPoint.position;

        isMoving = true;
        isSecond = true;
    }

    IEnumerator FadeInFirst()
    {
        float alpha;
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            alpha = fadeDuration / elapsedTime;
            if (ImageToFadeIn != null)
            {
                ImageToFadeIn.color = new Color(0, 0, 0, alpha);
            }
            yield return null;
        }
        isFadeInFaded = true;
    }

    IEnumerator FadeInSecond()
    {
        float alpha = 0;
        while (alpha < 1)
        {
            ImageToFadeOut.color = new Color(0, 0, 0, alpha);
            alpha += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        float alpha;
        isFadeOutFaded = false;
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            ImageToFadeOut.color = new Color(alpha, alpha, alpha, 255);
            yield return null;
        }
        isFadeOutFaded = true;
    }
}
