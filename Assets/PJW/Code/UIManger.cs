using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIManger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] maintitle;

    private Sequence textAnim;

    private void Awake()
    {
        textAnim = DOTween.Sequence();
        MakeSequence();
    }

    private void Start()
    {
        textAnim.Play();
    }

    private void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void MakeSequence()
    {
        textAnim
        .Join(maintitle[0].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[0].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[1].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[1].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[2].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[2].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[3].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[3].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[4].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[4].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[5].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[5].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[6].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[6].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[7].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[7].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint))
        .Join(maintitle[8].rectTransform.DOScale(1.15f, 0.18f).SetEase(Ease.OutQuint)).Join(maintitle[8].rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutQuint)).SetLoops(-1,LoopType.Restart).Pause();
    }

}
