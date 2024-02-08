using UnityEngine;

public class DodgePlayerBullet : MonoBehaviour
{
    private Vector2 _direction = Vector2.zero;
    private Vector2 currentPos = Vector2.zero;
    private float moveTarget;
    public bool isPosition = true;
    public bool isTriggerCollider = false;

    private void DodgeLogic()
    {
        if (isTriggerCollider)
        {
            if (isPosition)
            {
                _direction.x = Random.Range(-2, 2);
                if (_direction.x == 0)
                {
                    _direction.x = 1;
                }
                moveTarget = currentPos.x + _direction.x;
                if (moveTarget <= -2.5f || moveTarget >= 2.5f) moveTarget = 0;
                if (currentPos.x <= -2.5f)
                {
                    moveTarget = currentPos.x + 1.5f;
                }
                if (currentPos.x >= 2.5f)
                {
                    moveTarget = currentPos.x - 1.5f;
                }
            }

            if (currentPos.x != moveTarget)
            {
                isPosition = false;
                transform.position = Vector2.MoveTowards(currentPos, new Vector2(moveTarget, currentPos.y), 3f * Time.deltaTime);
            }
            else
            {
                isPosition = true;
                isTriggerCollider = false;
            }
        }
    }

    private void Update()
    {
        currentPos = transform.position;
        DodgeLogic();
    }
}

