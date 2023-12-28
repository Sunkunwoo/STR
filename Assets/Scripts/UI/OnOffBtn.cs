using UnityEngine;

public class OnOffBtn : MonoBehaviour
{
    public string targetName;
    GameObject _targetUi;
    bool _IsTargetOn = false;
    Player player;

    private void Awake()
    {
        _targetUi = GameObject.Find(targetName);
    }

    private void Start()
    {
        player = TestManager.I.player;
        _targetUi.SetActive(false);
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
        UpdateSkillSlotUI();
    }

    private void UpdateSkillSlotUI()
    {
        foreach (SkillSlotUI skillSlot in player.skillSlots)
        {
            skillSlot.UpdateUI();
        }
    }
}
