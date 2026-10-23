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
        // 부모 OnEnable에서 Awake보다 먼저 불릴 수 있다
        if (_scoreText == null)
            _scoreText = GetComponent<TextMeshProUGUI>();
        _scoreText.text = "Score: " + _score.ToString();
    }
}
