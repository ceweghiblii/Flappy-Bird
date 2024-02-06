using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // references = biar script bisa ngirim command ke tiap2 komponen
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //atur biar burung terbang tiap di pencet spasi
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) 
        { 
            myRigidbody.velocity = Vector2.up * flapStrength; 
        }
        
   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
