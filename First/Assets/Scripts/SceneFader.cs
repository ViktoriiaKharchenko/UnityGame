using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public Image img;
    public AnimationCurve curve;
    public float fadeTime=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
    }
    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOut(scene));
    }
    IEnumerator FadeOut(string scene)
    {
        float t = 0f;
        while (t < fadeTime)
        {
            t += Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(255f, 255f, 255f, a);
            yield return 0;
        }
        SceneManager.LoadScene(scene);
    }
    IEnumerator FadeIn()
    {
        float t = 1f;
        while (t > 0f)
        {
            t -= Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(255f, 255f, 255f, a);
            yield return 0;
        }
    }
}
