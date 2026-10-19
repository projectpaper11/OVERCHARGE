using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace WorkFolder.Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject enemy;
        [SerializeField] private Enemy1 enemy1;
        [SerializeField] private Transform player;
        [SerializeField] private float targetTime = 2f;

        [SerializeField] private Transform[] spawnPositions;
        private float _timer;

        private void Awake()
        {
            _timer = targetTime;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                int rando = Random.Range(0, 2);
                if (rando == 0)
                {
                    Instantiate(enemy, spawnPositions[Random.Range(0, spawnPositions.Length)].position, Quaternion.identity);
                }
                else if (rando == 1)
                {
                   
                    Enemy1 enemy =  Instantiate(enemy1, spawnPositions[Random.Range(0, spawnPositions.Length)].position, Quaternion.identity);
                    enemy.Init(player);
                }
                _timer =  targetTime;
            }
        }
    }
}