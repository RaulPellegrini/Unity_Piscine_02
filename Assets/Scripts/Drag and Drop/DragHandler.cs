using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] GameObject dragonPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void SetDragon(GameObject Prefab)
    {
        dragonPrefab = Prefab;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Setup phase
    }

    public void OnDrag(PointerEventData eventData)
    {
        //UpdatePhase
        //ghost.Object.Transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //resolve phase
    }
}
