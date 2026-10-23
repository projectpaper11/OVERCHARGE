using UnityEngine;
using WorkFolder.Scripts;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private UIScore score2;

    private void OnEnable()
    {
        score2.UpdateScore(ChargeBar.instance.Score);
        score2.UpdateScoreText();
    }
}
