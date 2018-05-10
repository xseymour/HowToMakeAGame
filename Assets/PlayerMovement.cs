using UnityEngine;

namespace Assets
{

	public class PlayerMovement : MonoBehaviour
	{
		public Rigidbody rb;
		public float forwardForce	= 1000f;
		public float sidewaysForce	= 600f;

		/*	
		 * Update is called once per frame
		 * Use FixedUpdate for anything involving unity physics update (forces, velocities, etc.)
		 * Makes things smoother during collisons
		 * Todo Fixed Update not good for one off events such as jumping. Fixed update does not run as often as update method,
		 * Todo so input lag is introduced. Correct method is to store input in update method, then use variables in fixed update for physics
		 */
		public void FixedUpdate()
		{
			float delta = Time.deltaTime;
			// Todo Error: This MAY add a force of 200 every frame, resulting in different framerates causing different forces
			//			rb.AddForce(0, 0, 200);
			// I suppose this might be better, so as to get a certain force per second
			rb.AddForce(0, 0, forwardForce * delta);		

			if (Input.GetKey("d") || Input.GetKey("right"))
			{
				rb.AddForce(sidewaysForce * delta, 0, 0, ForceMode.VelocityChange);
			}

			if (Input.GetKey("a") || Input.GetKey("left"))
			{
				rb.AddForce(-sidewaysForce * delta, 0, 0, ForceMode.VelocityChange);
			}

		}

	}
}
