using System;
using UnityEngine;

namespace WorkFolder.Scripts
{
    public class HealthSystem : MonoBehaviour,IDamageable
    {
        [SerializeField] private ParticleSystem deadEffect;
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
                ChargeBar.instance.ChangeScore(10);
                ParticleSystem ps = Instantiate(deadEffect, transform.position, transform.rotation);
                ps.Play();
                Destroy(gameObject);
            }
        }
    }
}