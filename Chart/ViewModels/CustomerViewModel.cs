
namespace Chart.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;
    using Chart.Commands;
    using Chart.Models;

    internal class CustomerViewModel
    {
        public CustomerViewModel()
        {
            _Customer = new Customer("David");
            UpdateCommand = new CustomerUpdateCommand(this);
        }
        public bool CanUpdate { get {
                if(Customer == null)
                    return false;
                return !String.IsNullOrWhiteSpace(Customer.Name); } }
        private Customer _Customer;
        public Customer Customer { get { return _Customer; } }
        public void SaveChanges()
        {
            Debug.Assert(false,String.Format("{0 was updated}",Customer.Name));

        }
        public ICommand UpdateCommand
        {
            get;
            private set;
        }
       
    }
}
