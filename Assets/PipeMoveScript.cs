using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    //mengator move speed pipe (karena yg gerak pipa bukan burung)
    public float moveSpeed = 5;
    // pipa yang udah di spawn bakal di delete kalo udah diluar layar
    public float deadZone = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //*Tiime.deltatime agar kecepatan gerak pipa tidak bergantung pada fps tiap komputer yang beda
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
