using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject SettingUI;

    void Start()
    {
        MainMenuUI.SetActive(true);
        SettingUI.SetActive(false);
    }

    public void StartGame()
    {
        MasterInfo.isGameOver = false;
        SceneManager.LoadScene("MainGame");
    }

    public void Settings()
    {
        MainMenuUI.SetActive(false);
        SettingUI.SetActive(true);
    }

    public void Return()
    {
        MainMenuUI.SetActive(true);
        SettingUI.SetActive(false);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
