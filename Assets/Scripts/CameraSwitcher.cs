using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{

    [SerializeField]
    private InputAction action;
    [SerializeField]
    private CinemachineVirtualCamera vcam1;
    [SerializeField]
    private CinemachineVirtualCamera vcam2;

    private bool hoodCam;

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    void Start()
    {
        action.performed += _ => cameraSwitch();
    }

    private void cameraSwitch()
    {
        if (hoodCam)
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }
        else
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        hoodCam = !hoodCam;
    }
}
