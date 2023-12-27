using TMPro;
using UnityEngine;

public class LvUiUpdate : MonoBehaviour
{
   public TMP_Text _lvTxt;

    void Update()
    {
        _lvTxt.text = $"Lv : {TestManager.I.player.playerLv.Lv}, Exp : {TestManager.I.player.playerLv.Exp} / {TestManager.I.player.playerLv.MaxExp}";
    }
}
