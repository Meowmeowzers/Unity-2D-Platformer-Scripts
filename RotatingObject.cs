using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private int angle = 360;

    void Update()
    {
        transform.Rotate( 0, 0, angle * Time.deltaTime * speed);
    }
}
