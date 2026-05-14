using UnityEngine;

public class CastleHealth : Health
{
    [SerializeField] GameObject[] heartUI;

    private void Start()
    {
        if(health != heartUI.Length)
            Debug.Log("Unmatching healthpoints and UI");
    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if(health>= 0 && health < heartUI.Length)
            heartUI[((int) health)].GetComponent<HealthUI>().HealthUIUpdate();

    }

}
