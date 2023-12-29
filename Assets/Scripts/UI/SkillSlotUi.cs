using UnityEngine;
using TMPro;

public class SkillSlotUI : SkillSlot
{
    public TMP_Text skillNameText;
    public TMP_Text skillDmgTxt;
    public TMP_Text skillCollTxt;

    bool skillLock = true;

    public EquipSkillSlots[] equipSkillSlots;

    protected override void SetDefaultSkillData(SkillData data)
    {
        base.SetDefaultSkillData(data);
        UpdateUI();
    }
    protected override void OnClick()
    {

        int selectedSlotIndex = TestManager.I.skillManager.selectSolot;
        if (skillData.skillLv == 0 || skillData.index == 0)
        {
            Debug.Log("�� ���� Ȥ�� ��ų�� �رݵ��� ���� �����Դϴ�.");
        }
        else
        {
            if (equipSkillSlots[selectedSlotIndex].skillData == null ||
                (equipSkillSlots[0].skillData.index != skillData.index &&
                 equipSkillSlots[1].skillData.index != skillData.index &&
                 equipSkillSlots[2].skillData.index != skillData.index))
            {
                equipSkillSlots[selectedSlotIndex].SetSkillData(skillData);
            }
            else if (equipSkillSlots[selectedSlotIndex].skillData.index == skillData.index)
            {
                Debug.Log("������ ��ų ������");
            }
            else
            {
                Debug.Log("�ٸ� ���Կ��� �̹� ������ ��ų �����͸� ��� ���Դϴ�.");
            }
        }


    }

    public void UpdateUI()
    {
        if (skillData.index != 0)
        {
            skillNameText.text = "Name: " + skillData.skillName + " Lv."+ skillData.skillLv;
            skillDmgTxt.text = "Dmg: " + skillData.point;
            skillCollTxt.text = "Coll: " + skillData.coolTime;
        }
        else
        {
            skillNameText.text = "Name: -";
            skillDmgTxt.text = "Dmg: -";
            skillCollTxt.text = "Coll: -";
        }
    }
}
