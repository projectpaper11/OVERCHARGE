using System;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speedCH = 1;
    [SerializeField] private float speedPr = 200;

    private void Start()
    {
        RoCh();
        PoPr();
    }

    public void RoCh()
    {
        transform.DORotate(transform.eulerAngles + new Vector3(Random.Range(-10, 10)*speedCH,  Random.Range(-10, 10)*speedCH, 0),3,RotateMode.FastBeyond360).SetLoops(-1,loopType:LoopType.Incremental).SetEase(ease:Ease.Linear);
    }

    public void PoPr()
    {

        MoveRando();
        transform.parent.DORotate(transform.eulerAngles + new Vector3(Random.Range(-1, 1) * speedPr, Random.Range(-1, 1) * speedPr, 0), 3, RotateMode.FastBeyond360).SetLoops(-1, loopType: LoopType.Incremental).SetEase(ease: Ease.Linear);
    }

    private void MoveRando()
    {
        transform.DOMove(transform.position +
                         new Vector3(Random.Range(-1f, 1f) * speedCH, 0, Random.Range(-1f, 1f) * speedCH),Random.Range(0.5f,1f)).OnComplete(() => MoveRando());
    }

    private void OnDestroy()
    {
        this.DOKill();
    }
}
