using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkTrigger : MonoBehaviour
{
    MapController mc;
    public GameObject targetManp;

    void Start()
    {
        mc = FindObjectOfType<MapController>();    
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            mc.currentChunk = targetManp;
        }
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            if (mc.currentChunk == targetManp)
            {
                mc.currentChunk = null;
            }
        }
    }
}
