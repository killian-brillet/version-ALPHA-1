using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float _cameraSpeed = 2.0f;
    private float cameraSpeed { get { return _cameraSpeed; } }

    private Transform cameraTransform { get; set; } = null;

    public float _borderSize = 10f;
    private float borderSize { get { return _borderSize; } }

    private const float deadZone = 0.5f;

    private Vector3 mouseLastposition = Vector3.zero;
    private float scope;
    private bool mustGo;
    public gameManager Pause;

    private void Start()
    {
        cameraTransform = GetComponent<Transform>();
        mouseLastposition = Input.mousePosition;
    }

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 direction = Vector3.zero;


        // Pour navigation sur PC  et Unity uniquement
        // ------------------------------------------------------------------------------------------------------------------------------- //
        if (mousePos.x <= borderSize || Input.GetAxis("Horizontal") < -deadZone)
        {
            direction += Vector3.left;
        }
        else if (mousePos.x >= Screen.width - borderSize || Input.GetAxis("Horizontal") > deadZone)
        {
            direction += Vector3.right;
        }

        if (mousePos.y <= borderSize || Input.GetAxis("Vertical") < -deadZone)
        {
            direction += Vector3.back;
        }
        else if (mousePos.y >= Screen.height - borderSize || Input.GetAxis("Vertical") > deadZone)
        {
            direction += Vector3.forward;
        }

        direction.Normalize();
        cameraTransform.position += direction * Time.deltaTime * cameraSpeed;
        // ------------------------------------------------------------------------------------------------------------------------------- //
        // Pour navigation sur PC et Unity uniquement

        if (Pause.isPaused == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                scope += Vector3.Distance(Input.mousePosition, mouseLastposition);
                mouseLastposition = Input.mousePosition;
                if (scope >= 100)
                {
                    mustGo = true;
                }
            };
            if (Input.GetMouseButtonUp(0))
            {
                scope = 0;
                mustGo = false;
            }

            if (mustGo == true)
            {
                var Translated = -(Input.mousePosition - mouseLastposition).normalized;
                transform.Translate((Vector3.right * Translated.x + Vector3.forward * Translated.y) * 3);
            }
        }
        else
        {
            return;
        }
    }
}
