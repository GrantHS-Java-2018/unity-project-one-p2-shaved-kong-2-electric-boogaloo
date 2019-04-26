using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    private void OnMouseDown()
    {
        if(!GameControl.gameOver && coroutineAllowed)
             StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;

        int randomDiceSides = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSides = Random.Range(0, 5);
            rend.sprite = diceSides[randomDiceSides];
            
            yield return new WaitForSeconds(0.05f);
                

        }

        GameControl.dicesideThrown = randomDiceSides + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        } else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        
        whosTurn *= -1;
        coroutineAllowed = true;
    }
}
