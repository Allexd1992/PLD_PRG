using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace PLD_PRG.ViewModel
{
    class LaserPageViewModel : INotifyPropertyChanged
    {
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #region Tag
        private string psTime;
        public string sTime
        {
            get { return psTime; }
            set
            {
                psTime = value;
                OnPropertyChanged("sTime");
                GC.Collect();
            }
        }

        private string pdTime;
        public string dTime
        {
            get { return pdTime; }
            set
            {
                pdTime = value;
                OnPropertyChanged("dTime");
                GC.Collect();
            }
        }

        private bool pBlMb;
        public bool BlMb
        {
            get { return pBlMb; }
            set
            {
                pBlMb = value;
                OnPropertyChanged("BlMb");
                GC.Collect();
            }
        }

        private bool pBlCom;
        public bool BlCom
        {
            get { return pBlCom; }
            set
            {
                pBlCom = value;
                OnPropertyChanged("BlCom");
                GC.Collect();
            }
        }

        private string pPressure;
        public string pressure
        {
            get { return pPressure; }
            set
            {
                pPressure = value;
                OnPropertyChanged("pressure");
                GC.Collect();
            }

        }

        private string pReprate;
        public string reprate
        {
            get { return pReprate; }
            set
            {
                pReprate = value;
                OnPropertyChanged("reprate");
                GC.Collect();
            }

        }

        private string pShutter;
        public string shutter
        {
            get { return pShutter; }
            set
            {
                pShutter = value;
                OnPropertyChanged("shutter");
                GC.Collect();
            }

        }

        private string pEgy;
        public string egy
        {
            get { return pEgy; }
            set
            {
                pEgy = value;
                OnPropertyChanged("egy");
                GC.Collect();
            }

        }

        private string pHv;
        public string hv
        {
            get { return pHv; }
            set
            {
                pHv = value;
                OnPropertyChanged("hv");
                GC.Collect();
            }

        }

        private string pCounter;
        public string counter
        {
            get { return pCounter; }
            set
            {
                pCounter = value;
                OnPropertyChanged("counter");
                GC.Collect();
            }

        }

        private string pCounterNewFill;
        public string counterNewFill
        {
            get { return pCounterNewFill; }
            set
            {
                pCounterNewFill = value;
                OnPropertyChanged("counterNewFill");
                GC.Collect();
            }

        }

        private string pTrigger;
        public string trigger
        {
            get { return pTrigger; }
            set
            {
                pTrigger = value;
                OnPropertyChanged("trigger");
                GC.Collect();
            }

        }

        private string pTubeTemp;
        public string tubeTemp
        {
            get { return pTubeTemp; }
            set
            {
                pTubeTemp = value;
                OnPropertyChanged("tubeTemp");
                GC.Collect();
            }

        }

        private string pMode;
        public string mode
        {
            get { return pMode; }
            set
            {
                pMode = value;
                OnPropertyChanged("mode");
                GC.Collect();
            }

        }

        private string pOpMode;
        public string opMode
        {
            get { return pOpMode; }
            set
            {
                pOpMode = value;
                OnPropertyChanged("opMode");
                GC.Collect();
            }

        }

        private string pTechTime;
        public string techTime
        {
            get { return pTechTime; }
            set
            {
                pTechTime = value;
                OnPropertyChanged("techTime");
                GC.Collect();
            }

        }

        private string pStCod;
        public string stCod
        {
            get { return pStCod; }
            set
            {
                pStCod = value;
                OnPropertyChanged("stCod");
                GC.Collect();
            }

        }

        #endregion
        public ICommand BtnClkMbRun
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    BlMb = true;
    

                });
            }
        }
        public ICommand BtnClkMbStop
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    BlMb = false;
               
                });
            }
        }
        public ICommand BtnClkComRun
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    BlCom = true;
                    // MainModel.LserComConnect();
                   

                });
            }
        }
        public ICommand BtnClkComStop
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    //MainModel.LserComDisconnect();
                    BlCom = false;
                });
            }
        }

    }
}
