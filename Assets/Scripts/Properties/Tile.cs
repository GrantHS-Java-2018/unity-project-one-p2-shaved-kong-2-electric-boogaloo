using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class Tile : MonoBehaviour
{
    //none of my shit works at all because I don't know what I'm doing
    
    private static GameObject tile;
    private static GameObject dice;
    private bool player1Land = false;
    private bool player2Land = false;
    
    //Supposed to get the waypoint of the tile it's attached to but unity hurts my brain
    private int _tileWaypoint = tile.GetComponent<FollowThePath>().waypointIndex;
    public int p1Tile = 0; 
    public int p2Tile = 0;

    void Start(){
        dice = GameObject.Find("Dice");
        _tileWaypoint = tile.GetComponent<FollowThePath>().waypointIndex;
    }

    
    //This was suposed to check for if a player was on the tile but it didn't work
    
    private void PlayerCheck()
    {
        //I'm using these getcomponents here because I don't really understand
        //how to access variables through different classes in c#/unity
        p1Tile = dice.GetComponent<Dice>().GetP1Tile();
        p2Tile = dice.GetComponent<Dice>().GetP2Tile();
        
        if (p1Tile == _tileWaypoint){
            player1Land = true;
        }
        else if (p2Tile == _tileWaypoint){
            player2Land = true;
        }
        else
        {
            player2Land = false;
            player1Land = false;
        }
    }

    public bool GetP1Land()
    {
        return player1Land;
    }

    public bool GetP2Land()
    {
        return player2Land;
    }
 
    void Update()
    {
        PlayerCheck();     
    }
}