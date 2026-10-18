using System;
using System.Collections;
using UnityEngine;

namespace WorkFolder.Scripts
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        private Rigidbody _rigid;
        
        
        private void Awake()
        {
            _rigid = GetComponent<Rigidbody>();
            _rigid.linearVelocity = transform.forward * speed;
            StartCoroutine(DestroyRoutine());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IDamageable damageable))
            {
                damageable.TakeDamage(1);
            }
        }

        private IEnumerator DestroyRoutine()
        {
            yield return new WaitForSeconds(10f);
            Destroy(gameObject);
        }
    }
}