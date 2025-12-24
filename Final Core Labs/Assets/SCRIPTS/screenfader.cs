using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class screenfader : MonoBehaviour
{
    public static screenfader Instance;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] float fadeDuration = 0.5f;
    private Coroutine fadeRoutine;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    IEnumerator Fade(float target)
    {
        float start = canvasGroup.alpha;
        float t = 0f;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, target, t / fadeDuration);
            yield return null; // EXACTLY one frame
        }

        canvasGroup.alpha = target;
        fadeRoutine = null;
    }

    /*    async Task Fade(float targetTransparency)
        {
            float start = canvasGroup.alpha, t = 0;
            while (t < fadeDuration)
            {
                t += Time.deltaTime;
                canvasGroup.alpha = Mathf.Lerp(targetTransparency, start, t / fadeDuration);
                await Task.Yield();
            }
            canvasGroup.alpha = targetTransparency;
        }*/
    public void FadeOut()
    {
        StartFade(1f);
    }

    public void FadeIn()
    {
        StartFade(0f);
    }

    void StartFade(float target)
    {
        if (fadeRoutine != null)
            StopCoroutine(fadeRoutine);

        fadeRoutine = StartCoroutine(Fade(target));
    }
}
