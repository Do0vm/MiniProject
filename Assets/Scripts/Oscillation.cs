using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    public float OSpeed = 1.0f;
    public float ODistance = 3.0f;

    private Vector3 startPos;
    private float phaseOffset;



    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        phaseOffset = Random.Range(0f, Mathf.PI*2f);
    }

    // Update is called once per frame
    void Update()
    {
        float oscillation = Mathf.Sin(Time.time*OSpeed+phaseOffset)*ODistance;

        transform.position = new Vector3(startPos.x+oscillation,startPos.y, startPos.z);
    }
}
