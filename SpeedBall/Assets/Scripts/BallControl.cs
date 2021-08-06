using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//This class is created to control the ball in our game.
public class BallControl : MonoBehaviour
{
    Rigidbody rigidBall;
    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rigidBall=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //We got the value entered in the horizontal variable with the arrow keys.
        horizontal = Input.GetAxisRaw("Horizontal");
        rigidBall.velocity = new Vector3(horizontal*2f,rigidBall.velocity.y,rigidBall.velocity.z+0.03f);

        //If the user presses the space key, the character performs an upward movement.
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rigidBall.AddForce(Vector3.up*80f);
        }
    }

    
}
