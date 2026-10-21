using System;
using System.Collections;
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
        [SerializeField] private MMF_Player strikeFeedback;
        [SerializeField] private MMF_Player strikeFinishFeedback;
        [SerializeField] private PlayerMovement moveCompo;
        [SerializeField] private ChargeSystem system;
        private float _lastAttackTime;
        private float _maxRange = 10f;



        private bool _charging;
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

            if (Mouse.current.rightButton.isPressed)
            {
                _charging = true;
                system.Charge(5 * Time.deltaTime);
            }
            else if(_charging)
            {
                _charging = false;
                system.Reset();
                Strike();
            }
        }

        private void Strike()
        {
            moveCompo.Stop();
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            Vector3 hit = ray.GetPoint(15);
            hit.y = transform.position.y;
            Vector3 dir = (hit - transform.position).normalized;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 10f * Time.deltaTime);
            float distance = (hit - transform.position).magnitude;
            
            if (distance > _maxRange)
            {
                distance = _maxRange;
            }
            
            moveCompo.AddForce(dir * distance, ForceMode.Impulse);
            strikeFeedback.PlayFeedbacks();
            StartCoroutine(ReturnMoveRoutine());
        }

        private IEnumerator ReturnMoveRoutine()
        {
            system.SetMuteki(true);
            yield return new WaitForSeconds(0.5f);
            Collider[] cols = Physics.OverlapSphere(transform.position, 15f, LayerMask.GetMask("Enemy"));
            foreach (Collider col in cols)
            {
                Debug.Log(col.name);
                if (col.TryGetComponent(out HealthSystem charge) && charge != null)
                {
                    charge.TakeDamage(999999);
                } 
            }
            moveCompo.ResumeMove();
            strikeFinishFeedback.PlayFeedbacks();
            system.SetMuteki(false);
        }
    }
}