using UnityEngine;

public class DragHandler : MonoBehaviour
{
    [SerializeField] GameObject dragonPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void SetDragon(GameObject Prefab)
    {
        dragonPrefab = Prefab;
    }
}
