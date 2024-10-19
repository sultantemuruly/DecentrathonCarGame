using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPage;
    [SerializeField] private GameObject difficultyPage;
    private int difficulty;
    private DifficultyManager difficultyManager;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Play()
    {
        mainPage.SetActive(false);
        difficultyPage.SetActive(true);
    }

    public void Quit()
    {
        mainPage.SetActive(false);
        difficultyPage.SetActive(true);
    }

    public void DifficultyButton(string difficultyText)
    {
        if (difficultyText == "Easy")
        {
            difficulty = 0;
        }
        else if (difficultyText == "Medium")
        {
            difficulty = 1;
        }
        else
        {
            difficulty = 2;
        }

        SceneManager.LoadScene(1);

        Invoke("SetDifficulty", 0.1f);
    }

    private void SetDifficulty()
    {
        difficultyManager = GameObject.Find("Game_Manager").GetComponent<DifficultyManager>();
        Debug.Log("YO!");
        Debug.Log(difficulty);

        if (difficultyManager != null)
        {
            difficultyManager.selectedDifficulties = difficulty;
            Debug.Log("YOOOO!");
            Debug.Log(difficulty);
        }
    }
}
