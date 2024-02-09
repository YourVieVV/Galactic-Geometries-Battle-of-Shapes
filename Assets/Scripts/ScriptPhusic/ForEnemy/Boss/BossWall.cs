using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWall : MonoBehaviour
{
    public float speed;
    public float rotationModifier;

    [SerializeField]
    private PlayerController playerControllerScript;

    private AudioSource AudioShutEn;

    private void Start()
    {
        AudioShutEn = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerControllerScript != null)
        {
            Vector3 vectorToTarget = playerControllerScript.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        }

    }
}
