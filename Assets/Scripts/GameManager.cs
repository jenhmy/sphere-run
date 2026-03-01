using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectiblesNumbersText;
    private int collectiblesNumber;

    public TMP_Text totalCollectiblesNumbersText;
    private int totalCollectiblesNumber;

    public AudioSource audioSource;

    void Start()
    {
        totalCollectiblesNumber = transform.childCount; 
        totalCollectiblesNumbersText.text = totalCollectiblesNumber.ToString(); 

    }
    void Update()
    {
        if (transform.childCount <= 0)  
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
        }
    }
    public void AddCollectible()
    {
        audioSource.Play(); 
        collectiblesNumber++; 
        collectiblesNumbersText.text = collectiblesNumber.ToString(); 
    }

}
