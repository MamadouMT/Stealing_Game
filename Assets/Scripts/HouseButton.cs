using UnityEngine;

public class HouseButton : MonoBehaviour
{
    public GameObject housePrefab;
    public Transform spawnPoint;

    public int cost = 100;

    private bool purchased = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !purchased)
        {
            Money money = FindFirstObjectByType<Money>();

            if (money != null)
            {
                if (money.SpendMoney(cost))
                {
                    Instantiate(housePrefab, spawnPoint.position, spawnPoint.rotation);
                    purchased = true;
                    gameObject.SetActive(false);
                    Debug.Log("House purchased!");
                }
                else
                {
                    Debug.Log("Not enough money!");
                }
            }
        }
    }
}