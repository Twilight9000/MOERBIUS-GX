using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootBehaviour : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shootPoint;
    public Quaternion bulletOffset;
    public int bulletsAmount = 10;

    public PlayerInput pI;

    public InputAction shoot;

    // Start is called before the first frame update
    void Start()
    {
        pI = GetComponent<PlayerInput>();

        pI.currentActionMap.Enable();

        shoot = pI.currentActionMap.FindAction("Shoot");
        shoot.performed += ctx => shot();
    }

    public void shot()
    {
        if(bulletsAmount > 0)
        {
            Instantiate(bullet, shootPoint.transform.position, transform.rotation * bulletOffset);
            bulletsAmount--;
        }
    }
}
