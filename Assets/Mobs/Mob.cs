using UnityEngine;

[RequireComponent(typeof(Health))]
public class Mob : MonoBehaviour
{
    public string mobName = "Mobs1";
    //public int level = 1;
    public float speed = 1f;

   // [HideInInspector]
    public Health health;

    void Awake()
    {
        health = GetComponent<Health>();
    }

    void Start()
    {
        Debug.Log($"{mobName} створений. Здоров'я: {health.health}");
    }
}
