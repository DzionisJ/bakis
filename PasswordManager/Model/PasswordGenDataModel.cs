﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    class PasswordGenDataModel : INotifyPropertyChanged
    {

        private string _GenPass;
        private int _GenPassLenght;

        public PasswordGenDataModel()
        {
        }

        public PasswordGenDataModel(string GeneratedPass)
        {
            this._GenPass = GeneratedPass;
        }

        public string GenPass
        {
            get { return _GenPass; }
            set { _GenPass = value; }
        }
        public int GenPassLenght
        {
            get { return _GenPassLenght; }
            set { _GenPassLenght = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}