using System.Collections.Generic;
using System.Linq;
using UnityEngine;


// ReSharper disable once CheckNamespace
namespace HelicopterPhysics.Inputs
{
    [RequireComponent(typeof(KeyboardHeliInput))]
    [RequireComponent(typeof(XboxHeliInput))]
    public class InputController : MonoBehaviour
    {

        public List<BaseHeliInput> inputs = new List<BaseHeliInput>();
        public BaseHeliInput activeInput;

        private BaseHeliInput _currentInput;

        public InputController(BaseHeliInput currentInput)
        {
            _currentInput = currentInput;
        }

        public BaseHeliInput CurrentInput
        {
            get { return _currentInput; }
        }

        private void Awake()
        {
            inputs = GetComponents<BaseHeliInput>().ToList();

            SetInputType();
        }

        private void SetInputType()
        {
            DisableAllInputs();
            _currentInput = activeInput;
            activeInput.enabled = true;
            /*switch (Input)
            {
                case InputType.PC:
                    _pcController.enabled = true;
                    _currentInput = _pcController;
                    break;

                case InputType.XBOX:
                    _xboxController.enabled = true;
                    _currentInput = _xboxController;
                    break;

                default:
                    _pcController.enabled = true;
                    _currentInput = _pcController;
                    break;
            }*/
        }

        private void DisableAllInputs()
        {
            foreach (BaseHeliInput input in inputs)
            {
                input.enabled = false;
            }
        }
    }

}
