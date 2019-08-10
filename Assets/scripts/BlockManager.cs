using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace INTOC
{
    public class BlockManager : MonoSingleton<BlockManager>
    {

        // pos y titolo = 3  
        // spessore titolo = 0.1*sprite
        // pos y input = 2.5 = pos y titolo - spessore titolo
        // spessore input con 1 fileslot = 0.2*sprite
        // pos del fileslot = -0.5
        // pos0 y output = 1.5 = pos y input - spessore input con 1 fileslot
        // pos del fileslot = -0.5

        // aggiungo 1 fileslot in input: 
                                        // la posizione del fileslot nuovo è -1.2 = pos del fileslot - 0.7
                                        // la dimensione della sprite di input è 0.35 = spessore input con 1 fileslot + 0.15
                                        // la posizione dell'output = 0.75 = pos0 y output - 0.75


        
        // questi numeri oltre che scelte estetiche sono funzione della sprite dei blocchi

        float _blockSpriteSlotScaleShift = 0.15f; 
        float _outputSlotPositionShift = 0.75f;
        float _slotPositionShift = 0.7f;

        InstantiateObject _instantiateBlocks;

        public List<Block> _blocks = new List<Block>();
        public Transform _blockArea;

        public int _nInputSlot = 2;
        public int _nOutputSlot = 3;

        // properties
        public float BlockSpriteSlotScaleShift {
            get { return _blockSpriteSlotScaleShift; }
          }

        public float OutputSlotPositionShift
        {
            get { return _outputSlotPositionShift; }
        }

        public float SlotPositionShift
        {
            get { return _slotPositionShift; }
        }

        public void InitBlock()
        {
            
            Block block = _instantiateBlocks.InstantiateObj(_blockArea).GetComponent<Block>();
            _blocks.Add(block);
            block.Initialize(_nInputSlot, _nOutputSlot);

        }



        // Start is called before the first frame update
        void Start()
        {
            _instantiateBlocks = GetComponent<InstantiateObject>();
            InitBlock();    

        }

        // Update is called once per frame
        void Update()
        {

        }


       


    }
}