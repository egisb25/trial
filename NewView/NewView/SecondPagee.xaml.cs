using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewView
{
    public partial class SecondPagee : ContentPage
    {
        public SecondPagee()
        {
            InitializeComponent();
        }
        public long fib(long Value)
        {
            if (Value == 0)
            {
                return 0;
            }
            else if (Value == 1)
            {
                return 1;
            }
            else
            {
                return fib(Value - 1) + fib(Value - 2);
            }
        }
    }
}
