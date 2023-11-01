using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        GameManager.Instance.AddPoints();
        Destroy(gameObject);
    }
}
