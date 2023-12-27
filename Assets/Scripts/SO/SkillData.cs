using System.Collections.Generic;
using UnityEngine;

public enum SkillGetType
{
    Lvup,
    Pickup
}

public enum SkillUsingType
{
    Active,
    Passive
}

public enum SkillType
{
    Heal,
    Util,
    Attack,
    Def
}

[CreateAssetMenu(fileName = "SkillData", menuName = "Custom/Skill Data", order = 1)]
public class SkillData : ScriptableObject
{
    public int index;
    public string skillName;
    public SkillType skillType;
    public SkillUsingType skillUsingType;
    public SkillGetType skillGetType;
    public int point;
    public int lvUpPoint;
    public int skillLv;
    public int skillExp;
    public float coolTime;
    public float lvUpCoolTime;

    public void AddSkillExp(int exp)
    {
        skillExp += exp;
        SkillLvup();
    }

    public void SkillLvup()
    {
        if(skillGetType == SkillGetType.Lvup)
        {
            skillExp += 100;
        }

        while(skillExp >= 100)
        {
            skillLv++;
            skillExp -= 100;
            point += lvUpPoint;
            coolTime -= lvUpCoolTime;
        }
    }
}