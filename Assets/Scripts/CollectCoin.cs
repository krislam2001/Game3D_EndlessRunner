using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] AudioSource coinSFX;

    void Start()
    {
        GameObject AudioMaster = GameObject.FindGameObjectWithTag("audio");
        GameObject SFX = AudioMaster.gameObject.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
        coinSFX = SFX.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        coinSFX.Play();
        MasterInfo.coinCount++;
        this.gameObject.SetActive(false);
    }
}
