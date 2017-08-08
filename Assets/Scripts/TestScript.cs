using System;
using UnityEngine;
using UnityEngine.UI;


public class TestScript : MonoBehaviour {
        
        public Text text;
        public bool toggle;
        string hour;
        string minute;
        string second;

        // Use this for initialization
        void Start ()
        {
            toggle = false;
        }
	
        // Update is called once per frame
        void Update ()
        {
        if(toggle)
            CreateClock();
        
        }

        public void CreateClock()
        {
            DateTime currentTime = DateTime.Now;
            hour = currentTime.Hour.ToString();
            minute = currentTime.Minute.ToString();
            second = currentTime.Second.ToString();
            text.text = hour + ":" + minute + ":" + second;
        }

        public void onToggle()
        {
            if (toggle) toggle = false;
            else toggle = true;
        }
    }

