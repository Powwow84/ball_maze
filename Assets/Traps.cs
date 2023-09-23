using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{  
    // Update is called once per frame
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("Player hit by trap!");

            // Find the floor object with the "Floor" tag
            GameObject floorObject = GameObject.FindGameObjectWithTag("floor");

            // Check if the floor object was found
            if (floorObject != null)
            {
                // Access the Rigidbody component of the floorObject and modify its properties
                Rigidbody floorRigidbody = floorObject.GetComponent<Rigidbody>();

                // Check if the floorRigidbody is not null
                if (floorRigidbody != null)
                {
                    // Modify the isKinematic property of the floorRigidbody
                    floorRigidbody.isKinematic = false;
                }
                else
                {
                    Debug.LogWarning("Floor object does not have a Rigidbody component.");
                }
            }
            else
            {
                Debug.LogWarning("No object with the 'Floor' tag found in the scene.");
            }
        }
    }
}
