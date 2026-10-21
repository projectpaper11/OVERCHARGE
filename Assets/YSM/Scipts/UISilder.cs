using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISilder : MonoBehaviour
{
    private Slider slider;
    private TextMeshProUGUI text;

    private int sliderValue;

    private void Awake()
    {
        slider = GetComponentInChildren<Slider>();
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update()
    {
        
    }

    public void UpdateText()
    {
        sliderValue = Mathf.RoundToInt(slider.value * 100);
        text.text = sliderValue.ToString() + "%";
    }
}
