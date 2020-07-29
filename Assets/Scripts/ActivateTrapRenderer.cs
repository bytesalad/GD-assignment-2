using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ActivateTrapRenderer : MonoBehaviour
{
    [SerializeField] private TilemapRenderer trapRenderer;
    public void Activate()
    {
        trapRenderer.enabled = true;
    }
}
