using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is created to control the camera.
public class CameraControl : MonoBehaviour
{
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        //I made the position of the camera follow the position of the ball with a certain distance.
        transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y+1f, ball.transform.position.z-1.2f);
    }
}
