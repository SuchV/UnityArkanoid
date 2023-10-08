using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Vector2 _ballDirection = new Vector2(1,1);
    [SerializeField] private float _moveSpeed = 3f;


    private void OnCollisionEnter(Collision other) {
        if(Physics.Raycast(transform.position,Vector3.left,1)) 
        {
            _ballDirection.x *=-1;
        }
        else if(Physics.Raycast(transform.position,Vector3.right,1)) 
        {
            _ballDirection.x *=-1;
        }
        else if(Physics.Raycast(transform.position,Vector3.up,1)) 
        {
            _ballDirection.y *=-1;
        }
        else if(Physics.Raycast(transform.position,Vector3.down,1)) 
        {
            _ballDirection.y *=-1;
        }

    }

    private void Update()
    {
        transform.position += (Vector3)_ballDirection * _moveSpeed * Time.deltaTime;


    }
}
