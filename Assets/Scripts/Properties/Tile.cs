using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    
    private static GameObject tile;
    private static GameObject player1, player2;
    public bool player1Land = false;
    public bool player2Land = false;
    
    private int tileWaypoint = tile.GetComponent<FollowThePath>().waypointIndex;
    

    void Start(){
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2"); 
    }    

    
 
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex == tileWaypoint){
            player1Land = true;
        }
        else if (player2.GetComponent<FollowThePath>().waypointIndex == tileWaypoint){
            player2Land = true;
        }
        else
        {
            player2Land = false;
            player1Land = false;
        }
    }
}