using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 30f;
    private Rigidbody2D rb; //Створення змінної класу Фізики
    private Vector2 coordinate;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Присвоєння компоненту фізики
        
    }
    void Update()
    {
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
        }
        if (Input.GetKey(KeyCode.A))
        {
            coordinate.x--;
        }
        if (Input.GetKey(KeyCode.LeftShift))// Прискорення
        {
            moveSpeed = 35f;
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = coordinate.normalized * moveSpeed; //Нормалізація швидкості по діагоналі
    }
}
