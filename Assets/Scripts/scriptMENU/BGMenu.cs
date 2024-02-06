using UnityEngine;

public class BGMenu : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Transform backgroundTransform;
    private float backgroundSize;
    private float backgroundPosition;

    private void Start()
    {
        backgroundTransform = GetComponent<Transform>();
        backgroundSize = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        backgroundPosition += speed * Time.deltaTime;
        backgroundPosition = Mathf.Repeat(backgroundPosition, backgroundSize);
        backgroundTransform.position = new Vector3(gameObject.transform.position.x, backgroundPosition, gameObject.transform.position.z);
    }
}
