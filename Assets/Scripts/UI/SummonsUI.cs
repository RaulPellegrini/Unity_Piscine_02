using UnityEngine;

public class SummonsUI : MonoBehaviour
{
    [SerializeField] GameObject[] dragonsPrefabs;
    [SerializeField] GameObject[] bullets;
    [SerializeField] GameObject[] invocationsUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(dragonsPrefabs.Length != invocationsUI.Length && dragonsPrefabs != bullets)
            Debug.Log("Invocations prefabs does not match with UI");

        for(int i = 0; i < dragonsPrefabs.Length; i++)
        {

            TurretDetails turretDetails = dragonsPrefabs[i].GetComponent<TurretDetails>();
            float manaCost = turretDetails.manaCost;
            float cooldown = turretDetails.summonCooldown;
            float damage = bullets[i].GetComponent<Damage>().damage;
            Sprite image = dragonsPrefabs[i].GetComponent<SpriteRenderer>().sprite;

            float[] details = {manaCost, damage, cooldown};
            invocationsUI[i].GetComponent<UIInvocationDisplay>().setDetails(details, image);
        }

    }

}
