using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //дистанция от которой он начинает видеть игрока
    public float seeDistance = 5f;
    //дистанция до атаки
    public float attackDistance = 5f;
    //скорость енеми
    public float speed = 4;
    //игрок
    private Transform target;

    void Start()
    {
      //  target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackDistance)
            {
                //walk
                transform.right = target.transform.position - transform.position;
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            }
        }
        else
        {
            //idle
        }
    }
}
