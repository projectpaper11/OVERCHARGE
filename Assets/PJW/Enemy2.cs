using System;
using DG.Tweening;
using System.Net.NetworkInformation;
using UnityEngine;
using WorkFolder.Scripts;

public class Enemy2 : MonoBehaviour
{
    private Transform targetTrm;
    
    public void Init(Transform TARGET)
    {
        targetTrm = TARGET;
    }
    private void Update()
    {
     if (targetTrm != null)
        {
            ChasePlayer();
        }
    }

    public void ChasePlayer()
    {
        Vector3 dir = targetTrm.position - transform.position;
        dir.Normalize();
        transform.position += dir * (4f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ChargeSystem charge))
        {
            Destroy(gameObject);
            charge.TakeDamage();
        }
    }

    private void OnDestroy()
    {
        this.DOKill();
    }
}
