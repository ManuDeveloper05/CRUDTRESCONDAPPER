using System.Data;

public interface ICustomersData
{
    IEnumerable<CustomerDto> GetCustomers();

    IEnumerable<CustomerDto> GetCustomersID();

    IEnumerable<CustomerDto> EliminarCustomers(CustomerDto eliminarCliente);

    IEnumerable<CustomerDto> AgregarCustomers(CustomerDto nuevoCliente);

    IEnumerable<CustomerDto> ActualizarCustomers(CustomerDto actualizarCliente);


}