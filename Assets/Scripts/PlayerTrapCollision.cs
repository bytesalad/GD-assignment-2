using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrapCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            Debug.Log("Trap Activated!");
            gameObject.GetComponent<ActivateTrapRenderer>().Activate();
        }
    }
}
