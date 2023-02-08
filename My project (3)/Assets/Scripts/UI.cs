using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{

    public PlayerController pc; //ui must see the player controller to display the score
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI winDisplay;

    // Start is called before the first frame update
    void Start()
    {
        winDisplay.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.score >= 8) { //has collected all the pizzas
            winDisplay.text = "You Win!";
        } else if (pc.lose) {
            winDisplay.text = "You Lose!";
        }
        scoreDisplay.text = "Score: " + pc.score;
    }
}
