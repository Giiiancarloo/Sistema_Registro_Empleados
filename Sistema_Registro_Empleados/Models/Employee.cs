using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Registro_Empleados.Models
{
    internal class Employee
    {
        private string _address;
        private DateOnly _birthDate;
        private string _email;
        private string _identityCard;
        private string _maritalStatus;
        private string _name;
        private string _surname;
        private string _statuts;
        private int _numberChildren;
        private int _phone;

        /* Propiedades de la clase sin validación */
        public string Address { get => _address; set => _address = value; }
        public DateOnly BirthDate { get => _birthDate; set => _birthDate = value; }
        public string Email { get => _email; set => _email = value; }
        public string IdentityCard { get => _identityCard; set => _identityCard = value; }
        public string MaritalStatus { get => _maritalStatus; set => _maritalStatus = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Statuts { get => _statuts; set => _statuts = value; }
        public int NumberChildren { get => _numberChildren; set => _numberChildren = value; }
        public int Phone { get => _phone; set => _phone = value; }

        /* Constructor de nuevas instancias */
        public Employee()
        {
            this._address = string.Empty;
            this._birthDate = DateOnly.FromDateTime(DateTime.Now);
            this._email = string.Empty;
            this._identityCard = string.Empty;
            this._maritalStatus = string.Empty;
            this._name = string.Empty;
            this._surname = string.Empty;
            this._statuts = string.Empty;
            this._numberChildren = 0;
            this._phone = 0;
        }

        /* M+etodo para mostrar información del empleado */
        public void EmployeeAdd()
        {
            //Crear una lista de epleados para almacenar los empleados creados
            var ListEmployees = new List<Employee>();

            //Captar la información del empleado
            var newEmployee = new Employee
            {
                IdentityCard = this._identityCard,
                Name = this._name,
                Surname = this._surname,
                BirthDate = this._birthDate,
                MaritalStatus = this._maritalStatus,
                NumberChildren = this._numberChildren,
                Phone = this._phone,
                Email = this._email,
                Address = this._address,
                Statuts = this._statuts
            };

            //Agregar el nuevo empleado a la lista de empleados
            ListEmployees.Add(newEmployee);

            //Devuelve el número total de empleados en la lista
            return ListEmployees.Count;
        }

        public void ListEmployee()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee()
        {
            throw new NotImplementedException();
        }
    }
}