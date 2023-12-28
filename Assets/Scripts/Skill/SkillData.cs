using System;

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

[Serializable]
public class SkillData : IComparable<SkillData>
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

    public int CompareTo(SkillData other)
    {
        return index.CompareTo(other.index);
    }

    public void SkillLvup()
    {
        if(skillGetType == SkillGetType.Lvup)
        {
            skillExp += 100;
        }

        while(skillExp >= 100)
        {
            if(skillLv !=0)
            {
                point += lvUpPoint;
                coolTime -= lvUpCoolTime;
            }
            skillLv++;
            skillExp -= 100;

        }
    }
}