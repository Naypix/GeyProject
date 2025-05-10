using Unity.VisualScripting;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 30f;
    private Rigidbody2D rb; //Створення змінної класу Фізики
    private Vector2 coordinate;

    void Start()
    {

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();//Присвоєння компоненту фізики
        if (animator.runtimeAnimatorController == null)
        {
            Debug.LogError("Animator Controller не підключений!");
        }
    }
    void Update()
    {
        animator.SetInteger("Left", 0);
        animator.SetInteger("Right", 0);
        moveSpeed = 30f;
        coordinate = Vector2.zero;


        if (Input.GetKey(KeyCode.W))
        {
            coordinate.y++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            coordinate.y--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            coordinate.x++;
             animator.SetInteger("Right", 2);
        }
        if (Input.GetKey(KeyCode.A))
        {
            coordinate.x--;
            animator.SetInteger("Left", 1);
        }
        if (Input.GetKey(KeyCode.LeftShift))// Прискорення
        {
            moveSpeed = 45f;
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = coordinate.normalized * moveSpeed; //Нормалізація швидкості по діагоналі
    }
}
