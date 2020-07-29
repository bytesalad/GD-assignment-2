using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private string horizAxis;
    [SerializeField] private string vertAxis;

    private void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis(horizAxis), Input.GetAxis(vertAxis)) * movementSpeed;
    }
}
