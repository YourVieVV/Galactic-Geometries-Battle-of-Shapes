using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBackgroundMovie : MonoBehaviour
{
    [SerializeField]
    float speed;
    public string backgroundName;
    private Transform backgroundTransform;
    private float backgroundSize;
    private float backgroundPosition;

    private void Start()
    {
        backgroundTransform = GetComponent<Transform>();
        backgroundSize = GetComponent<SpriteRenderer>().bounds.size.y * 2;
    }

    private void Update()
    {

        switch (backgroundName)
        {
            case "Nebula":
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    speed = -0.4f;
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    speed = -0.2f;
                }
                break;
            case "SmallStar":
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    speed = -0.6f;
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    speed = -0.4f;
                }
                break;
            case "BigStar":
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    speed = -0.8f;
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    speed = -0.6f;
                }
                break;
        }

        Move();
    }

    public void Move()
    {
        backgroundPosition += speed * Time.deltaTime;
        backgroundPosition = Mathf.Repeat(backgroundPosition, backgroundSize);
        backgroundTransform.position = new Vector3(1.8f, backgroundPosition, gameObject.transform.position.z);
    }
}
