using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed;
    public float divide = 1;
    float angle;

    // Update is called once per frame
    void Update()
    {
        angle += speed;
        transform.Rotate(Mathf.Sin(angle)/ divide, Mathf.Cos(angle)/ divide, Mathf.Cos(angle/2)/divide);
    }
}
