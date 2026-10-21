using System;
using DG.Tweening;
using System.Net.NetworkInformation;
using UnityEngine;

public class Enemy1 : MonoBehaviour
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
        transform.position += dir * (5f * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
    }

    private void OnDestroy()
    {
        this.DOKill();
    }
}
