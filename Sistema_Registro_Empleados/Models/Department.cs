using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Registro_Empleados.Models
{
    internal class Department
    {
        private string _departmentName;
        private string _departmentCode;
        private string _description;
        private bool _isActive;


        //Propiedades aplicando validaciones
        public string DepartmentName
        {
            get { return _departmentName; }
            set
                {
                if (string.IsNullOrWhiteSpace(value))
                { throw new ArgumentException("El nombre del departamento no puede estar vacio"); }
            }
        }

        public string DepartmentCode
        {
            get { return _departmentCode; }
            set { _departmentCode = value; }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }


        //Constructor sin parametros
        public Department()
        {
            //Utilizando los atributos
            _departmentCode = "DPT-";
            _departmentName = string.Empty;
            _description = string.Empty;
            _isActive = true;
        }

        //Constructor con parámetros
        public Department(string departmentName, string departmentCode, string description)
        {
            //Utilizando las propiedades
            this.DepartmentName = departmentName;
            this.DepartmentCode = departmentCode;
            this.Description = description;
        }

        //Métodos
        public int AddDepartment()
        {
            //Lógica para agregar un departamento a la base de datos
            //Retorna el ID del departamento agregado
            return 0; // Placeholder, reemplazar con lógica real
        }

        public List<Department> GetDepartments()
        {
            //Lógica para obtener la lista de departamentos desde la base de datos
            return new List<Department>(); // Placeholder, reemplazar con lógica real
        }
        public bool UpdateDepartment()
        {
            //Lógica para actualizar un departamento en la base de datos
            return true; // Placeholder, reemplazar con lógica real
        }
        public void DeleteDepartment()
        {
            //Lógica para eliminar un departamento de la base de datos
        }
    }
}