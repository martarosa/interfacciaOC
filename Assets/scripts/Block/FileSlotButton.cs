using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace INTOC
{

    public class FileSlotButton : MonoBehaviour
    {
        FileSlot _fileSlot;



        // Start is called before the first frame update
        void Start()
        {
            _fileSlot = GetComponentInParent<FileSlot>();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}