using UnityEngine;
[RequireComponent(typeof(Health))]
public class Mob : MonoBehaviour
{
    public string mobName = "Mobs1";
    public float speed = 1f;
    public Health health;
        void Start()
    {
        health = GetComponent<Health>();
        Debug.Log($"{mobName} створений. Здоров'я: {health.health}");

    }
}
