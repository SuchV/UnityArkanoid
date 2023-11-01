using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;

    private void OnEnable()
    {
        GameManager.Instance.OnPointsChangedEvent += ScoreRefresh;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnPointsChangedEvent -= ScoreRefresh;
    }

    public void ScoreRefresh()
    {
        _scoreText.text = (GameManager.Instance.Points).ToString();
    }
    /*
    private void Awake()
    {
       // Debug.Log(GameManager.Instance.Points);
    }
    
    public int value = 10;
    public TextMeshProUGUI ScoreText;
    */
}
