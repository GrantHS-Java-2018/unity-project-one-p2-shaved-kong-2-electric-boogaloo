using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Dice : MonoBehaviour
{
    
    private Sprite[] _diceSides;

    private SpriteRenderer _rend;

    // Start is called before the first frame update
    void Start()
    {

        _rend = GetComponent<SpriteRenderer>();

        _diceSides = Resources.LoadAll<Sprite>("DiceSides/");

    }

    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        var randomDiceSides = 0;
        var finalSide = 0;
        for (var i = 0; i <= 20; i++)
        {
            randomDiceSides = Random.Range(0, 5);
            _rend.sprite = _diceSides[randomDiceSides];
            
            yield return new WaitForSeconds(0.05f);
                

        }

        finalSide = randomDiceSides + 1;
        
        
    }



}
