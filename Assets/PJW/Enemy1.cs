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
        transform.DOMove(targetTrm.position, 5f).SetEase(Ease.InOutBounce);
    }

    private void OnDrawGizmos()
    {
    }
}
