using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class PlayerFlashlight : MonoBehaviour
{
    [SerializeField] private TilemapRenderer trapRenderer;
    [SerializeField] private Material normalTrapMat;
    [SerializeField] private Material redTrapMat;
    [SerializeField] private float timeActive;
    [SerializeField] private float timeRecharge;
    [SerializeField] private KeyCode flashlightKey;
    [SerializeField] private Image flashLightImage;
    [SerializeField] private Sprite off;
    [SerializeField] private Sprite on;
    private float time = 0;
    private bool active = false;

    public float getDuration()
    {
        if (!active)
        {
            return time / timeRecharge;
        }
        else
        {
            return 0f;
        }
    }

    private void Start()
    {
        time = timeRecharge;
        flashLightImage.sprite = off;
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
                    trapRenderer.enabled = true;
                    trapRenderer.material = redTrapMat;
                    flashLightImage.sprite = on;
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
                time = 0;
                //deactivate renderers again.
                trapRenderer.material = normalTrapMat;
                trapRenderer.enabled = false;
                flashLightImage.sprite = off;
            }
        }
    }
}
