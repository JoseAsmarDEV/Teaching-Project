using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
    public Transform launchPosition;

    public void LaunchProj()
    {
        GameObject ball = Instantiate(projectile, launchPosition.position, launchPosition.rotation);

        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
    }
}
