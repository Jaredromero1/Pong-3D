using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(up)){
            transform.Translate(0, speed, 0);
        }

        if(Input.GetKey(down)){
            transform.Translate(0, -speed, 0);
        }
    }
}
