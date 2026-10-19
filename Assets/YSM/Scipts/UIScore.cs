using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    private int _score = 0;
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
        _scoreText.text = _score.ToString();
    }
}
