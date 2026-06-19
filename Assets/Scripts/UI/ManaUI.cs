using UnityEngine;
using UnityEngine.UI;
public class ManaUI : MonoBehaviour
{
    [SerializeField] GameObject[] manaPointsUI;
    public int mana = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        EnemyDestroyed.ManaReward += ManaLisener;
        DragHandler.ManaCost += ManaUse;
        ManaStart(mana);
    }


    void OnDestroy()
    {
        EnemyDestroyed.ManaReward -= ManaLisener;
        DragHandler.ManaCost -= ManaUse;
    }

    private void ManaLisener(int manaGained)
    {
        //Debug.Log("I heard you!");
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

    private void ManaUse(float manaSpent)
    {
        Debug.Log(manaSpent);
        
        for(float i = manaSpent; i > 0; i--)
        {
            mana --;            
            manaPointsUI[mana].GetComponent<Image>().color = Color.black;
        }
    }
    

    private void ManaStart(int startingMana)
    {
        for(int i = 0; i < startingMana; i++)
            manaPointsUI[i].GetComponent<Image>().color = Color.white;

    }


    // public void manaHighLight(bool activate) //to be implemented
    // {
        
    // }

}
