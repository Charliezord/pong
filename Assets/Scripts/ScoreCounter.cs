using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
   private int _player1Score;

   private int _player2Score;

    [SerializeField]
    private UI ui;

    public void Player1Scored(){
        _player1Score++;
        ui.UpdateP1ScoreText(_player1Score);
    }

    public void Player2Scored(){
        _player2Score++;
         ui.UpdateP2ScoreText(_player2Score);
    }
}
