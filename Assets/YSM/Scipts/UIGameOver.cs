using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private UIScore score;
    [SerializeField] private UIScore score2;

    private void OnEnable()
    {
        score2.UpdateScore(score._score);
        score2.UpdateScoreText();
    }
}
