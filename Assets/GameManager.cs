using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private int _points = 0;
    
    public int Points
    {
        get { return _points; }
    }

    public void AddPoints()
    {
        _points++;
    }

    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
