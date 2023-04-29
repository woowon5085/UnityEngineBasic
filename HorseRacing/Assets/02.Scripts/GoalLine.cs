using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalLine : MonoBehaviour
{
    [SerializeField] private LayerMask _targetMask;
    [SerializeField] private RaceManager _raceManager;

    private void OnTriggerEnter(Collider other)
    {
        if ((1<<other.gameObject.layer & _targetMask) > 0) // 00000000 00000000 0000010 0000000
        {
            _raceManager.RegisterFinishedHorse(other.GetComponent<Horse>());
        }
    }
}
