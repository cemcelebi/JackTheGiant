using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    public float speed = 8f; //because this and the following variable are public, they are reachable from unity's inspector
    public float maxVelocity = 4f;
   // [SerializeField] //this line makes the following private variables readable from unity's inspector.
    private Rigidbody2D myBody; //this and the following private variables are not reachable from unity's inspector, because they are private.
    private Animator anim; 
    void Awake() // is the first function which is started when pressed the play button.
    {
        myBody = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> ();

    }
    void Start () {
	
	}
	
	// Update is called once per frame
	/*void Update () { //Update function is called every FPS. 
	
	}*/
    void FixedUpdate() { //Fixed;Update function is called every 3-4 FPS. (goto physics function.)
        PlayerMoveKeyboard();
    }
    void PlayerMoveKeyboard()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);
        float h = Input.GetAxisRaw("Horizontal");// this function returns -1 if "a" or "<-" keys are pressed, or 1 if "d" or "->" keys are pressed.
        if (h > 0) {
            //going to the -> direction.
            forceX = speed;
        }
        else if (h < 0) {
            if (vel<maxVelocity) {
                forceX = -speed;
            }
        }
        myBody.AddForce(new Vector2(forceX, 0));
    }
}
