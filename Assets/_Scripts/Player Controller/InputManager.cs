using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //this is our singleton
    public static InputManager instance;

    //reference to an instance of Controls 
    private Controls controls;

    // Input Data
    public Vector2 move;

	private void Awake()
	{
        if (instance == null)
        {
            //if instance is null, make this the instance
            instance = this;
        }else
        {
            //if instance if not null, destroy this
            Destroy(instance);
        }

        //Instantiate controls
        controls = new Controls();

        //enable controls
        controls.Enable();

	}

	// Start is called before the first frame update
	void Start()
    {
        // subscribe to the "Move" event of our Controls.

        // Lambda Functions! 

        // (*parameters*) => *code to execute* 
        controls.LocalMotion.Move.performed += obj => move = obj.ReadValue<Vector2>();

    }

	private void OnDisable()
	{
        //if the input manager is disabled, disable controls as well
        controls.Disable();
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
