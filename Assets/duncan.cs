using UnityEngine;
using System.Collections.Generic;

public class PlayerScore : MonoBehaviour
{

    // To Do's:
    private int score;
    private List<int> Coins = new List<int>();

    void Start()
    {
        // Loop: toon 3x een startbericht met Debug.Log in een loop
        for(int i = 0; i < 3; i++)
                  {
                    Debug.Log("start");
                  }
    }

    void Update()
    {
        // If-statement: check of score >= 50
        if (score >= 50)
        {
            Debug.Log("gewonnen");
        }
        // Zo ja geef een bericht met Debug.Log dat je hebt gewonnen


        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddCoin(Random.Range(10, 20));
            // Roep functie AddCoin aan en geef de waarde van de coin mee
            // Gebruik Random.Range(int min, int max) om een random waarde aan je coin te geven
            
          
         }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {
        Coins.Add(coinValue);
        // Verhoog score met de coin value
        score += coinValue;
        Debug.Log("je hebt een munt" + score);
    }
}