using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHelth;
    public float Damage;
    public float Heal;

    public float speed;
    public float speedEffect;

    public Slider Fill;
    public Slider FillEffect;

    void Start()
    {
        Fill.maxValue = MaxHealth;
        FillEffect.maxValue = MaxHealth;
    }

    void Update()
    {
        float target = Mathf.Lerp(Fill.value, CurrentHelth, speed * Time.deltaTime);
        float targetEffect = Mathf.Lerp(FillEffect.value, CurrentHelth, speedEffect * Time.deltaTime);
        Fill.value = target;
        FillEffect.value = targetEffect;
    }

    public void TakeDamge()
    {
        if (CurrentHelth > 0)
            CurrentHelth -= Damage;
    }

    public void Health()
    {
        if (CurrentHelth < MaxHealth)
            CurrentHelth += Heal;
    }
}