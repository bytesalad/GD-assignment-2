using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerFlashlight : MonoBehaviour
{
    [SerializeField] private TilemapRenderer trapRenderer;
    [SerializeField] private float timeActive;
    [SerializeField] private float timeRecharge;
    [SerializeField] private KeyCode flashlightKey;
    private float time = 0;
    private bool active = false;

    private void Start()
    {
        time = timeRecharge;
    }

    private void Update()
    {
        if (!active)
        {
            if (time < timeRecharge)
            {
                time += Time.deltaTime;
            }
            else
            {
                if (Input.GetKeyDown(flashlightKey))
                {
                    active = true;
                    time = 0;
                    //activate renderers.
                    Debug.Log("Flashlight activated!");
                }
            }
        }
        else
        {
            if (time < timeActive)
            {
                time += Time.deltaTime;
            }
            else
            {
                active = false;
                //deactivate renderers again.
            }
        }
    }
}
