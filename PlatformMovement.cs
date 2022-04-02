using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed = 5f;
    private int waypointindex = 0;

    private void Update()
    {
        if( Vector2.Distance(waypoints[waypointindex].transform.position, transform.position) < .1f)
        {
            waypointindex++;
            if(waypointindex >= waypoints.Length)
            {
                waypointindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointindex].transform.position, Time.deltaTime * speed);
        {

        }
    }

    //Make platform stick to player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
    //end
}
