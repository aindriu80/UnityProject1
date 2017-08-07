using UnityEngine;
using UnityEngine.UI;


public class TestScript : MonoBehaviour {
        BoxCollider boxCol;
        public Text text;
        public float timer;
        

        // Use this for initialization
        void Start ()
        {

            text.text = timer.ToString();
            boxCol = GetComponent<BoxCollider>();
            boxCol.isTrigger = false;
        }
	
        // Update is called once per frame
        void Update ()
        {
            if (timer >= 0)
            {
                timer -= Time.deltaTime;
                text.text = timer.ToString("#.00");
            }
            else
            {
                text.text = "0.0";
            }

        }
    }

