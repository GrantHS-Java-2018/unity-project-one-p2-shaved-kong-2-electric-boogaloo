using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField] private float moveSpeed = 1f;

    [HideInInspector] public int waypointIndex = 0;

    public bool moveAllowed = false;
    
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (moveAllowed)
            Move();
    }
}
