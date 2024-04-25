using DellWPFSolution.ActionInterfaces;
using DellWPFSolution.Actions;
using DellWPFSolution.Model;
using DellWPFSolution.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellWPFSolution.Controller
{
    class DisplayController
    {
        private DisplayViewModel _viewModel;
        private IEnterData _enterData;
        private IProcessData _process;
        private IDisplayData _displayData;

        public DisplayViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        public DisplayController()
        {
            DisplayModel model = new DisplayModel();
            _displayData = new DisplayData();
            _enterData = new EnterData();
            _process = new ProcessData();
            _viewModel = new DisplayViewModel(model,_enterData, _process,_displayData);
        }
    }
}
