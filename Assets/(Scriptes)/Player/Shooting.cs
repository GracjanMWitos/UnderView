using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour    
{
    public Transform gun;
    public Rigidbody2D bullet;
    public Rigidbody2D loudPoint;
    public AudioClip gunShot;
    public AudioSource Sound;
    bool shooted;

    void Start()
    {
        Sound = GetComponent<AudioSource>();
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        float input = Input.GetAxis("Vertical");
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            Sound.PlayOneShot(gunShot);
            Rigidbody2D bulletClone = Instantiate(bullet, gun.position, gun.rotation);
            //Rigidbody2D LoudPoint = Instantiate(loudPoint, gun.position, gun.rotation);
        }
        

    }
    
}
