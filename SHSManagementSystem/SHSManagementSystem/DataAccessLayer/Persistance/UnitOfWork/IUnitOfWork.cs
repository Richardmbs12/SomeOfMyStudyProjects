using DataAccessLayer.Persistance.Repositories.BillingInvoiceRepository;
using DataAccessLayer.Persistance.Repositories.ContractTypeRepository;
using DataAccessLayer.Persistance.Repositories.CustomerEnquiryRepository;
using DataAccessLayer.Persistance.Repositories.CustomerManagementEmployeeRepository;
using DataAccessLayer.Persistance.Repositories.CustomerProductConfigurationRepository;
using DataAccessLayer.Persistance.Repositories.CustomerRepository;
using DataAccessLayer.Persistance.Repositories.EmployeeRepository;
using DataAccessLayer.Persistance.Repositories.OrderRepository;
using DataAccessLayer.Persistance.Repositories.ProductManagementEmployeeRepository;
using DataAccessLayer.Persistance.Repositories.ProductRepository;
using DataAccessLayer.Persistance.Repositories.ProductTypeRepository;
using DataAccessLayer.Persistance.Repositories.ScheduleRepository;
using DataAccessLayer.Persistance.Repositories.TechnicalManagementEmployeeRepository;
using DataAccessLayer.Persistance.Repositories.TechnicalSupportEnquiryRepository;
using DataAccessLayer.Persistance.Repositories.TechnicalTaskRepository;
using DataAccessLayer.Persistance.Repositories.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductTypeRepository ProductTypes { get; }
        IProductRepository Products { get; }
        ICustomerRepository Customers { get; }
        IUserRepository Users { get; }
        IOrderRepository Orders { get; }
        ITechnicalTaskRepository TechnicalTasks { get; }
        IScheduleRepository Schedules { get; }
        ITechnicalSupportEnquiryRepository TechnicalSupportEnquiries { get; }
        ICustomerEnquiryRepository CustomerEnquiries { get; }
        IBillingInvoiceRepository BillingInvoices { get; }
        IEmployeeRepository Employees { get; }
        ICustomerManagementEmployeeRepository CustomerManagementEmployees { get; }
        ITechnicalSupportManagementEmployeeRepository TechnicalSupportManagementEmployees { get; }
        IProductManagementEmployeeRepository ProductManagementEmployees { get; }
        ICustomerProductConfigurationRepository CustomerProductConfigurations { get; }
        IContractTypeRepository ContractTypes { get; }
        int Complete();
    }
}
