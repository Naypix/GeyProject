using JetBrains.Annotations;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth = 100;
    public int health;
    void Start()
    {
        health = MaxHealth;
    }

    void Update()
    {
        
    }
    void Die()
    {
        Debug.Log(gameObject.name + " помер");
        Destroy(gameObject);
    }
    public void TakeDamage(int amount)
        {
           health -=amount;
            if (health <= 0)
                Die();
        }
}

