using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class Player : MonoBehaviour
{
    //none of my shit works at all because I don't know what I'm doing

    private static GameObject player1, player2;


    public int p1CurrentTile = 0;
    public int p2CurrentTile = 0;


    void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    private void Update()
    {
        p1CurrentTile = player1.GetComponent<Dice>().GetP1Tile();
        p2CurrentTile = player2.GetComponent<Dice>().GetP2Tile();
    }
}
