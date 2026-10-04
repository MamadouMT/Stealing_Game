using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money = 100;
    public Text moneyText;

    void Start()
    {
        UpdateMoney();
    }

    public void AddMoney(int amount)
    {
        money += amount;
        UpdateMoney();
    }

    public bool SpendMoney(int amount)
    {
        if (money >= amount)
        {
            money -= amount;
            UpdateMoney();
            return true;
        }

        return false;
    }

    void UpdateMoney()
    {
        moneyText.text = "Money: $" + money;
    }
}