using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsHandler : MonoBehaviour
{
    //public GameObject CarPrefab;
    public float CarSpeed = 1f;
    public float CarSpeedMultiplier;
    public int direction = -1;

    private Vector3 leftedge;
    private Vector3 rightedge;
    // Start is called before the first frame update
    
        void Start()
        {
       
        }

        // Update is called once per frame
        void Update()
        {

           

            transform.position += new Vector3(direction * CarSpeed * Time.deltaTime, 0, 0); 
        }
    
}
