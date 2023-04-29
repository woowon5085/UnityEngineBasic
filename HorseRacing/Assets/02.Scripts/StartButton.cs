using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] private Button _start;

    private void Awake()
    {
        _start.onClick.AddListener(StartClickLog);
        //_start.onClick.AddListener(() => Debug.Log("Start Clicked")); // 람다식 표현 
    }

    private void StartClickLog()
    {
        Debug.Log("StartClicked");
    }

}
