using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;

public class BallBehaviour : MonoBehaviour
{
    Vector2 _ballDirection = new Vector2(1,1);
    [SerializeField] private float _moveSpeed = 3f;

    List<Vector3> _mainDirections = new() { Vector3.left, Vector3.right, Vector3.up, Vector3.down };

    private void OnCollisionEnter(Collision other) {

        Vector3 otherPosition = other.collider.ClosestPoint(transform.position);
        Vector3 direction = (otherPosition - transform.position).normalized;

        var angles = (from vec in _mainDirections select Mathf.Abs(Vector3.Angle(vec, direction))).ToList();

        float minAngle = angles.Min();
        int minIndex = angles.FindIndex(elem => elem == minAngle);

        if (minIndex is 0 or 1) // left and right
        {
            _ballDirection.x *= -1;
        }
        else
        {
            _ballDirection.y *= -1;
        }
    }

    private void Update()
    {
        transform.position += (Vector3)_ballDirection * _moveSpeed * Time.deltaTime;


    }
}
