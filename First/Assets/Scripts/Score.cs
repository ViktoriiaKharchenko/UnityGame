using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    private float score = 0f;
    
    private void Start()
    {
        score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = (Mathf.Round(score * 100) / 100f).ToString("F2");
    }
}
