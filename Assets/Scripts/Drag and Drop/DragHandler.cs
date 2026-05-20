using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private GameObject dragon;
    private float mp;
    private float mpCost;
    private float cdTime;
    private bool inCd = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void SetDragonDragHandler(GameObject dragonPrefab)
    {
        dragon = dragonPrefab;
        TurretDetails turretDetails = dragon.GetComponent<TurretDetails>();
        mpCost = turretDetails.manaCost;
        cdTime = turretDetails.summonCooldown;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        mp = GetComponentInParent<ManaUI>().mana;
        if(mp > mpCost && !inCd)
        {
            
        }
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
