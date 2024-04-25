using DellWPFSolution.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using GalaSoft.MvvmLight.CommandWpf;
using DellWPFSolution.Actions;
using DellWPFSolution.ActionInterfaces;
using System.Windows.Media;

namespace DellWPFSolution.ViewModel
{
    class DisplayViewModel : INotifyPropertyChanged
    {
        private DisplayModel _model;
        private IEnterData _enter;
        private IProcessData _process;
        private IDisplayData _displayData;
        private SolidColorBrush _foregroundBrush;
        public string Label1Text
        {
            get { return _model.Label1Text; }
            set
            {
                _model.Label1Text = value;
                OnPropertyChanged();
            }
        }

        public string Label2Text
        {
            get { return _model.Label2Text; }
            set
            {
                _model.Label2Text = value;
                OnPropertyChanged();
            }
        }

        public string TextBox1Text
        {
            get { return _model.TextBox1Text; }
            set
            {
                _model.TextBox1Text = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush ForegroundBrush
        {
            get { return _foregroundBrush; }
            set
            {
                _foregroundBrush = value;
                OnPropertyChanged();
            }
        }
        // Command for Enter button
        public ICommand EnterCommand { get; }
        public ICommand ProcessCommand { get; }

        public DisplayViewModel(DisplayModel model, IEnterData enter, IProcessData process, IDisplayData displayData)
        {
            _displayData = displayData;
            _enter = enter;
            _process = process;
            _model = model;
            EnterCommand = new RelayCommand(Enter,true);
            ProcessCommand = new RelayCommand(Process, true);
        }

        private void Enter()
        {
            _enter.AddString(_model, TextBox1Text);
            TextBox1Text = string.Empty;
            Label1Text = _displayData.CreateLabel1(_model);
        }

        private void Process()
        {

            //_enter.AddString(_model, TextBox1Text);
            //TextBox1Text = string.Empty;
            
            Label2Text = _displayData.CreateLabel2(_model);
            Label1Text = _displayData.CreateLabel1Process(_model);
            TYPE result = _process.Process(Label2Text);
            switch (result)
            {
                case (TYPE.STRING):
                    ForegroundBrush = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    break;
                case (TYPE.INT):
                    ForegroundBrush = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                    break;
                case (TYPE.SPECIAL):
                    ForegroundBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    break;

            }
                
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
