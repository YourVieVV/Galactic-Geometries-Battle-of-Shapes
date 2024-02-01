using DigitalRuby.LightningBolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShut : MonoBehaviour
{
    [SerializeField]
    private LightningBoltScript _LightningBoltScript;
    [SerializeField]
    private GameObject GunPlayerOne;
    private RaycastHit2D hit;

    public LayerMask layerMask;

    private void Update()
    {
        _LightningBoltScript.StartObject.transform.position = new Vector3(GunPlayerOne.transform.position.x, GunPlayerOne.transform.position.y, 1f);
        hit = Physics2D.Raycast(transform.position, Vector2.up, 4f, layerMask);
        if (hit)
        {
            float distance = ((Vector2)hit.point - (Vector2)transform.position).magnitude;
            //distance
            _LightningBoltScript.EndObject.transform.position = new Vector3(GunPlayerOne.transform.position.x, distance, 1f);

        }
        else
        {
            // line.SetPosition(1, new Vector3(11f, 0, 0));
            _LightningBoltScript.EndObject.transform.position = new Vector3(GunPlayerOne.transform.position.x, GunPlayerOne.transform.position.y + 4f, 1f);
        }
    }
}
