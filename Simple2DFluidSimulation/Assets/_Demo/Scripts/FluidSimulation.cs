using UnityEngine;
using UnityEngine.Rendering;

public class FluidSimulation : MonoBehaviour
{
    public VolumeProfile volume;

    private float velocityPressed;
    private float densityPressed;
    private Vector2 currentMousePosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            velocityPressed = 1f;
        }
        if (Input.GetMouseButtonUp(0))
        {
            velocityPressed = 0f;
        }

        if (Input.GetMouseButtonDown(1))
        {
            densityPressed = 1f;
        }
        if (Input.GetMouseButtonUp(1))
        {
            densityPressed = 0f;
        }

        currentMousePosition = Input.mousePosition;

        volume.TryGet(out FluidSimulationVolume fluid);
        fluid.velocityPressed.SetValue(new FloatParameter(velocityPressed));
        fluid.densityPressed.SetValue(new FloatParameter(densityPressed));
        fluid.currentMousePosition.SetValue(new Vector2Parameter(currentMousePosition));
    }
}
