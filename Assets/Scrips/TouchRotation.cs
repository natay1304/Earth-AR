using UnityEngine;
using UnityEngine.EventSystems;

public class TouchRotation : MonoBehaviour, IDragHandler
{
    [SerializeField]
    private float _rotationSpeed = 110f;

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        float angle = -eventData.delta.x * _rotationSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, angle);
    }
}
