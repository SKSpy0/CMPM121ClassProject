using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        var playerscript = player.GetComponent<Player>();

        scoreText.text = "Cubes Collected: " + playerscript.cubesCollected.ToString();
    }

}
