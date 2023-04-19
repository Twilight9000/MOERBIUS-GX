using Cinemachine;
using UnityEngine;

public class SpeedCheckBehaviour : MonoBehaviour
{

    public CinemachineDollyCart cdc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /* public void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag == "SpeedPlus")
         {
             cdc.SpeedIncrease();
         }

         if (collision.gameObject.tag == "SpeedMinus")
         {
             cdc.SpeedDecrease();
         }
     }

     public void OnCollisionExit(Collision collision)
     {
         if (collision.gameObject.tag == "SpeedPlus" || (collision.gameObject.tag == "SpeedMinus"))
         {
             cdc.SpeedNormalized();
         }
     } */

  
}
