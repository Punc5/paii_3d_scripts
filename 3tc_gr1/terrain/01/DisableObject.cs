using UnityEngine;

public class DisableObject : MonoBehaviour
{
    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}