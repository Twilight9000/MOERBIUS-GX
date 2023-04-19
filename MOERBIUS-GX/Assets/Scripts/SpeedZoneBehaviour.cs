using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedZoneBehaviour : MonoBehaviour
{
    public float m_Speed;
    private float m_SpeedInitial;
    public float m_SpeedMod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpeedPlus")
        {
            m_Speed = m_SpeedInitial + m_SpeedMod;
        }

        if (collision.gameObject.tag == "SpeedMinus")
        {
            m_Speed = m_SpeedInitial - m_SpeedMod;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "SpeedPlus")
        {
            m_Speed = m_SpeedInitial;
        }

        if (collision.gameObject.tag == "SpeedMinus")
        {
            m_Speed = m_SpeedInitial;
        }
    }
}
