using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LilySpawer : MonoBehaviour
{
    public GameObject Lily; // The object to spawn
    public float spawnInterval2 = 2f; // Time between spawns
    public float timer2 = 0f;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame



    void Update()
    {
        // Check if the spawn count has been reached
        timer2 += Time.deltaTime;
        if (timer2  > spawnInterval2)
        {
            Spawn2();
            timer2 = 0f;
        }
    }



    void Spawn2()
    {
        Instantiate(Lily, transform.position, Quaternion.identity);

    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }

}

