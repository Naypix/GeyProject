using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 10; // Величина шкоди, яку завдає моб
    public float attackCooldown = 1f; // Час між атаками
    public float lastAttackTime = 0f; // Час останньої атаки

    public float attackDistance = 10f;

    private Mob mob;
    private Transform player;

    private Health playerHealth; // Посилання на компонент Health гравця

    void Start()
    {
        mob = GetComponent<Mob>();
        player = GameObject.FindGameObjectWithTag("Player")?.transform; // Спочатку знайди гравця

        if (player == null)
        {
            Debug.LogError("Player not found!");
            return;
        }

        playerHealth = player.GetComponent<Health>(); // Потім отримаємо компонент

    }




    void Update()
    {


        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackDistance && Time.time - lastAttackTime >= attackCooldown)
        {
            AttackPlayer();
        }
    }

    void AttackPlayer()
    {
        playerHealth.TakeDamage(damage);
        lastAttackTime = Time.time;
    }


}
   

