using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class OpenButtonStateConcreteClass : ILiftState
    {
        private Form1 form;

        public OpenButtonStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }
        public void OpenButton(Lift lift)
        {
            if (lift.Mainelevator.Bottom == lift.Ffloor.Bottom) // First floor
            {
                lift.opening2 = true;
                lift.closing2 = false;
                lift.Doortimer2.Start();
                lift.Btnclose.Enabled = false;
                lift.Btnf.Enabled = false;
                lift.Btng.Enabled = false;
                lift.Btnfirst.Enabled = false;
                lift.Btnground.Enabled = false;
                form.logEvents("Lift Door Opens on First Floor");
            }
            else if (lift.Mainelevator.Bottom == lift.Gfloor.Bottom) // Ground floor
            {
                lift.opening1 = true;
                lift.closing1 = false;
                lift.Doortimer1.Start();
                lift.Btnclose.Enabled = false;
                lift.Btnf.Enabled = false;
                lift.Btng.Enabled = false;
                lift.Btnfirst.Enabled = false;
                lift.Btnground.Enabled = false;
                form.logEvents("Lift Door Opens on Ground Floor");
            }
            else
            {
                form.logEvents("Lift is not on any floor, Doors remain closed");
            }
        }

        public void CloseButton(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void MovingDown(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }

      
    }
}