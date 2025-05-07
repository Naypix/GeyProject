using Unity.VisualScripting;
using UnityEngine;

public class AttackLeft : MonoBehaviour
{
  
    private Animator animator;
    public int hit = 10;
      void Start()
    {
        animator = GetComponentInParent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision){
        
        //Атака ліворуч
        if(animator.GetInteger("Left") == 1){
        if (Input.GetMouseButtonDown(0))
        {
            Health mobHealth = collision.GetComponent<Health>();
            if (mobHealth != null)
            {
                mobHealth.TakeDamage(hit);
                Debug.Log("Атаковано: " + collision.name);
            }
        }
        }
    }
}
