using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractPointBehaviour : MonoBehaviour
{
    public AttractorTrackBehaviour atb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            atb.attractPoint = gameObject;
        }
    }
}
