using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzsawController : MonoBehaviour
{
    // An animator variable used to toggle the bool paramater used for the Buzzsaw animator
    Animator playerDeathBool;

    public LevelManager levelManagerRef;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the animator component from itself; the buzzsaw gameobject
        playerDeathBool = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is hit!");
            levelManagerRef.SetPlayerSpawnPoint();
        }
    }
}
