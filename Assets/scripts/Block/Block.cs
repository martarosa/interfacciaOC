using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace INTOC
{
    public class Block : MonoBehaviour
    {


    
        public BlockSection _titleSection;
        public BlockSection _inputSection;
        public BlockSection _outputSection;

        


        int _nInputSlot;
        int _nOutputSlot;


        public void CreateBlock()
        {
           
            _inputSection.ScaleYDimension(_nInputSlot);
            _inputSection.InitFileSlot(_nInputSlot);
            _outputSection.ShiftBlockPosition(_nInputSlot);
            _outputSection.ScaleYDimension(_nOutputSlot);
            Debug.Log(_nOutputSlot);
            _outputSection.InitFileSlot(_nOutputSlot);
                                 
        }


        public void Initialize(int nInputSlot, int nOutputSlot)
        {
            _nInputSlot = nInputSlot;
            _nOutputSlot = nOutputSlot;
            CreateBlock();
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