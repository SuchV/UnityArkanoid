using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private int _points = 0;

    public Action OnPointsChangedEvent;

    
    public int Points
    {
        get { return _points; }
    }

    public void AddPoints()
    {
        _points++;
        OnPointsChangedEvent?.Invoke();
    }
}
