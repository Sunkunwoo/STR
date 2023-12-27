using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffBtn : MonoBehaviour
{
    public string targetName;
    GameObject _targetUi;
    bool _IsTargetOn = false;

    private void Awake()
    {
        _targetUi = GameObject.Find(targetName);
    }

    public void OnTarget()
    {
        if (!_IsTargetOn)
        {
            _targetUi.SetActive(true);
        }
        else
        {
            _targetUi.SetActive(false);
        }
        _IsTargetOn = !_IsTargetOn;
    }
}
