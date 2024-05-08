using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text player1Text;
    public Text player2Text;

    public void UpdateP1ScoreText(int score){
        player1Text.text = score.ToString();
    }

        public void UpdateP2ScoreText(int score){
        player2Text.text = score.ToString();
    }
}
