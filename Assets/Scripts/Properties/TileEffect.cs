using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class TileEffect : MonoBehaviour
{
    
    public enum EffectType{
    
        NORMAL,
        GO,
        RAILROAD,
        CHANCE,
        COMMUNITY_CHEST,
        GO_TO_JAIL,
        JUST_VISITING,
        ELECTRIC_COMPANY,
        WATER_WORKS,
        INCOME_TAX,
        LUXURY_TAX,
        FREE_PARKING,
        TEST
  
    }
    
    Tile _tile;
    public Tile tile {
        get {
            return _tile;
        }
    }
    
    public abstract EffectType effect { get; }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
