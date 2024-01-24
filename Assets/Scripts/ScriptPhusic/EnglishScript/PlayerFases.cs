using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFases : MonoBehaviour {
    //Это скрипт слежения за игроком(другой скрипт(посмотрю какой лучше и вставлю))

   public float rotSpeed = 90f;

    Transform player;


	
	
	// Update is called once per frame
	void Update () {
		if (player == null)
        {
            GameObject go = GameObject.Find("Player");
            if (go != null)
            {
                player = go.transform;
            }
        }

        if (player == null)
            return;
        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAnge = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAnge);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
    }
}
