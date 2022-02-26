using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    private Rigidbody2D myBody;
    private Animator anim;
    
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        PlayerWalk();
    }

    void PlayerWalk()
    {
        float h = Input.GetAxisRaw("Horizontal");
        
        if (h > 0){
            myBody.velocity = new Vector2(speed, myBody.velocity.y);
            //Vector2 is X and Y
            //Vector3 is X, Y and Z
            ChanDirection(1);
            //Direction player to right side
        } else if (h < 0){
            myBody.velocity = new Vector2(-speed, myBody.velocity.y);
            ChanDirection(-1);
            //Direction player to left side
        } else {
            myBody.velocity = new Vector2(0f, myBody.velocity.y);
        }
        anim.SetInteger("Speed", Mathf.Abs((int)myBody.velocity.x));
        //Speed is the parameter from animator tab
        //We need to casting the float variable to an integer value
    }
    
    void ChanDirection(int direction)
    {
        Vector3 tempScale = transform.localScale;
        //We are storing this value in our temporary variable
        tempScale.x = direction;
        //We change our temporary variable
        transform.localScale = tempScale;
        //We reasign temporary variable back
    }
}
