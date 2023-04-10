using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttracteeBehaviour : MonoBehaviour
{
    public AttractorTrackBehaviour atb;
    private Transform playerT;

    // Start is called before the first frame update
    void Start()
    {
        playerT = transform;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        atb.Attract(playerT);
    }
}
