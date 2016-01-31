using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [HideInInspector]public float speed = 6.0F;
    //public float runMultiplicator = 2.0F;
    public float walkSpeed = 6.0F;
    public float jumpSpeed = 8.00F;
    public float gravity = 20.0F;
    float originGravity;
    public float zoomLevel = 2.0F;
    private Vector3 moveDirection = Vector3.zero;
	Vector3 direction;
    
    [HideInInspector]public Animator animator;

    public float flyDuration = 3f;
    public float flyinHeight = 20f;
    public float flyinSpeed = 12f;
    float flyBegining = 0;
    public bool fly = false;

    CharacterController controller;

    GameObject model;

    TrackManager tM;

    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        model = animator.gameObject;

        gravity /= Time.deltaTime;

        originGravity = gravity;

        speed = walkSpeed;

        tM = GetComponent<TrackManager>();
    }

    void Update()
    {
        if (gravity == 0 && Time.time - flyBegining > flyDuration)
        {
            fly = false;
            tM.isFlying = false;
            gravity = originGravity;
            speed = walkSpeed;
        }

        controller = GetComponent<CharacterController>();
        
		direction = Vector3.zero;

        if (Input.GetMouseButton(0))
        {
            direction.z = 1;
            if (fly)
            {
                model.transform.localEulerAngles = new Vector3(45,0,0);
            }
            else
            {
                model.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        } //clic gauche
        else
        if (Input.GetMouseButton(1))
        {
            direction.z = -1;
            if (fly)
            {
                model.transform.localEulerAngles = new Vector3(-45, 0, 0);
            }
            else
            {
                model.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        }
        
        if (controller.isGrounded)
        {
            model.transform.localEulerAngles = new Vector3(0, 0, 0);


            /*if (Input.GetMouseButtonDown(2))
            {
                direction.y = jumpSpeed;
                animator.SetTrigger("jump");
            } //clic middle*/

            animator.SetTrigger("touchGround");

            if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
            {
                animator.SetBool("run", true);
            }
            else
            {
                animator.SetBool("run", false);
            }
            
        }
        else
        {
            animator.SetTrigger("fall");
            animator.SetBool("run", false);
        }

        moveDirection = direction;

        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        moveDirection.y -= gravity * Time.deltaTime;

        if(gravity == 0)
        {
            moveDirection.y = 0;
        }
        
        controller.Move(moveDirection * Time.deltaTime);
    }

    public void Fly()
    {
        float currentY = transform.position.y;

        fly = true;
        tM.isFlying = true;
        animator.SetTrigger("jump");

        StartCoroutine(BeginFly(currentY));
    }

    IEnumerator BeginFly(float beginY)
    {
        gravity = -gravity;

        //Debug.Log("begin flying");

        while (transform.position.y - beginY < flyinHeight)
        {
            yield return new WaitForSeconds(0.01f);
        }

        flyBegining = Time.time;
        gravity = 0;
        speed = flyinSpeed;

        //Debug.Log("stop flying");
    }
}
