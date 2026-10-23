using UnityEngine;

namespace WorkFolder.Scripts
{
    public class ChargeSystem : MonoBehaviour
    {
        public float currentCharge = 0;
        private bool muteki = false;
        public void TakeDamage()
        {
            if (muteki) return;
            currentCharge += 25;
            ChargeBar.instance.ChangeCharge((int)currentCharge);
        }

        public void Charge(float value)
        {
            currentCharge = Mathf.Min(99f, currentCharge + value);
            ChargeBar.instance.ChangeCharge((int)currentCharge);
        }

        public void Reset()
        {
            currentCharge = 0;
            ChargeBar.instance.ChangeCharge((int)currentCharge);
        }
        
        public void SetMuteki(bool value) => muteki = value;
    }
}