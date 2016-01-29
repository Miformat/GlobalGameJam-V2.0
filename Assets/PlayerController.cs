using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 6.0F;
    public float runMultiplicator = 2.0F;
    public float walkSpeed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float zoomLevel = 2.0F;
    private Vector3 moveDirection = Vector3.zero;

    bool animationPlaying = false;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("shift");
            speed *= runMultiplicator;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= runMultiplicator;
        }
        

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (Input.GetMouseButtonDown(1) && !animationPlaying)
        {
            StartCoroutine("zoomAnimation");
            animationPlaying = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            GetComponentInChildren<Camera>().fieldOfView = 60;
        }

    }

    IEnumerator zoomAnimation()
    {
        float fieldOfView = GetComponentInChildren<Camera>().fieldOfView;

        for (float i= fieldOfView; i> fieldOfView / zoomLevel; i -= 1f)
        {
            yield return new WaitForSeconds(0.001f);
            GetComponentInChildren<Camera>().fieldOfView -= 1f;
        }
        animationPlaying = false;
    }
}
