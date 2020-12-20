/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";


    private float Horizontal;
    private float verticalInput;
    private float steerAngle;
    private float currentBreakForce;
    private bool isBreaking;

    [SerializeField] private float motorforce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider FrontLeftWheelCollider;
    [SerializeField] private WheelCollider FrontRightWheelCollider;
    [SerializeField] private WheelCollider BackLeftWheelCollider;
    [SerializeField] private WheelCollider BackRightWheelCollider;

    [SerializeField] private Transform FrontLeftWheelTransform;
    [SerializeField] private Transform FrontRightWheelTransform;
    [SerializeField] private Transform BackLeftWheelTranform;
    [SerializeField] private Transform BackRightWheelTransform;


    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }
    private void HandleMotor()
    {
        FrontLeftWheelCollider.motorTorque = verticalInput * motorforce;
        FrontRightWheelCollider.motorTorque = verticalInput * motorforce;
        currentBreakForce = isBreaking ? breakForce : 0f;
        if (isBreaking)
        {
            ApplyBreaking();
        }
    }
    private void ApplyBreaking()
    {
        FrontLeftWheelCollider.breakTorque = currentBreakForce;
        FrontRightWheelCollider.breakTorque = currentBreakForce;
        BackLeftWheelCollider.breakTorque = currentBreakForce;
        BackRightWheelCollider.breakTorque = currentBreakForce;
    }


    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(Vertical);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        FrontLeftWheelCollider.steerAngle = currentSteerAngle;
        FrontRightWheelCollider.steerAngle = currentSteerAngle;
    }
    private void UpdateWheels()
    {
        UpdateSingleWheel(FrontLeftWheelCollider, FrontLeftWheelTransform);
        UpdateSingleWheel(FrontRightWheelCollider, FrontRightWheelTransform);
        UpdateSingleWheel(BackLeftWheelCollider, BackLeftWheelTransform);
        UpdateSingleWheel(BackRightWheelCollider, BackRightWheelTransform);
    }
    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}*/
