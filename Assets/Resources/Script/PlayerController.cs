using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 6.0F;
    //public float runMultiplicator = 2.0F;
    public float walkSpeed = 6.0F;
    public float jumpSpeed = 8.00F;
    public float gravity = 20.0F;
    public float zoomLevel = 2.0F;
    private Vector3 moveDirection = Vector3.zero;
	Vector3 direction;

    bool isJumping = false;

    [HideInInspector]public Animator animator;

    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        
       /* if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("shift");
            speed *= runMultiplicator;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= runMultiplicator;
        }*/
        
		direction = Vector3.zero;
		
		if (Input.GetMouseButtonDown(2)){
            direction.y = jumpSpeed;
            animator.SetTrigger("jump");
        } //clic middle

        if (controller.isGrounded)
        {
            animator.SetTrigger("touchGround");

            if (Input.GetMouseButton(0))
            {
                direction.z = 1;
                animator.SetBool("run", true);
            } //clic gauche
            else
        if (Input.GetMouseButton(1))
            {
                direction.z = -1;
                animator.SetBool("run", true);
            } //clic droit
            else
            {
                animator.SetBool("run", false);
            }

            moveDirection = direction;
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }
        else
        {
            animator.SetTrigger("fall");
            animator.SetBool("run", false);
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
