using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    int bestCoinCount;
    public static int coinCount = 0;
    public static bool isGameOver = false;
    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject bestCoinDisplay;

    void Start()
    {
        if (!PlayerPrefs.HasKey("Best coin"))
        {
            PlayerPrefs.SetInt("Best coin", 0);
            bestCoinCount = 0;
        }
        else
        {
            bestCoinCount = PlayerPrefs.GetInt("Best coin");
        }
        coinCount = 0;
    }

    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "COINS: " + coinCount;

        if (coinCount > bestCoinCount)
        {
            bestCoinCount = coinCount;
            PlayerPrefs.SetInt("Best coin", bestCoinCount);
        }
        bestCoinDisplay.GetComponent<TMPro.TMP_Text>().text = "Best coins: " + bestCoinCount;
    }
}
