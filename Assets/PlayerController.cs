using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 0.5f;
    public float speed = 1;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float jumpInp = Input.GetAxis("Jump");
        float crouch = Input.GetAxis("Crouch");

        int sprint = Input.GetAxis("Sprint") > 0.5f ? 1 : 0;
        
        // from zero to 2;
        float finalSpeedX = inputX * walkSpeed + inputX * speed * sprint;
        float finalSpeedY = inputY * walkSpeed + inputY * speed * sprint;
        
        /*anim.SetFloat("SpeedX",finalSpeedX);
        anim.SetFloat("SpeedY",finalSpeedY);
        anim.SetFloat("JumpSpeed",jumpInp);
        anim.SetFloat("Crouch",crouch);
        */
    }
}
