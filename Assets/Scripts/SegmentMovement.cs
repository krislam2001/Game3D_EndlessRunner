using UnityEngine;

public class SegmentMovement : MonoBehaviour
{
    public float segmentSpeed;

    void Start()
    {
        segmentSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -segmentSpeed, Space.World);

        if (MasterInfo.isGameOver)
        {
            segmentSpeed = 0f;
        }

        if (this.gameObject.transform.position.z < -60)
        {
            Destroy(this.gameObject);
        }
    }
}
