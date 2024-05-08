using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaddleP1 : MonoBehaviour
{

    protected Rigidbody2D _rigidbody2D;
    public float speed = 10;

    private void Awake(){
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private Vector2 _direction;

    void Update()
    {
        float verticalAxisValue = Input.GetAxis("Vertical");
        if(verticalAxisValue > 0 ){
            _direction = Vector2.up;
        } else if (verticalAxisValue < 0) {
            _direction = Vector2.down;
        } else {
            _direction = Vector2.zero;
        }
    }
    private void FixedUpdate(){
        if(_direction.sqrMagnitude != 0) {
            _rigidbody2D.AddForce(_direction * speed);  
        }
    } 

}