using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace INTOC
{
    public class FileSlot : MonoBehaviour
    {

        public void SetYPosition(int myFileSlotN)
        {
            float shift = myFileSlotN * BlockManager.I.SlotPositionShift;
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - shift, transform.localPosition.z);

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