using UnityEngine;

public class TrophyMover : MonoBehaviour
{
    // Define the three points
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;

    public float speed = 2f;  // Speed of the movement

    private Vector3[] points;
    private int currentPointIndex = 0;

    void Start()
    {
        // Set up the points array
        points = new Vector3[] { pointA.position, pointB.position, pointC.position };
    }

    void Update()
    {
        MoveTrophy();
    }

    void MoveTrophy()
    {
        // Move the trophy towards the current target point
        transform.position = Vector3.MoveTowards(transform.position, points[currentPointIndex], speed * Time.deltaTime);

        // If the trophy has reached the current target point
        if (Vector3.Distance(transform.position, points[currentPointIndex]) < 0.1f)
        {
            // Move to the next point (loop back to the start if at the last point)
            currentPointIndex = (currentPointIndex + 1) % points.Length;
        }
    }
}
