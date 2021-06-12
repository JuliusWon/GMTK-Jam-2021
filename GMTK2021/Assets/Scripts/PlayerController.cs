using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	LayerMask enemyLayer;
	[SerializeField]
	float cowardiceRange;
	CharacterController controller;
	public bool isLeader;

	SimpleRope rope;
	void Start(){
		rope = GetComponent<SimpleRope>();
		controller = GetComponent<CharacterController>();
	}
	void Update(){
		if(isLeader){
			Vector3 velocity = Vector3.zero;
			velocity.z = Input.GetAxis("Vertical");
			velocity.x = Input.GetAxis("Horizontal");
			controller.Move(velocity);
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
	void UnPanic(){

		GameObject.Find("brother_main").GetComponent<SimpleRope>().isLeader = true;
		rope.isLeader = false;
	}
}
