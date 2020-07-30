using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class pickup_addtoplayerscript : MonoBehaviour
{
    private int collectablecount; //store number of diamonds collected
    public Text collectabletext;//UI disp number of collected items

    public int getCollectableCount()
    {
        return collectablecount;
    }

    //initialization of variable
    void Start()
    {
        collectablecount = 0;
        SetUIText();
    }

    //makes game object dissapear from scene
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Diamond"))
        {
            other.gameObject.SetActive(false);
            collectablecount = collectablecount + 1;
            SetUIText();
        } 
    }

    void SetUIText()
    {
        //TODO: Uncomment to update UI.
        //collectabletext.text = "diamonds collected: " + collectablecount.ToString();
    }
}
