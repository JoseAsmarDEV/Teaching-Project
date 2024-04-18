using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugExampleScript : MonoBehaviour
{
    public float variable1 = 1.1f;
    private int variable2 = 1;
    public bool variable3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Called");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Called");
    }

    void MyMethod()
    {
        Debug.Log("MyMethod called");
    }

    void MyMethod2(float var)
    {
        Debug.Log(var);
    }

    public float AddNumbers(float variable)
    {
        return variable + variable1;
    }

    void GetNumbers()
    {
        Debug.Log(AddNumbers(5.5f));
    }
}
