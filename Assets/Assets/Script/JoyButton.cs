using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyButton : MonoBehaviour
{
    protected Joystick joystick;
     public Animator myAnim;
     public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed);
        myAnim.SetFloat("moveX", rigidbody.velocity.x);
        myAnim.SetFloat("moveY", rigidbody.velocity.y);

        if(joystick.Horizontal == 1 || joystick.Horizontal == -1 || joystick.Vertical == 1 || joystick.Vertical == -1)
        {
            myAnim.SetFloat("lastMoveX", joystick.Horizontal);
            myAnim.SetFloat("lastMoveY", joystick.Vertical);
        }
    }
}
