﻿using System;

namespace Orchard
{
    public class Step3VM : ViewModelBase
    {
        public Step3VM()
        {
            Common = new StepVMCommon("Step3Questions.txt", "Step3HelpTexts.txt", "Sprayer Information");
        }

        public StepVMCommon Common{ get; set; }
    }
}
