using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private bool isScared;
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
		if(isLeader){
			Vector3 velocity = Vector3.zero;
			velocity.z = Input.GetAxis("Vertical")*Time.deltaTime*speed;
			velocity.x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
			rb.AddForce(velocity,ForceMode.VelocityChange);
		}else{
			if(rope.isCoward){
				if(Physics.CheckSphere(transform.position,cowardiceRange,enemyLayer)){
					GameObject.Find("brother_main").GetComponent<SimpleRope>().isLeader = false;
					rope.isLeader = true;
					Invoke("UnPanic", 10f);	
				}
			}
		}
	}
	void UnPanic()
	{
		isScared = false;
		GameObject.Find("brother_main").GetComponent<SimpleRope>().isLeader = true;
		rope.isLeader = false;
	}
}
