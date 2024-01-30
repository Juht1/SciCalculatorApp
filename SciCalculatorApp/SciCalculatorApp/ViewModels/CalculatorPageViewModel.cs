using System;
using System.Collections.Generic;
using System.Text;


namespace ViewModels
{
        [INotifyPropertyChanged]

        internal partial class CalculatorPageViewModel
        {
        [ObservableProperty]
        private string InputText = string.Empty;
        }
}
