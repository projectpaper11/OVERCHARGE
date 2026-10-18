using System;
using UnityEngine;

namespace WorkFolder.Scripts
{
    public class HealthSystem : MonoBehaviour,IDamageable
    {
        [SerializeField] private float maxHealth;
        private float _currentHealth;

        private void Awake()
        {
            _currentHealth = maxHealth;
        }

        public void TakeDamage(float damage)
        {
            _currentHealth -= damage;

            if (_currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}