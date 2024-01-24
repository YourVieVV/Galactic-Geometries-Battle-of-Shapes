using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBackgroundMovie : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Joystick joystick;
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
                if (joystick.Vertical > 0)
                {
                    speed = -0.4f;
                }

                if (joystick.Vertical < 0)
                {
                    speed = -0.2f;
                }
                break;
            case "SmallStar":
                if (joystick.Vertical > 0)
                {
                    speed = -0.6f;
                }

                if (joystick.Vertical < 0)
                {
                    speed = -0.4f;
                }
                break;
            case "BigStar":
                if (joystick.Vertical > 0)
                {
                    speed = -0.8f;
                }

                if (joystick.Vertical < 0)
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
