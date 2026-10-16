using System;
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
        }
    }
}