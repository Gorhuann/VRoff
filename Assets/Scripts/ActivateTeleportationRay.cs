using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{

    public GameObject rightTeleportation;

    public InputActionProperty rightActivate;

    public XRRayInteractor rightRay;

    // Update is called once per frame
    void Update()
    {
        // bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);


        rightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
