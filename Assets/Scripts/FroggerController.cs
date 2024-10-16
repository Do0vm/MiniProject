using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FroggerController : MonoBehaviour
{      
    
    public float MoveDistance = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 

            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                Move(Vector3.up);
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                Move(Vector3.left);
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.rotation = Quaternion.Euler(0f, 0f, -90f);
                Move(Vector3.right);
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 180f);
                Move(Vector3.down);
            }


            void Move(Vector3 pos) 
            {
                transform.position += pos * MoveDistance;
            }
    }
}
