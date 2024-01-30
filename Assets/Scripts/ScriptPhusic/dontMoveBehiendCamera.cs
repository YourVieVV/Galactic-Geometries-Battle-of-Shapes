using UnityEngine;

public class dontMoveBehiendCamera : MonoBehaviour
{

    Vector3 min, max;

    void Start()
    {
        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
    }


    void Update()
    {
        //  if (transform.position.x > max.x || transform.position.x < min.x) {
        //     Destroy (this.gameObject);
        // }

        // if (transform.position.y > max.y  || transform.position.y < min.y) {
        //     Destroy (this.gameObject);
        // }
        if (this.transform.position.x > max.x)
            this.transform.position = new Vector3(max.x, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.x < min.x)
            this.transform.position = new Vector3(min.x, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.y > max.y)
            this.transform.position = new Vector3(this.transform.position.x, max.y, this.transform.position.z);

        if (this.transform.position.y < min.y)
            this.transform.position = new Vector3(this.transform.position.x, min.y, this.transform.position.z);
    }

    // void AntiExitPalyer()
    // {

    //     // вершины "среза" пирамиды видимости камеры на необходимом расстоянии от камеры
    //     leftBot  = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
    //     rightTop = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

    //     // границы в плоскости XZ, т.к. камера стоит выше остальных объектов
    //     float x_left  = leftBot.x;
    //     float x_right = rightTop.x;
    //     float z_top   = rightTop.z;
    //     float z_bot   = leftBot.z;

    //     // ограничиваем объект в плоскости XZ
    //     clampedPos = transform.position;
    //     clampedPos.x = Mathf.Clamp(clampedPos.x, x_left, x_right);
    //     clampedPos.z = Mathf.Clamp(clampedPos.z, z_bot, z_top);
    //     transform.position = clampedPos;
    // }
}
