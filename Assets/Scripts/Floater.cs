using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{

    public float speed = 3.0f;
    private float yMax;
    private float yMin;
    private int direction = 1;

    void Start()
    {
        yMax = transform.position.y + 2f;
        yMin = transform.position.y - 4f;
    }

    // Update is called once per frame
    void Update()
    {
        float yNew = transform.position.y;
        if (yNew >= yMax)
        {
            yNew = yMax;
            direction *= -1;
        } else if (yNew <= yMin)
        {
            yNew = yMin;
            direction *= -1;
        }
        float yOffset = direction * speed * Time.deltaTime;

        transform.position += new Vector3(0, yOffset, 0);

    }
}
