using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ARUserInputManager : MonoBehaviour {
    public GameObject airPlane;
    private GameObject lastPlaneReference;

    /*
     * Per frame, check user gaze from smartphone camera.
     * If collision found with objects, check if objects are of interest.
     * Store reference to prior planes to properly orientate virtual objects.
     */ 
    void Update() {
        // Do a raycast into the world based on the user's
        // head position and orientation.
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;
        // If raycast hits any object.
        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo)) {
            // Check object collision by tag, alternatively check by name.
            if (hitInfo.collider.gameObject.CompareTag("AR Plane") ||
                (hitInfo.collider.gameObject.name.Equals("AR Feathered Plane"))) {
                // User has moved PoV to a new plane, recalibrate rotation.
                if (lastPlaneReference != hitInfo.collider.gameObject || lastPlaneReference == null) {
                    lastPlaneReference = hitInfo.collider.gameObject;   // Assign reference to plane
                    airPlane.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
                }
                airPlane.transform.position = new Vector3(hitInfo.point.x,
                                                      hitInfo.point.y,
                                                      hitInfo.point.z);
                // Rotate the AirPlane to hug the surface of the hologram.
                CheckRotation();
            }
        }
    }

    /*
     * Check user input to alter y axis rotation (aka yaw of plane)
     * Alter changed in rotation based on section of screen touched.
     */ 
    public void CheckRotation() {
        // In current frame, check for first user touch.
        if (Input.GetTouch(0).phase == TouchPhase.Stationary) {
            Vector3 currentRotation = airPlane.transform.localEulerAngles;
            // If user is holding left side of screen
            if (Input.GetTouch(0).position.x < (Screen.width / 2)) {
               currentRotation.y += 5f;
            } else {    // User is holding right side of the screen.
                currentRotation.y -= 5f;
            }
            // Assign changed rotation based on user drag.
            airPlane.transform.localEulerAngles = currentRotation;
        }
    }

}
