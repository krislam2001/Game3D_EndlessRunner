using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Segment;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionSFX;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject FadeOut;

    void Start()
    {
        // Segment + Player
        Segment = this.gameObject.transform.parent.gameObject;
        Player = GameObject.FindGameObjectWithTag("Player");

        // Player anim
        playerAnim = Player.gameObject.transform.GetChild(1).gameObject;

        // CollisionSFX
        GameObject AudioMaster = GameObject.FindGameObjectWithTag("audio");
        GameObject SFX = AudioMaster.gameObject.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
        collisionSFX = SFX.GetComponent<AudioSource>();

        // Main camera
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");

        // Fade out
        GameObject canvas = GameObject.FindGameObjectWithTag("canvas");
        FadeOut = canvas.gameObject.transform.GetChild(3).gameObject;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "barrier")
        {
            StartCoroutine(CollisionEnd());
        }
    }

    IEnumerator CollisionEnd()
    {
        MasterInfo.isGameOver = true;
        collisionSFX.Play();
        Player.GetComponent<PlayerMovement>().enabled = false;
        Segment.GetComponent<SegmentMovement>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        mainCamera.GetComponent<Animator>().Play("CollisionCam");
        yield return new WaitForSeconds(3);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }
}
