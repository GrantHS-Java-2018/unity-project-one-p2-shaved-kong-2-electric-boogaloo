using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Analytics;
//Most of these lines at the beginning of each class are the same thing, sometimes the variables are different but they all serve to set up the game objects and ints to their default status.
public class GameControl : MonoBehaviour
{
    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start()
    {
        /*The who wins text shadow is for the end of the game and declares a winner. It is hidden until the end of the game is reached
        the move text also contributes to moving by setting a players move status to active or inactive */
//Starts the game, sets up objects that determine whose turn it is etc 
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
    void Update()
    { //This code tricks the game loop into not stopping at go, it allows the game to contiuosly run 
        if (player1StartWaypoint + diceSideThrown > 39)
        {
            player1StartWaypoint = player1StartWaypoint - 39;
        }

        if (player2StartWaypoint + diceSideThrown > 39)
        {
            player2StartWaypoint = player2StartWaypoint - 39;
        }
        //These two if statements change the components which allows turns to switch and the game to end. They're instructed by the switch case statement at the bottom.
        if (player1.GetComponent<FollowThePath>().waypointIndex == player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex == player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex;
        }

        //allows player1 to follow the waypoint path
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1.GetComponent<FollowThePath>().waypoints.Length - 1)
        {
           //Sets movement speed for player 1
            player1.GetComponent<FollowThePath>().waypointIndex %= 40;
        }
        //Allows player 2 to follow the waypoint path 
        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2.GetComponent<FollowThePath>().waypoints.Length - 1)
        {
           //Player 2 movement speed
            player2.GetComponent<FollowThePath>().waypointIndex %= 40;
        }
        //Sets win condition, if player1 has no money player2 wins
        if (player1.GetComponent<PlayerMoney>().money <= 0)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
        //Sets win condition, if player2 has no money player1 wins
        if (player2.GetComponent<PlayerMoney>().money <= 0)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }
    }
//Switch case statement which allows the game to switch whose turn it is
    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
}