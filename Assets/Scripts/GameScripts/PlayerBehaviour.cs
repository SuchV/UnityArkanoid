using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 7f;
    public Vector3 _mapDimension = new Vector3(0, 0, 0);
    public Vector3 _paddleDimension = new Vector3(0, 0, 0);
    //public float _mapSize;
    public float _paddleSize;


    private void Awake()
    {
        _mapDimension.x = Vector3.Distance((GameObject.Find("Env/WallLeft").transform.position), (GameObject.Find("Env/WallRight").transform.position));
        _paddleDimension = GetComponent<BoxCollider>().bounds.size;
        _mapDimension.x -= _paddleDimension.x;
    }

    void Update()
    {
        Vector2 inputVector = new Vector2(0,0);

        if(Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }

        if(Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1;
        }
        Vector3 moveDir = new Vector3(inputVector.x, 0f, 0f);

        // Something is really fucked up here, no idea how to fix it, gonna sleep now
        if (Mathf.Abs(GameObject.Find("Paddle/Cube").transform.position.x) < _mapDimension.x / 2.0f)
        {
            transform.position += moveDir * _moveSpeed * Time.deltaTime;

        }
        else
        {
            transform.position += moveDir * _moveSpeed * Time.deltaTime;
        }
    }
}
