using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float playerMovementSpeed = 5f;
    [SerializeField] private float turnSpeed = 50f;
    private Rigidbody playerRb;
    private Animator animator;
    [SerializeField] private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
        //TurnPlayer();
    }
    void MovePlayer()
    {

        float verticalSpeed = Input.GetAxis("Vertical") * playerMovementSpeed;
        float horizontalSpeed = Input.GetAxis("Horizontal") * playerMovementSpeed;

        // Negative verticalSpeed for reverting the movement direction. 
        // Pressing up should reduce our position on X axis but key UP on "Horizontal" axis is 1.
        Vector3 movementVector = new Vector3(-verticalSpeed, 0f, horizontalSpeed); 
        movement = Vector3.left * verticalSpeed + Vector3.forward * horizontalSpeed;
        if (movementVector == Vector3.zero)
        {
            playerRb.velocity = Vector3.zero;
            animator.SetBool("Moving", false);
        } else
        {
            animator.SetBool("Moving", true);
            transform.Translate(movementVector * Time.deltaTime * playerMovementSpeed, Space.World);
            TurnPlayer(movementVector);
            
        }
    }

    void TurnPlayer(Vector3 movementVector)
    {
        Quaternion targetDirection = Quaternion.LookRotation(movementVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetDirection, Time.deltaTime * turnSpeed);
    }
}
