using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D _rigidBody;
    public float speed = 500.0f;

    private void Awake(){
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition(){
        _rigidBody.position = Vector3.zero;
        _rigidBody.velocity = Vector3.zero;
    }

    public void AddStartingForce(){
        float x = Random.value <  0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :  Random.Range(0.5f, 1.0f);
        _rigidBody.AddForce(new Vector2(x, y) * speed);
    }

}
