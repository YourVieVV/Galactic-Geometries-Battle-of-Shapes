using UnityEngine;
using System.Collections;

public class aiEasy : MonoBehaviour {

	public float fpsTargetDistance;//расстояние до плеера
	public float enemyLookDistance;//дистанция на которой нас видит враг
	public float attackDistance;//дистанция атаки
	public float enemyMovementSpeed;//скорость противника
	public float damping;//перестаёт видеть
	public Transform fpsTarget;
	Rigidbody theRigidbody;
	Renderer myRender;
    public GameObject currentProjecktile;

    public GameObject Player;
    Vector3 AIM;
    Vector3 player_pos;

    private float shootDelayCouter;
    public float shootDelay;

    // Use this for initialization
    void Start () {
		myRender = GetComponent<Renderer>();
        theRigidbody = GetComponent<Rigidbody>();
        shootDelayCouter = 1;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        fpsTargetDistance = Vector2.Distance(fpsTarget.position,transform.position);
		if (fpsTargetDistance < enemyLookDistance){
			myRender.material.color=Color.yellow;
            Run();
		}
		if (fpsTargetDistance < attackDistance || fpsTargetDistance == attackDistance) {
			myRender.material.color = Color.red;
            enemyMovementSpeed = 0;
            transform.Translate(new Vector2(0,0));
            AttackPlease ();
        } else {
			myRender.material.color = Color.blue;
		}
	}
	
	void Run()
    {
        transform.right = fpsTarget.transform.position - transform.position;
        transform.Translate(new Vector2(enemyMovementSpeed * Time.deltaTime, enemyMovementSpeed * Time.deltaTime));

    }

    void AttackPlease()
    {
        if (fpsTargetDistance < attackDistance || fpsTargetDistance == attackDistance)
        {
            Instantiate(currentProjecktile, transform.position, transform.rotation);
            shootDelayCouter = shootDelay;

        }

        shootDelayCouter -= Time.deltaTime;
    }
}

