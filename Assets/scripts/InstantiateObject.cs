using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace INTOC
{
    public class InstantiateObject : MonoBehaviour
    {

        public GameObject myPrefab = null;


        public GameObject InstantiateObj()
        {
            return Instantiate(myPrefab, transform.position, Quaternion.identity);
        }


        public GameObject InstantiateObj(Transform transformParent)
        {
            return Instantiate(myPrefab, transformParent);
        }





        // Start is called before the first frame update
        void Start()
        {
     
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}