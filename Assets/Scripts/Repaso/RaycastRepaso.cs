using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RaycastRepaso : MonoBehaviour
{
    InputAction _clickInput;
    InputAction _positionInput;
    Vector2 _mousePosition;

    void Awake()
    {
        _clickInput = InputSystem.actions["Attack"];
        _positionInput = InputSystem.actions["MousePosition2"];
    }

    // Update is called once per frame
    void Update()
    {
        if(_clickInput.WasPressedThisFrame())
        {
            ShotRaycast();
        }
    }

    void ShotRaycast()
    {
        _mousePosition = _positionInput.ReadValue<Vector2>();

        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.collider.name == "objeto1")
            {
                SceneManager.LoadScene("Escena 1");
            }

            if(hit.collider.name == "objeto2")
            {
                
            }

            if(hit.collider.CompareTag("Tag1"))
            {
                
            }

            if(hit.collider.CompareTag("Tag2"))
            {
                
            }

            if(hit.collider.gameObject.layer == 3)
            {
                
            }

            if(hit.collider.gameObject.layer == 4)
            {
                
            }
        }
    }
}