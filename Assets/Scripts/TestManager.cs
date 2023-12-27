using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public static TestManager I;
    public Player player;
    public SkillList skillList;

    public void Awake()
    {
        I = this;
        player = GameObject.Find("Player").GetComponent<Player>();
        skillList = GameObject.Find("SkillData").GetComponent<SkillList>();
    }

    public void Start()
    {

    }
}
