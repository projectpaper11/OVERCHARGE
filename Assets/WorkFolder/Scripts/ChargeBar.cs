using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WorkFolder.Scripts
{
    public class ChargeBar : MonoBehaviour
    {
        public static ChargeBar instance;
        [SerializeField] private Slider slider;
        [SerializeField] private TextMeshProUGUI percentText;

        private void Awake() => instance = this;

        private void Start()
        {
            ChangeCharge(slider.value);
        }

        public void ChangeCharge(float value)
        {
            slider.DOValue(value, 0.1f);
        }
    }
}