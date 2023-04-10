using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractorTrackBehaviour : MonoBehaviour
{
    public float graivty;

    public GameObject attractPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attract(Transform playerTr)
    {
        Vector3 gravityUp = (playerTr.position - attractPoint.transform.position).normalized;
        Vector3 playerTrUp = playerTr.forward;

        playerTr.GetComponent<Rigidbody>().AddForce(gravityUp * graivty);

       // Quaternion playerRotation = Quaternion.FromToRotation(playerTrUp, gravityUp) * playerTr.rotation;
       // playerTr.rotation = Quaternion.Slerp(playerTr.rotation, playerRotation, 50 * Time.deltaTime);
    }
}
