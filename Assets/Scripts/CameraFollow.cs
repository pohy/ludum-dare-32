using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float zoom = 1f;

    private Camera camera;

    private Vector3 positon;

	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
        positon.z = -1f;
	}
	
	// Update is called once per frame
	void Update () {
        positon.x = target.position.x;
        positon.y = target.position.y;
        camera.transform.position = positon;
        camera.orthographicSize = zoom;
	}
}
