using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInvocationDisplay : MonoBehaviour
{
    [SerializeField] GameObject[] elementsUI;
    [SerializeField] GameObject sprite;
    public void setDetails (float[] details, Sprite icon) //Mana, Damage, Cooldown, Sprite
    {
        if(details.Length == elementsUI.Length && icon != null && elementsUI != null)
        {
            for(int i = 0; i < details.Length; i++)
            {
                string text = details[i].ToString();
                elementsUI[i].GetComponent<TextMeshProUGUI>().SetText(text);
            }
            
            sprite.GetComponent<Image>().sprite = icon;
        }
        else
            Debug.Log("ERROR: setDetails - details and elements not matching or sprite missing");


    }



}
