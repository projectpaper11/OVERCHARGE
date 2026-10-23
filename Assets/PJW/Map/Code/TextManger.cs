using DG.Tweening;
using TMPro;
using UnityEngine;

public class TextManger : MonoBehaviour
{
    public static TextManger instance;

    private Sequence textmoveSQ;

    [SerializeField] private TextMeshPro text;

    private int stageNum = 1;

    private void Awake()
    {
        text.GetComponent<TextMeshPro>().sortingOrder = 10;
        instance = this;
    }

    private void Start()
    {
        ShowText();
    }

    public void ShowText()
    {
        text.text = $"Stage {stageNum}";
        textmoveSQ.Restart();
        stageNum++;
    }

    public void MakeTextMoveSQ()
    {
        textmoveSQ.Append(text.transform.DOMoveX(text.transform.position.x + 1000, 1f))
            .Append(text.transform.DOMoveX(text.transform.position.x - 1000, 0f)).Pause();
    }
}
