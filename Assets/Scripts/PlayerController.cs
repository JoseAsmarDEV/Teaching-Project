using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 rotation = new Vector2(-3,0); //Camera rotation variable
    public Camera cam; //Public variable for the camera
    public float speed = 3; //Mouse sensitivity speed
    public GameObject launcher; //Public variable for object with LaunchProjectile script

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X"); //Gets the values for the rotation y
        rotation.x += -Input.GetAxis("Mouse Y"); //Gets the value for the rotation x
        cam.transform.eulerAngles = (Vector2)rotation * speed; //Applies the rotation values to the camera transform

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        launcher.GetComponent<LaunchProjectile>().LaunchProj();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
