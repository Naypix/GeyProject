using UnityEngine;


public class AggressiveMobsMove : MonoBehaviour
{
    public float aggroDistance = 30f;

    private Mob mob;
    private Transform player;// Змінна в яку присвоюється система координат
    private MobsMove basicMoveScript;

    void Start()
    {
        mob = GetComponent<Mob>();// Присвоєння для змінної компонента з скрипту <Mob>
        player = GameObject.FindGameObjectWithTag("Player")?.transform;// пошук об'єкта з тегом "Player"
        if (player == null)
        {
            Debug.LogError("Player not found!");
            return;
        }
        basicMoveScript = GetComponent<MobsMove>();// Звичайний скрипт руху мобів
    }

    void Update()
    {
        mob.speed = 15f;
        if (mob == null) return; // Якщо не знайдено моба нічого не відбувається

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);//Обрахунок дистанції між мобом і гравцем

        if (distanceToPlayer <= aggroDistance)
        {
            if (distanceToPlayer <= 15f)
            {
                mob.speed = 0f;
            }
            else
            {
                basicMoveScript.isMoving = false;// перестаємо рухатися до як зазначено в MobsMove


                transform.position = Vector2.MoveTowards(transform.position, player.position, mob.speed * Time.deltaTime);// рухається до гравця
            }
        }

        else
        {
            basicMoveScript.isMoving = true;// відновлюємо рух як зазначено в MobsMove
        }


    }



}
