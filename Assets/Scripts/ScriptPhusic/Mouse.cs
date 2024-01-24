using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    Vector3 AIM;
    Vector3 player_pos;

    void FixedUpdate()
    {
        AIM = Input.mousePosition;
        player_pos = Camera.main.WorldToScreenPoint(this.transform.position);

        AIM.x = AIM.x - player_pos.x;
        AIM.y = AIM.y - player_pos.y;

        float angle = Mathf.Atan2(AIM.x, AIM.y) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angle));
    }
}
