using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestrouerExplosition : MonoBehaviour {

    public float timeToDestroy;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, timeToDestroy);
	}
	
}
