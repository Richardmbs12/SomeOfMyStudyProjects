using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BusinessLayer.io.employeeManagement
{
    public interface IEmployeeRecordKeeper
    {
        CreateEmployeeResponse CreateEmployee(CreateEmployeeRequest createEmployeeRequest);
        FindEmployeeResponse FindEmployee(FindEmployeeRequest findEmployeeRequest);
        RemoveEmployeeResponse RemoveEmployee(RemoveEmployeeRequest removeEmployeeRequest);
        RetrieveEmployeeResponse RetrieveEmployee(RetrieveEmployeeRequest retrieveEmployeeRequest);
        UpdateEmployeeResponse UpdateEmployee(UpdateEmployeeRequest updateEmployeeRequest);
    }

    [Serializable]
    public class CreateEmployeeRequest
    {
        private Employee employee;
        public CreateEmployeeRequest setEmployee(Employee employee)
        {
            this.employee = employee;
            return this;
        }
        public Employee getEmployee()
        {
            return this.employee;
        }
    }
    [Serializable]
    public class CreateEmployeeResponse
    {
        private string error;
        public CreateEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
    }
    [Serializable]
    public class FindEmployeeRequest
    {
        private SearchCriteria searchCriteria;
        public FindEmployeeRequest setSearchCriteria(SearchCriteria searchCriteria)
        {
            this.searchCriteria = searchCriteria;
            return this;
        }
        public SearchCriteria getSearchCriteria()
        {
            return this.searchCriteria;
        }
    }
    [Serializable]
    public class FindEmployeeResponse
    {
        private List<Employee> employees;
        private string error;
        public FindEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindEmployeeResponse setEmployee(List<Employee> employees)
        {
            this.employees = employees;
            return this;
        }
        public List<Employee> getEmployees()
        {
            return this.employees;
        }
    }
    [Serializable]
    public class RemoveEmployeeRequest
    {
        private Employee employee;
        public RemoveEmployeeRequest setEmployee(Employee employee)
        {
            this.employee = employee;
            return this;
        }
        public Employee getEmployee()
        {
            return this.employee;
        }
    }
    [Serializable]
    public class RemoveEmployeeResponse
    {
        private string error;
        public RemoveEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
    }
    [Serializable]
    public class RetrieveEmployeeRequest
    {
        private string id;
        public RetrieveEmployeeRequest setEmployeeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getEmployeeId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveEmployeeResponse
    {
        private Employee employee;
        private string error;
        public RetrieveEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveEmployeeResponse setEmployee(Employee employee)
        {
            this.employee = employee;
            return this;
        }
        public Employee getEmployee()
        {
            return this.employee;
        }
    }
    [Serializable]
    public class UpdateEmployeeRequest
    {
        private Employee employee;
        public UpdateEmployeeRequest setEmployee(Employee employee)
        {
            this.employee = employee;
            return this;
        }
        public Employee getEmployee()
        {
            return this.employee;
        }
    }
    [Serializable]
    public class UpdateEmployeeResponse
    {
        private Employee employee;
        private string error;
        public UpdateEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateEmployeeResponse setEmployee(Employee employee)
        {
            this.employee = employee;
            return this;
        }
        public Employee getEmployee()
        {
            return this.employee;
        }
    }
    [Serializable]
    public class EmployeeNotUnique : Exception
    {
        public EmployeeNotUnique()
          : base()
        {
        }
        public EmployeeNotUnique(String message)
          : base(message)
        {
        }
        public EmployeeNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected EmployeeNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class EmployeeAlreadyExists : Exception
    {
        public EmployeeAlreadyExists()
          : base()
        {
        }
        public EmployeeAlreadyExists(String message)
          : base(message)
        {
        }
        public EmployeeAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected EmployeeAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class EmployeeDoesNotExist : Exception
    {
        public EmployeeDoesNotExist()
          : base()
        {
        }
        public EmployeeDoesNotExist(String message)
          : base(message)
        {
        }
        public EmployeeDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected EmployeeDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
