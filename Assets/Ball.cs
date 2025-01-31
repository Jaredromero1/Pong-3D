using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int speedX, speedY;
    float speed;
    public int leftScore = 0;
    public int rightScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5,10);
        speedX = Random.Range(0,2);

        if(speedX == 0){
            speedX = 1;
        } else {
            speedX = -1;
        }

        speedY = Random.Range(0,2);

        if(speedY == 0){
            speedY = 1;
        } else {
            speedY = -1;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * speedY, 0);
    }

    void Update()
    {

    }
}
