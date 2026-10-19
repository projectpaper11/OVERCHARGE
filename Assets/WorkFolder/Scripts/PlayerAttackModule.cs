using System;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace WorkFolder.Scripts
{
    public class PlayerAttackModule : MonoBehaviour
    {
        [SerializeField] private float fireRate = 0.15f;
        [SerializeField] private Bullet bulletPrefab;
        [SerializeField] private MMF_Player feedback;
        private float _lastAttackTime;
        private void Update()
        {
            if (Mouse.current.leftButton.isPressed)
            {
                if (Time.time > _lastAttackTime)
                {
                    _lastAttackTime = Time.time + fireRate;
                    Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                    feedback.PlayFeedbacks();
                }
            }
        }
    }
}