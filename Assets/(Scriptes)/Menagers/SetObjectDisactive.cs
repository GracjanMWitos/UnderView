using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectDisactive : MonoBehaviour
{
    public GameObject objectToDisactive;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            objectToDisactive.SetActive(false);
        }
    }
}
