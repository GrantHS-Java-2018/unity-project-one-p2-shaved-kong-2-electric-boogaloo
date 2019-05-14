using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public Sprite[] _diceSides = new Sprite[6];
    public SpriteRenderer _rend;
    public int _whosTurn = 1;
    public bool _coroutineAllowed = true;
    

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

        GameControl.DicesideThrown = randomDiceSides + 1;
        if (_whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        } else if (_whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        
        _whosTurn *= -1;
        _coroutineAllowed = true;
    }
}
