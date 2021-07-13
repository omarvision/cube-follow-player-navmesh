using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayer : MonoBehaviour
{
    public float movespeed = 1.0f;
    public float turnspeed = 45.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            this.transform.Translate(new Vector3(0, 0, movespeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            this.transform.Translate(new Vector3(0, 0, -movespeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            this.transform.Rotate(new Vector3(0, turnspeed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            this.transform.Rotate(new Vector3(0, -turnspeed * Time.deltaTime, 0));
        }
    }
}