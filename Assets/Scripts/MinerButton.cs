using UnityEngine;

public class MinerButton : MonoBehaviour
{
    public GameObject minerPrefab;
    public Transform spawnPoint;

    public int cost = 50;

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
                    Instantiate(minerPrefab, spawnPoint.position, spawnPoint.rotation);

                    purchased = true;
                    gameObject.SetActive(false);

                    Debug.Log("Miner purchased!");
                }
                else
                {
                    Debug.Log("Not enough money!");
                }
            }
        }
    }
}