using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector1 : MonoBehaviour
{
    private int nemiciCount = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nemici"))
        {
            Destroy(collision.gameObject);
            nemiciCount++;
            Debug.Log("nemiciCount: " + nemiciCount);
        }
    }

    public int GetCollectedEnemies()
    {
        return nemiciCount;
    }
}
