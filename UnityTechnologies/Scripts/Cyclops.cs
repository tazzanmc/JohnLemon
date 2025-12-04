using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclops : MonoBehaviour
{
    public float turnSpeed = 30f;
    public float hoverSpeed = 40f;
    public float hoverDistance = 0.1f;

    private void Update()
    {
        transform.Rotate(new Vector3(0, turnSpeed, 0) * Time.deltaTime);
        transform.Translate(new Vector3(0, Mathf.Sin(hoverSpeed * Time.time) * hoverDistance, 0) * Time.deltaTime);
    }
}
