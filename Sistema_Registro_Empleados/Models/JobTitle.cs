namespace RRHH_System.ModelsClass
{
    public class JobTitle
    {
        /* ---------------------------------------------------------------------- */
        /* Campos atributos                                                       */
        /* ---------------------------------------------------------------------- */
        private string _category;
        private string _jobCode;
        private string _jobTitle;
        private double _baseSalary;

        /* ---------------------------------------------------------------------- */
        /* Propiedades                                                            */
        /* ---------------------------------------------------------------------- */
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string JobCode
        {
            get { return _jobCode; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código del puesto de trabajo no puede ser nulo o vacio.");
                _jobCode = value;
            }
        }

        public string JobTitleName
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public double BaseSalary
        {
            get { return _baseSalary; }
            set
            {
                if (value < 0)
                    _baseSalary = 0;
                else
                    _baseSalary = value;
            }
        }

        /* ---------------------------------------------------------------------- */
        /* Constructores                                                          */
        /* ---------------------------------------------------------------------- */
        // Constructor sin parámetros
        public JobTitle()
        {
            _category = string.Empty;
            _jobCode = string.Empty;
            _jobTitle = string.Empty;
            _baseSalary = 0.0;
        }

        // Constructor con parámetros
        public JobTitle(string category, string jobCode, string jobTitle, double baseSalary)
        {
            _category = category;
            _jobCode = jobCode;
            _jobTitle = jobTitle;
            _baseSalary = baseSalary;
        }

        /* ---------------------------------------------------------------------- */
        /* Métodos                                                                */
        /* ---------------------------------------------------------------------- */
        public int UpdateJobTitle(string jobCode, JobTitle updatedJobTitle)
        {
            // En un escenario real, esta lógica implicaría la consulta a una base de datos o a un servicio
            // externo para actualizar la información del titulo de trabajo. Sin embargo, para fines de demostración,
            // se simula la actualización de titulos de trabajo utilizando una lista en memoria.
            List<JobTitle> lstJobTitle = new List<JobTitle>();

            // Simulación de lectura de puestos de trabajo desde una fuente de datos
            lstJobTitle.Add(new JobTitle("Recursos Humanos",
                                         "PST-001",
                                         "Gerente de Recursos Humanos",
                                         50000.0));
            lstJobTitle.Add(new JobTitle("Finanzas",
                                         "PST-002",
                                         "Gerente de Finanzas",
                                         60000.0));
            lstJobTitle.Add(new JobTitle("Tecnología",
                                         "PST-003",
                                         "Gerente de Tecnología",
                                         70000.0));

            // Busca el titulo de trabajo en la lista utilizando el código proporcionado
            var foundJobTitle = lstJobTitle.FirstOrDefault(jt => jt.JobCode == jobCode);

            if (foundJobTitle == null)
                // Lanza una excepción si no se encuentra el título de trabajo con el código proporcionado
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento JobTitle");

            // Actualiza la información del título de trabajo encontrado con la información proporcionada
            foundJobTitle.Category = updatedJobTitle.Category;
            foundJobTitle.JobTitleName = updatedJobTitle.JobTitleName;
            foundJobTitle.BaseSalary = updatedJobTitle.BaseSalary;

            return 1; // Retorna 1 si se actualizó correctamente
        } //End-method
    }
}