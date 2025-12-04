using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gargoyle : MonoBehaviour
{
    public Transform player;

    Quaternion m_Rotation = Quaternion.identity;

    public float turnSpeed = 0.2f;
    private void Update()
    {
        Vector3 direction = player.position - transform.position + Vector3.up;
        direction = new Vector3(direction.x, 0, direction.z);
        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, direction, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
        transform.rotation = m_Rotation;
    }
}
