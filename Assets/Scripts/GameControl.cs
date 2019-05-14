﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Analytics;

public class GameControl : MonoBehaviour
{
    public static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;
    public static GameObject player1, player2;

    public static int DicesideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static bool gameOver = false;
    


    // Start is called before the first frame update
    public void Start()
    {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    private void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1StartWaypoint + DicesideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex ==
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "player 1 wins";
            gameOver = true; 

        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "player 2 wins";
            gameOver = true; 
            
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        if (playerToMove != 1)
        {
            if (playerToMove == 2) player2.GetComponent<FollowThePath>().moveAllowed = true;
        }
        else
        {
            player1.GetComponent<FollowThePath>().moveAllowed = true;
        }
    }
    }

