using UnityEngine;

public class MobsMove : MonoBehaviour
{
    private Mob mob;

    // Межі карти
    public float minX = -2f;
    public float maxX = 2f;
    public float minY = -2f;
    public float maxY = 2f;

    private Vector2 targetPoint;

    void Start()
    {
        mob = GetComponent<Mob>();
        PickNewTarget();
    }

    void Update()
    {
        if (mob == null) return;

        transform.position = Vector2.MoveTowards(transform.position, targetPoint, mob.speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, targetPoint) < 0.1f)
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
