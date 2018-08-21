using DataAccessLayer.io;
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

namespace DataAccessLayer.Persistance.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SHSDatabaseContext _context;

        public UnitOfWork(SHSDatabaseContext context)
        {
            _context = context;
            ProductTypes = new ProductTypeRepository(_context);
            Customers = new CustomerRepository(_context);
            Users = new UserRepository(_context);
            Orders = new OrderRepository(_context);
            TechnicalTasks = new TechnicalTaskRepository(_context);
            CustomerEnquiries = new CustomerEnquiryRepository(_context);
            TechnicalSupportEnquiries = new TechnicalSupportEnquiryRepository(_context);
            CustomerEnquiries = new CustomerEnquiryRepository(_context);
            BillingInvoices = new BillingInvoiceRepository(_context);
            Employees = new EmployeeRepository(_context);
            CustomerManagementEmployees = new CustomerManagementEmployeeRepository(_context);
            TechnicalSupportManagementEmployees = new TechnicalSupportManagementEmployeeRepository(_context);
            ProductManagementEmployees = new ProductManagementEmployeeRepository(_context);
            Products = new ProductRepository(_context);
            Schedules = new ScheduleRepository(_context);
            CustomerProductConfigurations = new CustomerProductConfigurationRepository(_context);
            ContractTypes = new ContractTypeRepository(_context);
        }

        public IProductTypeRepository ProductTypes { get; }
        public ICustomerRepository Customers { get; }
        public IUserRepository Users { get; }
        public IOrderRepository Orders { get; }
        public ITechnicalTaskRepository TechnicalTasks { get; }
        public ITechnicalSupportEnquiryRepository TechnicalSupportEnquiries { get; }
        public ICustomerEnquiryRepository CustomerEnquiries { get; }
        public IBillingInvoiceRepository BillingInvoices { get;}
        public IEmployeeRepository Employees { get; }
        public ICustomerManagementEmployeeRepository CustomerManagementEmployees { get; }
        public ITechnicalSupportManagementEmployeeRepository TechnicalSupportManagementEmployees { get; }
        public IProductManagementEmployeeRepository ProductManagementEmployees { get; }
        public IProductRepository Products { get; }
        public IScheduleRepository Schedules { get; }
        public ICustomerProductConfigurationRepository CustomerProductConfigurations { get; }
        public IContractTypeRepository ContractTypes { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
