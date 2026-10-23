using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIScore : MonoBehaviour
{
    public int _score = 0;
    private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore(int score)
    {
        _score += score;
    }

    public void UpdateScoreText()
    {
        _scoreText.text = "Score: " + _score.ToString();
    }
}
