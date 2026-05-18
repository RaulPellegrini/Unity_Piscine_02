using UnityEngine;

public class PlacementCell : MonoBehaviour
{
    [SerializeField] public bool cellAvailable = true;

    public void PlaceInTheCell()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        cellAvailable = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
