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
    public class Task : INotifyPropertyChanged
    {
        private string taskName;
        private string material;
        private string thickness;
        private string cuttingGas;
        private string customerName;


        public string TaskName
        {
            get => taskName;
            set
            {
                taskName = value;
                OnPropertyChanged(nameof(TaskName));
            }
        }
        public string Material
        {
            get => material;
            set
            {
                material = value;
                OnPropertyChanged(nameof(Material));
            }
        }
        public string Thickness
        {
            get => thickness;
            set
            {
                thickness = value;
                OnPropertyChanged(nameof(Thickness));
            }
        }
        public string CuttingGas
        {
            get => cuttingGas;
            set
            {
                cuttingGas = value;
                OnPropertyChanged(nameof(CuttingGas));
            }
        }
        public string CustomerName
        {
            get => customerName;
            set
            {
                customerName = value;
                OnPropertyChanged(nameof(CustomerName));
            }
        }

        public Task()
        {
            taskName = "taskName";
            this.material = "碳钢";
            this.thickness = "1mm";
            this.cuttingGas = "空气";
            this.customerName = "CustomerX";
        }

        public Task(string taskName, string material, string thickness, string cuttingGas, string customerName)
        {
            this.taskName = taskName;
            this.material = material;
            this.thickness = thickness;
            this.cuttingGas = cuttingGas;
            this.customerName = customerName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
