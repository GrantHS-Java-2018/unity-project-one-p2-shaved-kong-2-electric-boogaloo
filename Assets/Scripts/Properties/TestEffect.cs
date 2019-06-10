using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEffect : TileEffect
{
    //none of my shit works at all because I don't know what I'm doing
    
    private static GameObject player1, player2;
    
    public override EffectType effect {
        get {
            return TileEffect.EffectType.TEST;
        }
    }


    void Start()
    {
        //I have no idea how gameobjects work
        
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2"); 
    }

    //Supposed to remove money from the player that lands on the tile,
    //then give that money to the player who didn't.  Doesn't work because
    //the if statements cant become true
    void Effect()
    {
        {
             
            if (tile.GetP1Land())
            {
                player1.GetComponent<PlayerMoney>().money -= 200;
                player2.GetComponent<PlayerMoney>().money += 200;
            }
            
            if (tile.GetP2Land())
            {
                player2.GetComponent<PlayerMoney>().money -= 200;
                player1.GetComponent<PlayerMoney>().money += 200;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Effect();
    }
}
