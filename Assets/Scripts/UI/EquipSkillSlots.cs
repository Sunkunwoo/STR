public class EquipSkillSlots : SkillSlot
{
    public int index;
    SkillManager skillManager;

    private void Start()
    {
        skillManager = TestManager.I.skillManager;
    }

    protected override void OnClick()
    {
        skillManager.selectSolot = index;
    }
}
