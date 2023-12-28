using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEditor.Progress;

public class SkillList : MonoBehaviour
{
    public List<SkillData> skillDatas;

    void Awake()
    {
        skillDatas = ReadCSVFile("Assets/CSV/SkillList.csv");

        foreach (var skillData in skillDatas)
        {
            Debug.Log("Loaded Skill Name: " + skillData.skillName);
        }
    }


    public List<SkillData> ReadCSVFile(string path)
    {
        List<SkillData> result = new List<SkillData>();
        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    SkillData newSkillData = new SkillData
                    {
                        index = int.Parse(values[0]),
                        skillName = values[1],
                        skillType = (SkillType)Enum.Parse(typeof(SkillType), values[2]),
                        skillUsingType = (SkillUsingType)Enum.Parse(typeof(SkillUsingType), values[3]),
                        skillGetType = (SkillGetType)Enum.Parse(typeof(SkillGetType), values[4]),
                        point = int.Parse(values[5]),
                        lvUpPoint = int.Parse(values[6]),
                        skillLv = int.Parse(values[7]),
                        skillExp = int.Parse(values[8]),
                        coolTime = float.Parse(values[9]),
                        lvUpCoolTime = float.Parse(values[10])
                    };

                    result.Add(newSkillData);
                }
            }
        }
        catch (IOException e)
        {
            Debug.LogError("Error reading the CSV file: " + e.Message);
        }

        return result;
    }
}