using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField] AudioSource BGM;
    [SerializeField] AudioSource SFX_coin;
    [SerializeField] AudioSource SFX_collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BGM.volume = PlayerPrefs.GetFloat("Music volume");
        SFX_coin.volume = PlayerPrefs.GetFloat("Sound volume");
        SFX_collision.volume = PlayerPrefs.GetFloat("Sound volume");
    }
}
