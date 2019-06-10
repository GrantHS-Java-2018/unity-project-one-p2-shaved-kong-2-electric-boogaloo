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
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2"); 
    }

    void Effect()
    {
        {
            if (tile.player1Land == true)
            {
                player1.GetComponent<PlayerMoney>().money -= 1500;
            }
            
            if (tile.player2Land == true)
            {
                player2.GetComponent<PlayerMoney>().money -= 1500;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Effect();
    }
}
