﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streets : MonoBehaviour
{
    string[] streetArray = new string[22];
    
}

public enum StreetType{
    
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
    FREE_PARKING
  
}