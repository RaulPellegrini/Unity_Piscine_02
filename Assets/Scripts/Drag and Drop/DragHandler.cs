using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject dragon;
    private GameObject ghostDragon;
    private float mp;
    private float mpCost;
    private float cdTime;
    private bool inCd = false;
    private bool beingDragged = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void confirmSummon(Vector3 position)
    {
        Debug.Log(position);
        Instantiate(dragon, new Vector3 (position.x, position.y, 0), quaternion.identity);
        inCd = true;
        StartCoroutine(ColdownCounter());
        //Send news to mana
    }


    public void SetDragonDragHandler(GameObject dragonPrefab)
    {
        dragon = dragonPrefab;
        TurretDetails turretDetails = dragon.GetComponent<TurretDetails>();
        mpCost = turretDetails.manaCost;
        cdTime = turretDetails.summonCooldown;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //check if there's enough mana
        //I need a mana interface to disconect this code from mana, according to best practice
        //Set highligh in mana
        Debug.Log("Mouse in");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse out");
        //remove manahighligh
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        //Setup phase
        mp = GetComponentInParent<ManaUI>().mana;
        if(mp >= mpCost && !inCd)
        {
            beingDragged = true;
            ghostDragon = new GameObject("Ghost Dragon");
            ghostDragon.AddComponent<SpriteRenderer>().sprite = dragon.GetComponent<SpriteRenderer>().sprite;
            ghostDragon.GetComponent<SpriteRenderer>().sortingOrder = 10;
            ghostDragon.transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
            //Reduce mana;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //UpdatePhase
        if(beingDragged)
        {
            Vector3 screenPosition = new Vector3(eventData.position.x, eventData.position.y, -Camera.main.transform.position.z);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(screenPosition);
            mousePos.z = 0;
            ghostDragon.transform.position = mousePos;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {  
        Destroy(ghostDragon);
        beingDragged = false;
    }

    IEnumerator ColdownCounter()
    {

        yield return new WaitForSeconds(cdTime);
        inCd = false;

    }


}
