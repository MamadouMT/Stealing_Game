using UnityEngine;

public class Miner : MonoBehaviour
{
    public int moneyPerMine = 5;
    public float miningTime = 3f;

    private Money money;

    void Start()
    {
        money = FindFirstObjectByType<Money>();

        InvokeRepeating("Mine", miningTime, miningTime);
    }

    void Mine()
    {
        if (money != null)
        {
            money.AddMoney(moneyPerMine);
        }
    }
}