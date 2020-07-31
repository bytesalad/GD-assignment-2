using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;
    public LayerMask whatStopsMovement;
    public AudioSource footstepsSFX;

    private float movementInputDirection;
    private bool isFacingRight = true;

    void Start()
    {
        //movepoint not parented to player so they dont move together
        movePoint.parent = null;
    }
    
    void Update()
    {

        movementInputDirection = Input.GetAxisRaw("Horizontal");
        if (isFacingRight && movementInputDirection < 0)
        {
            Flip();
        }
        else if (!isFacingRight && movementInputDirection > 0)
        {
            Flip();
        }

        //move the player towards the movePoint
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        //move movepoint based on inputs
        if(Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1) //if player inputs
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, whatStopsMovement)) //if there is NOT a collider left or right of the player in whatStopsMoving layer
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f); // move move point 
                    footstepsSFX.Play();
                }
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)//if player inputs
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), 0.2f, whatStopsMovement))//if there is NOT a collider above of below of the player in whatStopsMoving layer
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);// move move point
                    footstepsSFX.Play();
                }
            }
        }
    }

    private void Flip()
    {
        //facingDirection *= -1;
        isFacingRight = !isFacingRight;
        transform.Rotate(0.0f, 180.0f, 0.0f);
    }
}
