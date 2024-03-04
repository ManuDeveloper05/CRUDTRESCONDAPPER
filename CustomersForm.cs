using CRUDTRES.Data;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CRUDTRES
{

    public partial class CustomersForm : Form
    {
        private CustomerDtoValidator validator = new CustomerDtoValidator();
        private readonly ICustomersData customersData;
        List<CustomerDto> clientes = new List<CustomerDto>(); // Declaración de la lista


        public CustomersForm(ICustomersData customersData)
        {
            InitializeComponent();
            Load += CustomersForm_Load;
            this.customersData = customersData;


            // Obtener los datos de los clientes una vez al cargar el formulario
            var customerIDs = customersData.GetCustomersID();

            // Establecer la propiedad DisplayMember para que el ComboBox muestre solo el ID del cliente
            CustomerID.DisplayMember = "CustomerID";

            // Agregar los IDs de clientes al ComboBox
            foreach (var customerID in customerIDs)
            {
                CustomerID.Items.Add(customerID);
            }

        }

        private void CustomersForm_Load(object? sender, EventArgs e)
        {
            CustomersDataGrid.DataSource = customersData.GetCustomers();




        }



        private void Leer_Click(object sender, EventArgs e)
        {
            CustomersDataGrid.DataSource = customersData.GetCustomers();


        }

        private void CustomersForm_Load_1(object sender, EventArgs e)
        {

        }


        private void CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elementoSeleccionado = CustomerID.SelectedItem.ToString();

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            CustomerDto actualizarCliente = new CustomerDto
            {
                CustomerID = CustomerID.Text,
                CompanyName = CompanyName.Text,
                ContactName = ContactName.Text,
                ContactTitle = ContactTittle.Text,
                Address = Address.Text,
                City = City.Text,
                Region = Region.Text,
                PostalCode = PostalCode.Text,
                Country = Country.Text,
                Phone = Phone.Text,
                Fax = Fax.Text
            };

            // Crear una instancia del validador de CustomerDto
            var validator = new CustomerDtoValidator();

            // Validar el objeto CustomerDto
            var validationResult = validator.Validate(actualizarCliente);

            if (validationResult.IsValid)
            {
                // Si la validación es exitosa, llamar al método ActualizarCustomers en la clase CustomersData para actualizar los datos del cliente en la base de datos
                customersData.ActualizarCustomers(actualizarCliente);

                // Actualizar DataGrid
                CustomersDataGrid.DataSource = customersData.GetCustomers();

                //Limpiar texbox
                LimpiarTextBoxes();

                MessageBox.Show("Los datos del cliente Se actualizó correctamente");
            }
            else
            {
                // Si la validación falla, construir un mensaje con todos los errores
                var errorMessage = "Se encontraron los siguientes errores al intentar su operación:\n\n";
                foreach (var error in validationResult.Errors)
                {
                    errorMessage += $"- {error.ErrorMessage}\n";
                }

                // Mostrar el mensaje de error en un solo MessageBox
                MessageBox.Show(errorMessage, "Errores al validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            CustomerDto nuevoCliente = new CustomerDto
            {
                CustomerID = CustomerID.Text,
                CompanyName = CompanyName.Text,
                ContactName = ContactName.Text,
                ContactTitle = ContactTittle.Text,
                Address = Address.Text,
                City = City.Text,
                Region = Region.Text,
                PostalCode = PostalCode.Text,
                Country = Country.Text,
                Phone = Phone.Text,
                Fax = Fax.Text
            };

            // Crear una instancia del validador de CustomerDto
            var validator = new CustomerDtoValidator();

            // Validar el objeto CustomerDto
            var validationResult = validator.Validate(nuevoCliente);

            if (validationResult.IsValid)
            {
                // Si la validación es exitosa, agrega el nuevo cliente al principio de la lista
                clientes.Insert(0, nuevoCliente);

                // Llama al método AgregarCustomers en la clase CustomersData para agregar el nuevo cliente a la base de datos
                customersData.AgregarCustomers(nuevoCliente);

                // Actualiza el DataGridView con la lista ordenada
                var sortedCustomers = clientes.OrderByDescending(c => c.FechaDeIngreso).ToList();
                CustomersDataGrid.DataSource = sortedCustomers;

                //Limpiar texbox
                LimpiarTextBoxes();

                MessageBox.Show("El cliente Se agregó correctamente");
            }
            else
            {
                // Si la validación falla, construir un mensaje con todos los errores
                var errorMessage = "Se encontraron los siguientes errores al intentar su operación:\n\n";
                foreach (var error in validationResult.Errors)
                {
                    errorMessage += $"- {error.ErrorMessage}\n";
                }

                // Mostrar el mensaje de error en un solo MessageBox
                MessageBox.Show(errorMessage, "Errores al validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerID.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del cliente que deseas eliminar.");
                return;
            }

            CustomerDto eliminarCliente = new CustomerDto
            {
                CustomerID = CustomerID.Text,
            };

            customersData.EliminarCustomers(eliminarCliente);

            MessageBox.Show("Se eliminó correctamente el cliente");
            LimpiarTextBoxes();
            // Actualizar DataGrid
            CustomersDataGrid.DataSource = customersData.GetCustomers();
        }





        private void CustomersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que la fila seleccionada no sea nula
            if (CustomersDataGrid.CurrentRow != null)
            {
                // Obtiene los datos de la fila seleccionada
                DataGridViewRow row = CustomersDataGrid.CurrentRow;

                // Asigna los valores a los textBox
                CustomerID.Text = row.Cells[0].Value?.ToString() ?? "";
                CompanyName.Text = row.Cells[1].Value?.ToString() ?? "";
                ContactName.Text = row.Cells[2].Value?.ToString() ?? "";
                ContactTittle.Text = row.Cells[3].Value?.ToString() ?? "";
                Address.Text = row.Cells[4].Value?.ToString() ?? "";
                City.Text = row.Cells[5].Value?.ToString() ?? "";
                Region.Text = row.Cells[6].Value?.ToString() ?? "";
                PostalCode.Text = row.Cells[7].Value?.ToString() ?? "";
                Country.Text = row.Cells[8].Value?.ToString() ?? "";
                Phone.Text = row.Cells[9].Value?.ToString() ?? "";
                Fax.Text = row.Cells[10].Value?.ToString() ?? "";
            }
        }

        private void LimpiarTextBoxes()
        {
            CustomerID.Text = "";
            CompanyName.Text = "";
            ContactName.Text = "";
            ContactTittle.Text = "";
            Address.Text = "";
            City.Text = "";
            Region.Text = "";
            PostalCode.Text = "";
            Country.Text = "";
            Phone.Text = "";
            Fax.Text = "";
        }

        private void Vaciar_Click(object sender, EventArgs e)
        {
            //Limpiar texbox
            LimpiarTextBoxes();

        }
    }
    public class CustomerDtoValidator : AbstractValidator<CustomerDto>
    {
        public CustomerDtoValidator()
        {
            RuleFor(customer => customer.CustomerID).NotEmpty();
            RuleFor(customer => customer.CompanyName).NotEmpty();
            RuleFor(customer => customer.ContactName).NotEmpty();
            RuleFor(customer => customer.ContactTitle).NotEmpty();
            RuleFor(customer => customer.Address).NotEmpty();
            RuleFor(customer => customer.City).NotEmpty();
            RuleFor(customer => customer.Country).NotEmpty();
            RuleFor(customer => customer.Phone).NotEmpty().Matches(@"^\d{10}$").WithMessage("El número de teléfono debe tener 10 dígitos.");
            RuleFor(customer => customer.Fax).Matches(@"^\d{10}$").WithMessage("El número de fax debe tener 10 dígitos.");
        }
    }



}
