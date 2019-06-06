using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//real
public class FollowThePath : MonoBehaviour
{

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

    // Use this for initialization
    
   //This code sets up our waypoint index that was utilized in game control. Follow the path is teh path of waypoints hidden on our game board and is the key function for player movement
    private void Start () {
        transform.position = waypoints[waypointIndex].transform.position;
    }
	
    /* Update is called once per frame
    Also contributes to player movement by allowing the movement */
    private void Update () {
        if (moveAllowed)
            Move();
    }

    private void Move()
    
    //Class name sums it up as well as the code language. This code actually moves the player 
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
//Great job everyone I know we can do it!
