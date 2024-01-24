using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopadanieCam : MonoBehaviour {

    Animation anim;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.tag = "PulaEnemy";

        if (other.tag == "Player")
        {
            anim = GetComponent<Animation>();
            anim.Play("Anim_Camera_popadanie");

        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
