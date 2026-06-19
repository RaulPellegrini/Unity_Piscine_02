
using UnityEngine;

public class CellVisible : MonoBehaviour
{
    void Start()
    {
        DragHandler.ShowSummoningCells += ShowCells;
        gameObject.SetActive(false);
    }

    void OnDestroy()
    {
        DragHandler.ShowSummoningCells -= ShowCells;
    }

    private void ShowCells(bool show)
    {
        gameObject.SetActive(show);
    }

}
