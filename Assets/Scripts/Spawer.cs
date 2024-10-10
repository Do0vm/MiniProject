using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawer : MonoBehaviour
{
    public GameObject objectPrefab; // The object to spawn
    public float spawnInterval = 0f; // Time between spawns
    public float timer = 0f;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame



    void Update()
    {
        // Check if the spawn count has been reached
        timer += Time.deltaTime;
        if (timer  > spawnInterval)
        {
            Spawn();
            timer = 0f;
        }
    }



    void Spawn()
    {
        Instantiate(objectPrefab, transform.position, Quaternion.identity);

    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }


}

