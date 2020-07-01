using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using wdReports.Annotations;

namespace wdReports
{
    public class Report : INotifyPropertyChanged
    {
        private string reportName;
        private string description;

        public string ReportName
        {
            get => reportName;
            set
            {
                reportName = value;
                OnPropertyChanged(nameof(ReportName));
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
