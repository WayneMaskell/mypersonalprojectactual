using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declare variables.
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float rotationInput;
    public float rotateSpeed = 1;
   
    public Vector3 moveDirection;
    public GameObject projectilePrefab;
    public Collider playerCollider;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");// get  horizontal input axis
        verticalInput = Input.GetAxis("Vertical");// get vertical input axis
        rotationInput = Input.GetAxis("Mouse X");

        MovePlayer();

       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);

        }

       



    }

    

    private void MovePlayer()//move player with both axis
    {
        moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
        transform.Rotate( 0, rotationInput, 0 * rotateSpeed);
    }
    
    

}
