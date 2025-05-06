
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth = 100;
    public int health;// Поточне здоров'я
    public bool IsDead = false;
    void Start()
    {
        health = MaxHealth;
    }
    public void TakeDamage(int amount)// Присвоєння урону об'єкту
    {
        health -= amount;
        if (health <= 0)
            Die();
    }
    void Die()
    {
        Debug.Log(gameObject.name + " помер");
        IsDead = true;
        Destroy(gameObject);

    }
}

