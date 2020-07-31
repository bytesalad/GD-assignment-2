using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    [SerializeField] private int GemsNo;
    pickup_addtoplayerscript Pickup;

    private void Start()
    {
        Pickup = GetComponent<pickup_addtoplayerscript>();
    }

    private void Update()
    {
        GemsNo = Pickup.getCollectableCount();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ExitTile")
        {
            if(GemsNo >= 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if (collision.tag == "FinalExitTile")
        {
            if (GemsNo >= 3)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
