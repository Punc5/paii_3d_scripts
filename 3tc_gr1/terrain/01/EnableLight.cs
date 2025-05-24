using UnityEngine;

public class EnableLight : MonoBehaviour
{
    public Light lightSource; // Przypisz tutaj Ÿród³o œwiat³a, które ma siê w³¹czaæ
    public string playerTag = "Player"; // Tag gracza

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag)) // Jeœli gracz wszed³ do strefy
        {
            lightSource.enabled = true; // W³¹cz œwiat³o
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag)) // Jeœli gracz opuœci³ strefê
        {
            lightSource.enabled = false; // Wy³¹cz œwiat³o
        }
    }
}
