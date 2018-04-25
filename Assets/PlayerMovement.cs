using UnityEngine;

namespace Assets
{

	public class PlayerMovement : MonoBehaviour
	{

		//Task 1: Disable Gravity for our player object
		public Rigidbody Rb;





		// Use this for initialization
		public void Start()
		{
//			Debug.Log("Hello World!");
//			Rb.useGravity = false;
//			Rb.AddForce(0, 200, 0);

		}

		// Update is called once per frame
		public void Update()
		{

		}


		/*
		 * Update is called once per frame
		 * Use FixedUpdate for anything involving unity physics update (forces, velocities, etc.)
		 * Makes things smoother during collisons
		 */
		public void FixedUpdate()
		{
			// Todo Error: This MAY add a force of 200 every frame, resulting in different framerates causing different forces
			//			Rb.AddForce(0, 0, 200);
			// I suppose this might be better, so as to get a certain force per second
			Rb.AddForce(0, 0, 2000 * Time.deltaTime);
		}

	}
}
