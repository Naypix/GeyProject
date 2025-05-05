using System;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public int Damage = 20;
    public Health playerHealth;
    void Start()
    {

    }
    void Update(){
    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag=="Player")
 playerHealth.TakeDamage(Damage);
    }
}


