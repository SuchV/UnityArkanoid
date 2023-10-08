using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 7f;

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

        Vector3 moveDir = new Vector3(inputVector.x,0f,0f);
        transform.position += moveDir * _moveSpeed * Time.deltaTime;
    }
}
