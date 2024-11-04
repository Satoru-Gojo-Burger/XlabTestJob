using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace Golf
{
    public class animatrigger : MonoBehaviour
    {
        public Animator anim;
        

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        if (Input.GetKeyDown(KeyCode.X))
                {
                    anim.SetTrigger("New Trigger");
                }
        }
    }
}
