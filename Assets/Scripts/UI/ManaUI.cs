using UnityEngine;
using UnityEngine.UI;
public class MP : MonoBehaviour
{
    [SerializeField] GameObject[] manaPointsUI;
    [SerializeField] int mana = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        EnemyDestroyed.ManaReward += manaLisener;
    }

    void OnDestroy()
    {
        EnemyDestroyed.ManaReward -= manaLisener;
    }

    private void manaLisener(int manaGained)
    {
        Debug.Log("I heard you!");
        for(int i = 0; i < manaGained && i <manaPointsUI.Length; i++)
            ManaRegen();
    }
    private void ManaRegen()
    {
        if(mana < manaPointsUI.Length)
        {
            manaPointsUI[mana].GetComponent<Image>().color = Color.white;
            mana ++;
        }
    }

    private void ManaUse()
    {
        if(mana > 0)
        {
            manaPointsUI[mana].GetComponent<Image>().color = Color.black;
            mana --;
        }
    }


}
