using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;


    public float moveSpeed;
    public float moveSpeed2;
    public float jumpForce;
    public float gravity;
    private float verticalVelocity;
    public Rigidbody body;

    public GameObject restart;
    public GameObject restartText;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    private void FixedUpdate()
    {
        Vector3 changeInVelocity = new Vector3();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeInVelocity.y = jumpForce;
        }

        body.velocity += changeInVelocity;

        Vector3 changeInRotation = new Vector3();

        changeInRotation.x = Input.GetAxis("Vertical") * moveSpeed2;

        changeInRotation.y = Input.GetAxis("Horizontal") * moveSpeed;

        transform.localEulerAngles += changeInRotation;

        /*
        if(controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
                }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveVector.y = verticalVelocity;
        moveVector.z = Input.GetAxis("Vertical") * moveSpeed2;
        controller.Move(moveVector * Time.deltaTime);

//transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed2*Input.GetAxis("Vertical")*Time.deltaTime);

        */
    }
   /* public void gameover()
    {
        Time.timeScale = 0;
        restart.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "branch")
        {
            Time.timeScale = 0;
            restart.gameObject.SetActive(true);
            restartText.gameObject.SetActive(true);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Time.timeScale = 0;
            restart.gameObject.SetActive(true);
            restartText.gameObject.SetActive(true);
        }
    }

}
