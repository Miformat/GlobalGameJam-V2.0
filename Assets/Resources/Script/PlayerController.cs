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
		if (Input.GetMouseButton(0)){direction.z = 1;} //clic gauche
		if (Input.GetMouseButton(1)){direction.z = -1;} //clic droit
		if (Input.GetMouseButtonDown(2)){direction.y = jumpSpeed;} //clic middle
        if (controller.isGrounded)
        {
            moveDirection = direction;
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
