using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Prism.Commands;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using DocumentFormat.OpenXml.Bibliography;
using System.Windows.Controls;

namespace PLD_PRG.ViewModel 
{
    class MainWindowsViewModel :ViewModelBase, INotifyPropertyChanged
    {

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        // TODO 01:Tag
        #region Tag
        private Page PageHome;
        private Page PageReel;
        private Page PageVacuum;
        private Page PageTarget;
        private Page PageLaser;
        private Page PageScan;
        private Page PageHeater;
        private Page PageEventLog;
        private Page PageLogs;
        private Page PageDiagnostic;
        private Page PageSetting;
        private Page _currentPage;
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                OnPropertyChanged("CurrentPage");
                GC.Collect();
            }
        }
        private int _frameOpacity;
        public int FrameOpacity
        {
            get { return _frameOpacity; }
            set
            {
                _frameOpacity = value;
                OnPropertyChanged("FrameOpacity");
                GC.Collect();
            }
        }
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
        #endregion
        // TODO 02 :Button Menu
        #region ButtonMenu

        public ICommand IHomePage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageHome;
                    GC.Collect();
                });
                
            }

        }
        public ICommand IReelPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageReel;
                    GC.Collect();
                });
                
            }
        }
        public ICommand IVacuumPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageVacuum;
                    GC.Collect();
                });

            }
        }
        public ICommand ITargetPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageTarget;
                    GC.Collect();
                });

            }
        }
        public ICommand IScanPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageScan;
                    GC.Collect();
                });

            }
        }
        public ICommand IHeaterPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageHeater;
                    GC.Collect();
                });

            }
        }

        public ICommand IEventLogPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageEventLog;
                    GC.Collect();
                });

            }
        }
        public ICommand ILogsPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageLogs;
                    GC.Collect();
                });

            }
        }
        public ICommand ILaserPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageLaser;
                    GC.Collect();
                });

            }
        }
        public ICommand IDiagnosticPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageDiagnostic;
                    GC.Collect();
                });

            }
        }
        public ICommand ISettingPage
        {
            get
            {
                return new DelegateCommand(() =>
                {

                    CurrentPage = PageSetting;
                    GC.Collect();
                });

            }
        }
        #endregion
        public MainWindowsViewModel()
        {
            PageHome = new View.PageHome();
            PageReel = new View.PageReel();
            PageVacuum = new View.PageVacuum();
            PageTarget = new View.PageTarget();
            PageLaser = new View.PageLaser();
            PageScan = new View.PageScan();
            PageHeater = new View.PageHeater();
            PageEventLog = new View.PageEventLog();
            PageLogs = new View.PageLogs();
            PageDiagnostic = new View.PageDiagnostic();
            PageSetting = new View.PageSetting();
            CurrentPage = PageHome;
            FrameOpacity = 1;
            var timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            sTime = Convert.ToString((DateTime.Now)).Split(' ')[1];
            dTime = Convert.ToString((DateTime.Now)).Split(' ')[0];
        }
    }
}
