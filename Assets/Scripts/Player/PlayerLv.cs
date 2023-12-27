using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLv : MonoBehaviour
{
    int _lv = 1;
    int _exp = 0;
    int _maxExp = 100;

    public int Lv
    {
        get { return _lv; }
        set { _lv = value; }
    }
    public int Exp
    {
        get { return _exp; }
        set { _exp = value; }
    }
    public int MaxExp
    {
        get { return _maxExp; }
        set { _maxExp = value; }
    }

    public void AddExp(int add)
    {
        _exp = _exp + add;
    }
}
