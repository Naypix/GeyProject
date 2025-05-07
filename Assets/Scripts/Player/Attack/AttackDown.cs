using Unity.VisualScripting;
using UnityEngine;

public class AttackDown : MonoBehaviour
{
  
    private Animator animator;
    public int hit = 20;
      void Start()
    {
        animator = GetComponentInParent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision){
        
       
        //Атака прямо
        if(animator.GetInteger("Right") == 0 && animator.GetInteger("Left") == 0){
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
