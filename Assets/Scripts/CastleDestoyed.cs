using UnityEngine;

public class CastleDestoyed : MonoBehaviour
{
    void OnDestroy()
    {
        EndGame endGame = GetComponentInParent<EndGame>();
            if(endGame != null)
                endGame.GameOver();
    }
}
