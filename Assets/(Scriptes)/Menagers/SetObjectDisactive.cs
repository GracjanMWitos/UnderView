using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectDisactive : MonoBehaviour
{
    public GameObject objectToDisactive;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            objectToDisactive.SetActive(false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            objectToDisactive.SetActive(true);
        }
    }
}
