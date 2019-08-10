using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace INTOC
{
    public class BlockSection : MonoBehaviour
    {

        //Block _block;
        InstantiateObject _instantiateSlots;
        public SpriteRenderer _backgroundSprite; 

        public Transform _slotStartingPosition;

        FileSlot[] _slots;
        
        

        // Start is called before the first frame update
        void Start()
        {

        

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ScaleYDimension(int nFileSlot)
        {
            float shift = nFileSlot * BlockManager.I.BlockSpriteSlotScaleShift;
            _backgroundSprite.transform.localScale = new Vector3(_backgroundSprite.transform.localScale.x, _backgroundSprite.transform.localScale.y + shift , _backgroundSprite.transform.localScale.z);

        }

        public void ShiftBlockPosition(int nFileSlot)
        {
            float shift = nFileSlot * BlockManager.I.OutputSlotPositionShift;
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - shift, transform.localPosition.z);

        }

        public void InitFileSlot(int nSlot)
        {
            _slots = new FileSlot[nSlot];

            for (int i = 0; i < nSlot; i++)
            {
                if(_instantiateSlots == null)
                    _instantiateSlots = GetComponent<InstantiateObject>();
                _slots[i] = _instantiateSlots.InstantiateObj(transform).GetComponent<FileSlot>();
                _slots[i].transform.localPosition = new Vector3(_slotStartingPosition.localPosition.x, _slotStartingPosition.localPosition.y , _slotStartingPosition.localPosition.z);
                _slots[i].SetYPosition(i);
            }


        }



    }
}