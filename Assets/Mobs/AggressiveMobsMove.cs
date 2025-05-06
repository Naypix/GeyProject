using UnityEngine;


public class AggressiveMobsMove : MonoBehaviour 
{
    public float aggroDistance = 3f;

    private Mob mob;
    private Transform player;
    private MobsMove basicMoveScript;
    
    void Start() 
    {
        mob = GetComponent<Mob>();
        player = GameObject.FindGameObjectWithTag("Player")?.transform;// пошук об'єкта з тегом "Player"
        if (player == null) 
        {
            Debug.LogError("Player not found!");
            return;
        }
        basicMoveScript = GetComponent<MobsMove>();
    }

    void Update() 
    {
        if (mob == null) return; 

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= aggroDistance) 
        {
           basicMoveScript.isMoving = false;// перестаємо рухатися до як зазначено в MobsMove
            
        
            transform.position = Vector2.MoveTowards(transform.position, player.position, mob.speed * Time.deltaTime);// рухається до гравця
        } 
        else 
        {
        basicMoveScript.isMoving = true;// відновлюємо рух як зазначено в MobsMove
        }
    }



}
