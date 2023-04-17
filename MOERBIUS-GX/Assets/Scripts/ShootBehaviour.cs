using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shootPoint;
    public Quaternion bulletOffset;
    public bool pilk;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(bullet, shootPoint.transform.position, transform.rotation * bulletOffset);
        }
    }
}
