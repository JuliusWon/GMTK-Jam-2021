using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public bool isCoward;
	public bool isScared;
	[SerializeField]
	LayerMask enemyLayer;
	[SerializeField]
	float cowardiceRange;
	CharacterController controller;
	public bool isLeader;
	private Rigidbody rb;

	SimpleRope rope;
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rope = GetComponent<SimpleRope>();
		controller = GetComponent<CharacterController>();
	}
	public float speed = 1000;
	void Update(){
		if (isScared)
		{
			//rb.velocity = Vector3.forward * (speed * 5000 * Time.deltaTime);
			rb.AddRelativeForce(Vector3.forward*(speed*50*Time.deltaTime),ForceMode.VelocityChange);
			Debug.Log(Vector3.forward*(speed * Time.deltaTime));
		}
		if(isLeader){
			Vector3 velocity = Vector3.zero;
			velocity.z = Input.GetAxis("Vertical")*Time.deltaTime*speed;
			velocity.x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
			rb.AddForce(velocity,ForceMode.VelocityChange);
		}else{
			if(isCoward){
				if(Physics.CheckSphere(transform.position,cowardiceRange,enemyLayer))
				{
					if (!isScared)
					{
						transform.LookAt(tempChooseRandomPlace(20));
					}

					isScared = true;
					Invoke("UnPanic", 100f);	
				}
			}
		}
	}
	void UnPanic()
	{
		isScared = false;
	}

	Vector3 tempChooseRandomPlace(float range)
	{
		return new Vector3(Random.Range(-range,range)+transform.position.x,0,Random.Range(-range,range)+transform.position.x);
	}
}
