using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
float time = 20;
public class gra : MonoBehaviour
{
    int kulka = 4;
    public GameObject KoniecPanel;
    public GameObject GraPanel;
    public TMP_Text tekstKulki;
    public TMP_Text czasKulki;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        KoniecPanel.SetActive(false);
        GraPanel.SetActive(false);
        tekstKulki.text = kulki.ToString;
    }
    // Update is called once per frame
    void Update()
    {
        czas -= Time.deltaTime;
        tekstCzas.tekst = Mathf.Round(czas).ToString();
        if(czas <= 0)
        {
            Time.timeScale = 0;
            KoniecPanel.SetActive(true);
        }
    }
    public void StartGry()
    {
        Time.timeScale = 1;
        GraPanel.SetActive(true);
    }
    public void DodajPunkt()
    {
        kulka--;
        tekstKulki.text = kulki.ToString();
        if (kulki == 4)
        {
            Debug.Log("Koniec Gry");
            KoniecPanel.SetActive(true);
        }
    }
}