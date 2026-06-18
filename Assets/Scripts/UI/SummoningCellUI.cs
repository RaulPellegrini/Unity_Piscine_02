using UnityEngine;
using UnityEngine.EventSystems;

public class SummoningCell : MonoBehaviour, IDropHandler
{
    public bool ocupied = false;
    private RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    public void OnDrop(PointerEventData eventData)
    {        
        if(!ocupied)
        {
        //Getting coordenates in the camera and converting to coordenates in the map
        Vector3 screenPosition = rt.position;
        screenPosition.z = -Camera.main.transform.position.z;
        screenPosition = Camera.main.ScreenToWorldPoint(screenPosition);


        //calling Dragon Handler to summon the dragon
        eventData.pointerDrag.GetComponent<DragHandler>().confirmSummon(screenPosition);
        ocupied = true; 
        }
    }
}
