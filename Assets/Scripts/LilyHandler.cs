using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyHandler : MonoBehaviour
{
    //public GameObject CarPrefab;
    public float LilySpeed = 14f;
    public float LilySpeedMultiplier;
    public int Lilydirection = 1;

    private Vector3 leftedge;
    private Vector3 rightedge;
    // Start is called before the first frame update
    
        void Start()
        {
       
        }

        // Update is called once per frame
        void Update()
        {

           

            transform.position += new Vector3(Lilydirection * LilySpeed * Time.deltaTime, 0, 0); 
        }
    
}
