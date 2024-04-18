using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<TargetScript>())
        {
            collision.gameObject.GetComponent<TargetScript>().Win();
        }
    }
}
