using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelZoomIn : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float maxDistance = -5, minDistance = -20;

    private void Start() {
        transform.position = new Vector3(0, TreeManager.Instance.maxHeight * 0.6f, (maxDistance + minDistance)/2);
    }

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel") * speed;

        if (scroll != 0)
        {
            if (scroll < 0 && transform.position.z + scroll < minDistance) return;
            if (scroll > 0 && transform.position.z + scroll > maxDistance) return;
            
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + scroll);
        }
    }
}
