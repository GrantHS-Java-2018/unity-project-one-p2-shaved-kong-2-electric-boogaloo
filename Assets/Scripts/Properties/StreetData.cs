using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetData : MonoBehaviour
{

    private StreetManager streetManager;
    private object[,] streetData;
    
    
    
    private void InitializeStreetData() {
        streetData = new object[,] {
            { "Go", StreetType.GO, null, null, null, null, null, null, null, null },
            { "Medeterranean Avenue", StreetType.NORMAL, streetManager.brownGroup, 60, 30, 10, 30, 90, 160, 250 },
            { "Community Chest", StreetType.COMMUNITY_CHEST, null, null, null, null, null, null, null, null },
            { "Baltic Avenue", StreetType.NORMAL, streetManager.brownGroup, 60, 30, 20, 60, 180, 320, 450 },
            { "Income Tax", StreetType.INCOME_TAX, null, null, null, null, null, null, null, null },
            { "Reading Railroad", StreetType.RAILROAD, null, null, null, null, null, null, null, null },
            { "Oriental Avenue", StreetType.NORMAL, streetManager.cyanGroup, 100, 50, 30, 90, 270, 400, 550 },
            { "Chance", StreetType.CHANCE, null, null, null, null, null, null, null, null },
            { "Vermont Avenue", StreetType.NORMAL, streetManager.cyanGroup, 100, 50, 30, 90, 270, 400, 550 },
            { "Connecticut Avenue", StreetType.NORMAL, streetManager.cyanGroup, 120, 60, 40, 100, 300, 450, 600 },
            { "Just Visiting/In Jail", StreetType.JUST_VISITING, null, null, null, null, null, null, null, null },
            { "St. Charles Place", StreetType.NORMAL, streetManager.purpleGroup, 140, 70, 50, 150, 450, 625, 750 },
            { "Electric Company", StreetType.ELECTRIC_COMPANY, null, null, null, null, null, null, null, null },
            { "States Avenue", StreetType.NORMAL, streetManager.purpleGroup, 140, 70, 50, 150, 450, 625, 750 },
            { "Virginia Avenue", StreetType.NORMAL, streetManager.purpleGroup, 160, 80, 60, 170, 500, 700, 900 },
            { "Pennsylvania Railroad", StreetType.RAILROAD, null, null, null, null, null, null, null, null },
            { "St. James Place", StreetType.NORMAL, streetManager.orangeGroup, 180, 90, 70, 200, 550, 750, 950 },
            { "Community Chest", StreetType.COMMUNITY_CHEST, null, null, null, null, null, null, null, null },
            { "Tennessee Avenue", StreetType.NORMAL, streetManager.orangeGroup, 180, 90, 70, 200, 550, 750, 950 },
            { "New York Avenue", StreetType.NORMAL, streetManager.orangeGroup, 200, 100, 80, 220, 600, 800, 1000 },
            { "Free Parking", StreetType.FREE_PARKING, null, null, null, null, null, null, null, null },
            { "Kentucky Avenue", StreetType.NORMAL, streetManager.redGroup, 220, 110, 90, 250, 700, 875, 1050 },
            { "Chance", StreetType.CHANCE, null, null, null, null, null, null, null, null },
            { "Indiana Avenue", StreetType.NORMAL, streetManager.redGroup, 220, 110, 90, 250, 700, 875, 1050 },
            { "Illinois Avenue", StreetType.NORMAL, streetManager.redGroup, 240, 120, 100, 300, 750, 925, 1100 },
            { "B. & O. Railroad", StreetType.RAILROAD, null, null, null, null, null, null, null, null },
            { "Atlantic Avenue", StreetType.NORMAL, streetManager.yellowGroup, 260, 130, 110, 330, 800, 975, 1150 },
            { "Ventnor Avenue", StreetType.NORMAL, streetManager.yellowGroup, 260, 130, 110, 330, 800, 975, 1150 },
            { "Water Works", StreetType.WATER_WORKS, null, null, null, null, null, null, null, null },
            { "Marvin Gardens", StreetType.NORMAL, streetManager.yellowGroup, 280, 140, 120, 360, 850, 1025, 1200 },
            { "Go to Jail", StreetType.GO_TO_JAIL, null, null, null, null, null, null, null, null },
            { "Pacific Avenue", StreetType.NORMAL, streetManager.greenGroup, 300, 150, 130, 390, 900, 1100, 1275 },
            { "North Carolina Avenue", StreetType.NORMAL, streetManager.greenGroup, 300, 150,120, 390, 900, 110, 1275 },
            { "Community Chest", StreetType.COMMUNITY_CHEST, null, null, null, null, null, null, null, null },
            { "Pennsylvania Avenue", StreetType.NORMAL, streetManager.greenGroup, 320, 160, 150, 450, 1000, 1200, 1400 },
            { "Short Line", StreetType.RAILROAD, null, null, null, null, null, null, null, null },
            { "Chance", StreetType.CHANCE, null, null, null, null, null, null, null, null },
            { "Park Place", StreetType.NORMAL, streetManager.blueGroup, 350, 175, 175, 500, 1100, 1300, 1500 },
            { "Luxury Tax", StreetType.LUXURY_TAX, null, null, null, null, null, null, null, null },
            { "Boardwalk", StreetType.NORMAL, streetManager.blueGroup, 400, 200, 200, 600, 1400, 1700, 2000 },
        };
    }
    
    // Start is called before the first frame update
    void Start()
    {
        streetManager = gameObject.GetComponent<StreetManager>();

        InitializeStreetData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
