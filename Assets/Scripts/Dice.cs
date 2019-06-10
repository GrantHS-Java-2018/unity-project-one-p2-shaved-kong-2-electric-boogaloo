using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public Sprite[] _diceSides = new Sprite[6];
    public SpriteRenderer _rend;
    public int _whosTurn = 1;
    public bool _coroutineAllowed = true;
    public int p1TotalTile = 0;
    public int p2TotalTile = 0;
    

    // Start is called before the first frame update
    private void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        _diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        _rend.sprite = _diceSides[0];
    }

    private void OnMouseDown()
    {
        if(!GameControl.gameOver && _coroutineAllowed)
            StartCoroutine("RollTheDice");
    }

    //This segment rolls our dice in unity, it generates a random number ranged 1-6 and then moves the player said value. 
    // It also changes whose turn it is
    private IEnumerator RollTheDice()
    {
        _coroutineAllowed = false;

        int randomDiceSides = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSides = Random.Range(0, 6);
            _rend.sprite = _diceSides[randomDiceSides];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSides + 1;
        if (_whosTurn == 1)
        {
            GameControl.MovePlayer(1);
            
            p1TotalTile += randomDiceSides;
            if (p1TotalTile > 39) p1TotalTile -= 40;

        } else if (_whosTurn == -1)
        {
            GameControl.MovePlayer(2);
            
            p2TotalTile += randomDiceSides;
            if (p2TotalTile > 39) p2TotalTile -= 40;

        }
        
        _whosTurn *= -1;
        _coroutineAllowed = true;
    }
    
    public int GetP1Tile()
    {
        return p1TotalTile;
    }
    public int GetP2Tile()
    {
        return p2TotalTile;
    }
}
