﻿using System;
using Xamarin.Forms;

/*
 * Developed By : Kishan Donga, (Software Engineer Mobility)
 * */

namespace DLab.Forms.Events
{
    public class GridEventArgs : EventArgs
    {
        // give the selected position with 
        // the help of the BindingContext
        // for more refrence refer example how to get position 
        public int position { get; set; }

        // give the selected View with 
        // the help of the BindingContext
        // for more refrence refer example how to get View 
        public View view { get; set; }
    }
}
