using UnityEngine;
using UnityEngine.UI;

public class SettingMenuControl : MonoBehaviour
{
    public Slider musicSlider;
    public Slider soundSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!PlayerPrefs.HasKey("Music volume"))
        {
            PlayerPrefs.SetFloat("Music volume", 0.3f);
            musicSlider.value = 0.3f;
        }
        else
        {
            musicSlider.value = PlayerPrefs.GetFloat("Music volume");
        }

        if (!PlayerPrefs.HasKey("Sound volume"))
        {
            PlayerPrefs.SetFloat("Sound volume", 0.5f);
            soundSlider.value = 0.3f;
        }
        else
        {
            soundSlider.value = PlayerPrefs.GetFloat("Sound volume");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMusicVolume()
    {
        float volume = musicSlider.value;
        PlayerPrefs.SetFloat("Music volume", volume);
    }

    public void UpdateSoundVolume()
    {
        float volume = soundSlider.value;
        PlayerPrefs.SetFloat("Sound volume", volume);
    }
}
