using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LogsSpawner : MonoBehaviour
{
    public GameObject Logs; // The object to spawn
    public float spawnInterval3 = 2f; // Time between spawns
    public float timer3 = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame



    void Update()
    {
        // Check if the spawn count has been reached
        timer3 += Time.deltaTime;
        if (timer3 > spawnInterval3)
        {
            Spawn3();
            timer3 = 0f;
        }
    }



    void Spawn3()
    {
        Instantiate(Logs, transform.position, Quaternion.identity);

    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }

}

