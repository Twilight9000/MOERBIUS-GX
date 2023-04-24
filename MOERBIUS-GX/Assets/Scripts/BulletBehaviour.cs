//Original coder: ???
//Supplement coder: Jess

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the behaviors of the bullet prefabs. 
/// </summary>
public class BulletBehaviour : MonoBehaviour
{
    [Tooltip("The speed of the bullet moving forwards.")]
    public float speed;

    [Tooltip("The amount of time that elapses until the bullet destroys itself.")]
    public float deathTime = 3;

    /// <summary>
    /// Starts a coroutine that destroys this object after a set amount of time.
    /// </summary>
    void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

    /// <summary>
    /// Controls the bullet moving forwards.
    /// </summary>
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //This was replaced by the coroutine DestoryAfterTime
        //deathTime -= Time.deltaTime;
        //if (deathTime <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }

    /// <summary> 
    /// Happens when something is shot.
    /// </summary>
    /// <param name="collision">The item that is shot.</param>
    public void OnCollisionEnter(Collision collision)
    {
        //Destroys specified game objects when they are shot
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("DestructObj"))
        {
            Destroy(gameObject);
        }
        
        //The speed power up - speeds up the player when shot. Implementation of speeding up and the destruction of speed power up object is in SpeedPowerUp.
        if (collision.gameObject.CompareTag("SpeedPowerUp"))
        {
            collision.gameObject.GetComponent<SpeedPowerUp>().CollisionBehavior();
        }
       
    }

    /// <summary>
    /// Destroys the bullet after the specified time.
    /// </summary>
    /// <returns></returns>
    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(deathTime);

        Destroy(gameObject);

        yield return null;
    }



}
