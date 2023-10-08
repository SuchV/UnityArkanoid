using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        GameManager.Instance.AddPoints();
        Destroy(gameObject);
        Debug.Log(GameManager.Instance.Points);
    }
}
