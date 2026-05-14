using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public void HealthUIUpdate()
    {
        GetComponent<Image>().color = Color.black;
    }
}
