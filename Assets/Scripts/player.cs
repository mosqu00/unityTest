using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	private const float speed = 1.0f;
	[SerializeField] private GameObject spear = null;
	private Vector3 playerStartPos = new Vector3(0.0f, 0.0f, 0.0f );
	private Vector3 spearStartPos = new Vector3(0.0f, 0.0f, 0.0f );

	private Vector3 mouse;
	private Vector3 target;

	private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
		playerStartPos = this.transform.position;
		spearStartPos = spear.transform.position;

		body = this.GetComponent<Rigidbody>();
		body.useGravity = false;
	}

    // Update is called once per frame
    void Update()
    {
		mouse = Input.mousePosition;
		target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 0.5f));
		this.transform.position = target;

		if (Input.GetMouseButton(1))
		{
			spear.transform.position += transform.forward * Time.deltaTime;
		}
		else if (spear.transform.position.z >= spearStartPos.z) 
        {
			spear.transform.position -= transform.forward * Time.deltaTime;
		}
	}

    private void OnCollisionEnter(Collision collision)
    {
		if (collision.gameObject.name == "Brush")
		{
			body.useGravity = true;
			Destroy(this);
		}
    }
}
