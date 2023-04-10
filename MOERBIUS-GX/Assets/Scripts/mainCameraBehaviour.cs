using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCameraBehaviour : MonoBehaviour
{
    public Vector3 cameraNewPos;
    public Vector3 cameraNewRot;

    public GameObject player;

    public Vector3 playerPositionOffset;
    public Vector3 playerRotationOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraNewPos = new Vector3(player.transform.position.x + playerPositionOffset.x, player.transform.position.y + playerPositionOffset.y, player.transform.position.z + playerPositionOffset.z);

        cameraNewRot = new Vector3(player.transform.rotation.x + playerRotationOffset.x, player.transform.rotation.y + playerRotationOffset.y, player.transform.rotation.z + playerRotationOffset.z);

        transform.position = cameraNewPos;
        transform.rotation = Quaternion.Euler(cameraNewRot);
    }
}
