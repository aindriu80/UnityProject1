using UnityEngine;
using UnityEngine.UI;


public class TestScript : MonoBehaviour {
        public string name;
        BoxCollider boxCol;
    public Text text;
        

        // Use this for initialization
        void Start ()
        {
            text.text = name;
            boxCol = GetComponent<BoxCollider>();
            boxCol.isTrigger = false;
        }
	
        // Update is called once per frame
        void Update () {
            Debug.Log(name);

        }
    }

