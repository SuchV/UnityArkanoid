using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public void OnBackButtonClick()
    {
        gameObject.SetActive(false);
    }
}
