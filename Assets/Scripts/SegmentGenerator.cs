using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segments;

    [SerializeField] int zPos = 100;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "barrier")
        {
            segmentNum = Random.Range(0, 4);
            Instantiate(segments[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        }
    }
}
