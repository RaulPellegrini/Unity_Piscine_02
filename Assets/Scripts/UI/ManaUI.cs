using UnityEngine;
using UnityEngine.UI;
public class MP : MonoBehaviour
{
    [SerializeField] GameObject[] manaPointsUI;
    [SerializeField] int mana = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void ManaRegen()
    {
        if(mana < manaPointsUI.Length)
        {
            manaPointsUI[mana].GetComponent<Image>().color = Color.white;
            mana ++;
        }


    }

    public void ManaUse()
    {
        if(mana > 0)
        {
            manaPointsUI[mana].GetComponent<Image>().color = Color.black;
            mana --;
        }
    }
}
