using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    
    private static GameObject tile;
    private static GameObject dice;
    public bool player1Land = false;
    public bool player2Land = false;
    
    public int _tileWaypoint = tile.GetComponent<FollowThePath>().waypointIndex;
    public int p1Tile = 0; 
    public int p2Tile = 0;
    private bool a = true;

    void Start(){
        dice = GameObject.Find("Dice");
        Test();
        
    }

    void Test()
    {
        while (a = true)
        {
            p1Tile = dice.GetComponent<Dice>().p1TotalTile;
            p2Tile = dice.GetComponent<Dice>().p2TotalTile;
        }
        
    }

    
 
    void Update()
    {
        
        if (dice.GetComponent<Dice>().p1TotalTile == _tileWaypoint){
            player1Land = true;
        }
        else if (dice.GetComponent<Dice>().p2TotalTile == _tileWaypoint){
            player2Land = true;
        }
        else
        {
            player2Land = false;
            player1Land = false;
        }
    }
}