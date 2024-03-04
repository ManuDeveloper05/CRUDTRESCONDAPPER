using CRUDTRES;
using CRUDTRES.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.Logging;
using System.Collections.Generic;
using System.Data;
using Serilog;
using Log = Serilog.Log;


class CustomersData : ICustomersData
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public CustomersData(ISqlConnectionFactory sqlConnectionFactory)
    {
        this._sqlConnectionFactory = sqlConnectionFactory;
    }

    public IEnumerable<CustomerDto> GetCustomers()
    {
        var listOfCustomer = new List<CustomerDto>();

        
        using (var connection = _sqlConnectionFactory.GetDBconnection())
        {

            return connection.Query<CustomerDto>("Select * from Customers");





        }
    }

    public IEnumerable<CustomerDto> GetCustomersID()
    {
        var listOfCustomer = new List<CustomerDto>();


        using (var connection = _sqlConnectionFactory.GetDBconnection())
        {

            return connection.Query<CustomerDto>("Select CustomerID from Customers");




        }
    }

    public IEnumerable<CustomerDto> EliminarCustomers(CustomerDto eliminarCliente)
    {
        try
        {
            using (var connection = _sqlConnectionFactory.GetDBconnection())
            {
                var query = "DELETE FROM Customers WHERE CustomerID = @CustomerId";
                connection.Execute(query, eliminarCliente);

                return GetCustomers();
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error al intentar eliminar un cliente");
            throw; // Lanza la excepción para que pueda ser manejada en un nivel superior si es necesario
        }
    }

    public IEnumerable<CustomerDto> AgregarCustomers(CustomerDto nuevoCliente)
    {
        try
        {
            using (var connection = _sqlConnectionFactory.GetDBconnection())
            {
                var query = @"INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) 
                   VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)";
                connection.Execute(query, nuevoCliente);

                return GetCustomers(); // Devuelve la lista de clientes actualizada
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error al intentar agregar un nuevo cliente");
            throw; // Lanza la excepción para que pueda ser manejada en un nivel superior si es necesario
        }
    }

    public IEnumerable<CustomerDto> ActualizarCustomers(CustomerDto actualizarCliente)
    {
        try
        {
            using (var connection = _sqlConnectionFactory.GetDBconnection())
            {
                var query = @"UPDATE Customers 
                   SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, 
                       Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, 
                       Country = @Country, Phone = @Phone, Fax = @Fax
                   WHERE CustomerID = @CustomerID";
                connection.Execute(query, actualizarCliente);

                return GetCustomers();
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error al intentar actualizar un cliente");
            throw; // Lanza la excepción para que pueda ser manejada en un nivel superior si es necesario
        }
    }

}




