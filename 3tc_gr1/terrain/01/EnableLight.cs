using UnityEngine;

public class EnableLight : MonoBehaviour
{
    public Light lightSource; // Przypisz tutaj �r�d�o �wiat�a, kt�re ma si� w��cza�
    public string playerTag = "Player"; // Tag gracza

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag)) // Je�li gracz wszed� do strefy
        {
            lightSource.enabled = true; // W��cz �wiat�o
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag)) // Je�li gracz opu�ci� stref�
        {
            lightSource.enabled = false; // Wy��cz �wiat�o
        }
    }
}
