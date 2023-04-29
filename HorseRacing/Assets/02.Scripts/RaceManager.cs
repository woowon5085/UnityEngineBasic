using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class RaceManager : MonoBehaviour
{
    [SerializeField] private Horse[] _horses;
    private Horse[] _horsesFinished;
    private int _grade;

    /// <summary>
    /// ���ֽ���, ������ ��߽�Ŵ.
    /// </summary>
    public void StartRace()
    {
        for (int i = 0; i < _horses.Length; i++)
        {
            _horses[i].doMove = true;
        }
    }

    /// <summary>
    /// ���� ����. 1,2,3���� UI �� �����.
    /// </summary>
    public void FinishRace()
    {

    }

    /// <summary>
    /// ������ �� ���
    /// </summary>
    public void RegisterFinishedHorse(Horse horse)
    {
        horse.doMove = false;
        _horsesFinished[_grade] = horse;

        if (_grade < _horses.Length - 1)
            _grade++;
        else
            FinishRace();
    }

    private void Awake()
    {
        _horsesFinished = new Horse[_horses.Length];
    }
}