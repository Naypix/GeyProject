using UnityEngine;

public class MobsMove : MonoBehaviour
{
    private Mob mob;

    // Межі карти
    public float minX = -20f;
    public float maxX = 20f;
    public float minY = -20f;
    public float maxY = 20f;

    private Vector2 targetPoint;

    public bool isMoving = true; 

    void Start()
    {
        mob = GetComponent<Mob>();
        PickNewTarget();
    }

    void Update()
    {
        if (mob == null|| !isMoving) return;// якщо моба немає або не рухається, виходимо з функції   

        transform.position = Vector2.MoveTowards(transform.position, targetPoint, mob.speed * Time.deltaTime);// рух до точки

        if (Vector2.Distance(transform.position, targetPoint) < 0.1f)// перехід до нової точки
        {
            PickNewTarget();
        }
    }

    void PickNewTarget()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        targetPoint = new Vector2(x, y);
    }
}
