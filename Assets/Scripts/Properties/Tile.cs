using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tile : MonoBehaviour
{
    //none of my shit works at all because I don't know what I'm doing
    
    private static GameObject tile;
    private static GameObject dice;
    public bool player1Land = false;
    public bool player2Land = false;
    
    public int _tileWaypoint = tile.GetComponent<FollowThePath>().waypointIndex;
    public int p1Tile = 0; 
    public int p2Tile = 0;

    void Start(){
        dice = GameObject.Find("Dice");
        
    }

    void PlayerCheck()
    {
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

 
    void Update()
    {
        PlayerCheck();     
    }
}