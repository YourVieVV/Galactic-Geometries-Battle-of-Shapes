using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    //public GameObject Player;
    //private Vector3 offset;



    //void Start () {
    //    offset = transform.position - Player.transform.position;
    //	}


    //void LateUpdate () {
    //   transform.position = Player.transform.position + offset;
    //}

     public BoxCollider2D cameraBounds;
     public bool iffollowing;
      private Transform player;
      private Vector2 min;
      private Vector2 max;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }

    private void Update()
    {
        min = cameraBounds.bounds.min;
        max = cameraBounds.bounds.max;
        var x = transform.position.x;
        var y = transform.position.y;
        if (iffollowing)
        {
            if (player.position.x > x || player.position.x < x)
            {
                x = player.position.x;
            }
            if (player.position.y > y || player.position.y < y)
            {
                y = player.position.y;
            }
        }
        var cameraHalfWidth = GetComponent<Camera>().orthographicSize * (Screen.width / Screen.height) ;
        var cameraHalfHeight = GetComponent<Camera>().orthographicSize * (Screen.width / Screen.height);
        x = Mathf.Clamp(x, min.x + cameraHalfHeight, max.x - cameraHalfWidth);
       y = Mathf.Clamp(y, min.y + cameraHalfWidth, max.y - cameraHalfWidth);
        transform.position = new Vector3(x, y, transform.position.z);





    }




}
