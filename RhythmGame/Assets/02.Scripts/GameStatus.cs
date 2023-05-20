using RhythmGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class GameStatus
{
    public static GameStatus instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameStatus();
            }
            return _instance;
        }
    }
    private static GameStatus _instance;

    public int currentCombo
    {
        get => _currentCombo;
        set
        {
            _currentCombo= value;
            onCurrentComboChanged?.Invoke(value);
        }
    }
    private int _currentCombo;
    public event Action<int> onCurrentComboChanged;

    public int score
    {
        get => _score;
        set
        {
            _score= value;
            onScoreChanged?.Invoke(value);
        }

    }

    private int _score;
    public event Action<int> onScoreChanged;

    public int coolCount
    {
        get => _coolCount;
        set
        {
            int diff = value - _coolCount;
            value = _coolCount;

            if(diff > 0)
            {
                currentCombo += diff;
            }
            score += diff + Globals.SCORE_COOL;
        }
    }
    private int _coolCount;

    public int greatCount
    {
        get => _greatCount;
        set
        {
            int diff = value - _greatCount;
            value = _greatCount;

            if (diff > 0)
            {
                currentCombo += diff;
            }
            score += diff + Globals.SCORE_GREAT;
            
        }
    }
    private int _greatCount;

    public int goodCount
    {
        get => _goodCount;
        set
        {
            int diff = value - _goodCount;
            value = _goodCount;

            if (diff > 0)
            {
                currentCombo += diff;
            }
            score += diff + Globals.SCORE_GOOD;
        }
    }
    private int _goodCount;

    public int missCount
    {
        get => _missCount;
        set
        {
            int diff = value - _missCount;
            value = _missCount;

            if (diff > 0)
            {
                currentCombo = 0;
            }
            score += diff + Globals.SCORE_MISS;
        }
    }
    private int _missCount;

    public int badCount
    {
        get => _badCount;
        set
        {
            int diff = value - _badCount;
            value = _badCount;

            if (diff > 0)
            {
                currentCombo = 0;
            }
            score += diff + Globals.SCORE_BAD;
        }
    }
    private int _badCount;



}

