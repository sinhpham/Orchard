﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Orchard
{	
	public partial class Step2Page : ContentPage
	{	
		public Step2Page ()
		{
			InitializeComponent ();

            foreach (var str in GrowthStageToPickerIdxCov.Names)
            {
                _growthStage.Items.Add(str);
            }

            var vm = new Step2VM();

            BindingContext = vm;

            ViewUtils.SetupStepView(_rLayout, _helpSv, _questionContainer, vm.Common.QuestionTapped);
		}

        public void NextClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send((Page)this, "next");
        }
	}
}

