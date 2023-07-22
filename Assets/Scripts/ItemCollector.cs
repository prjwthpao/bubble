using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int amiciCount = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("amici"))
        {
            Destroy(collision.gameObject);
            amiciCount++;
            Debug.Log("amiciCount: " + amiciCount);
        }
    }

    public int GetCollectedFriends()
    {
        return amiciCount;
    }

}
