using UnityEngine;

namespace WorkFolder.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private GameObject player;

        public bool IsGameOver { get; private set; }

        private void Awake()
        {
            Instance = this;
            Time.timeScale = 1f;
            gameOverPanel.SetActive(false);
        }

        private void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }

            Time.timeScale = 1f;
        }

        public void GameOver()
        {
            if (IsGameOver) return;
            IsGameOver = true;
            player.SetActive(false);
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
