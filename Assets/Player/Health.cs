using JetBrains.Annotations;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth;
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    void Update()
    {
        
    }
    void Die()
    {
        Debug.Log("{gameObject.name} помер");
        Destroy(gameObject);
    }
    public void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            if (CurrentHealth <= 0)
                Die();
        }
}

