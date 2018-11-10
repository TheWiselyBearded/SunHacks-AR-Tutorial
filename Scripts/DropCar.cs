using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCar : MonoBehaviour {
    public GameObject convertibleCarPrefab;
    public GameObject carExplosionPrefab;
    private GameObject airPlane;

	/*
	 * At beginning of lifecycle, grab reference to the airplane/user gaze 
	 * object to perform acitons on it per frame in Update.
	 */
	void Start () {
        airPlane = gameObject.GetComponent<ARUserInputManager>().airPlane;
	}
	
    /*
     * Per frame, check if user has tapped screen.
     * Instantiate a car prefab, and particle system explosion.
     * Have objects destroy themselves within 1 second.
     */ 
	void Update () {
        // In current frame, check for first user touch.
        if (Input.GetTouch(0).phase == TouchPhase.Began) {
            // Instantiate prefab.
            GameObject car = (GameObject)Instantiate(convertibleCarPrefab,
                                                      airPlane.transform.position,
                                                      airPlane.transform.localRotation);
            car.AddComponent<BoxCollider>();    // Add collider for detecting collisions.
            car.AddComponent<Rigidbody>();  // Add gravity so it falls
            Destroy(car, 0.7f); // Destroy game object after 1.5 seconds.
            // Instantiate particle system.
            GameObject carExplosion = Instantiate(carExplosionPrefab, car.transform.position, car.transform.rotation);
            carExplosion.GetComponent<ParticleSystem>().Play(); // Play explosion
            Destroy(carExplosion, 0.8f);  // Delete explosion instance.
        }
	}
}
