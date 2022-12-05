using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Waypoint script
//This script utilizes 2 waypoints to control the moving platforms and enemies to move between the waypoints
public class WaypointMover : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f) // check if the object reach the other waypoint
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime); // Bounce between the waypoints
    }
}
