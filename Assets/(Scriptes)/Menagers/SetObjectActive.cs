using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectActive : MonoBehaviour
{
    public GameObject objectToActive;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objectToActive.SetActive(true);
        }
    }
}
