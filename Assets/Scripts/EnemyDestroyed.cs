using System;
using UnityEngine;

public class EnemyDestroyed : MonoBehaviour
{
    [SerializeField] int manaToBeRewarded = 5;
    public static Action<int> ManaReward;

    void OnDestroy()
    {
        ManaReward?.Invoke(manaToBeRewarded);
    }

}
