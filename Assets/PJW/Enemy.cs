using DG.Tweening;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speedCH = 200;
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
        transform.parent.position = new Vector3(Random.Range(-10, 10),0 , Random.Range(-10, 10));
        transform.parent.DORotate(transform.eulerAngles + new Vector3(Random.Range(-1, 1) * speedPr, Random.Range(-1, 1) * speedPr, 0), 3, RotateMode.FastBeyond360).SetLoops(-1, loopType: LoopType.Incremental).SetEase(ease: Ease.Linear);
    }
}
