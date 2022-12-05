using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Platform Script (For moving platform)
public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) //if Player stand on platform, bind player idling positon the same as platform 
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player") //lift the position binding when player is not on platform
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
