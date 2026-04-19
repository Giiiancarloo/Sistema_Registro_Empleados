using System;
using System.Collections.Generic;
using System.Linq; 

public class Recruitment
{
    /* ---------------------------------------------------------------------- */
    /* Campos / atributos                                                     */
    /* ---------------------------------------------------------------------- */
    private int _contractNumber;
    private DateOnly _startDate;
    private DateOnly _endDate;
    private string _typeContract;
    private string _contractStatus;
    private int _workday;

    /* ---------------------------------------------------------------------- */
    /* Propiedades                                                            */
    /* ---------------------------------------------------------------------- */
    public int ContractNumber
    {
        get { return _contractNumber; }
        set
        {
            if (value < 0)
                throw new ArgumentException("No se ha especificado un número de contrato valido");
            _contractNumber = value;
        }
    }

    public DateOnly StartDate { get => _startDate; set => _startDate = value; }
    public DateOnly EndDate { get => _endDate; set => _endDate = value; }
    public string TypeContract { get => _typeContract; set => _typeContract = value; }
    public string ContractStatus { get => _contractStatus; set => _contractStatus = value; }

    public int Workday
    {
        get { return _workday; }
        set
        {
            if (value <= 0 || value > 8)
                throw new ArgumentOutOfRangeException("Workday", "Jornada laboral fuera de rango.");
            _workday = value;
        }
    }

    /* ---------------------------------------------------------------------- */
    /* Constructores                                                          */
    /* ---------------------------------------------------------------------- */
    public Recruitment()
    {
        _contractNumber = 0; // Se agrega inicialización
        _startDate = DateOnly.MinValue;
        _endDate = DateOnly.MaxValue;
        _typeContract = string.Empty;
        _contractStatus = string.Empty;
        _workday = 0;
    }

    public Recruitment(DateOnly startDate, DateOnly endDate, string typeContract, string contractStatus, int workday)
    {
        _startDate = startDate;
        _endDate = endDate;
        _typeContract = typeContract;
        _contractStatus = contractStatus;
        Workday = workday;
    }

    /* ---------------------------------------------------------------------- */
    /* Métodos                                                                */
    /* ---------------------------------------------------------------------- */
    public int AddRecruitment()
    {
        List<Recruitment> lstRecruitment = new List<Recruitment>();
        lstRecruitment.Add(this); // CORRECCIÓN: Se debe agregar el objeto actual

        if (lstRecruitment.Count > 0)
            return lstRecruitment.Count;

        return 0;
    }

    public Recruitment ReadRecruitment(int numb)
    {
        List<Recruitment> lstRecruitment = ReadAllRecruitments(); // Uso de método auxiliar para no repetir código
        var recruitment = lstRecruitment.FirstOrDefault(r => r.ContractNumber == numb);

        if (recruitment == null)
            throw new KeyNotFoundException("Referencia vacía o nula de un elemento Recruitment");

        return recruitment;
    }

    public List<Recruitment> ReadAllRecruitments()
    {
        List<Recruitment> lstRecruitment = new List<Recruitment>();
        // Simulación de datos
        lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-1)), DateOnly.FromDateTime(DateTime.Now.AddMonths(11)), "Temporal", "Activo", 8) { ContractNumber = 1 });
        lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-2)), DateOnly.FromDateTime(DateTime.Now.AddMonths(10)), "Permanente", "Activo", 8) { ContractNumber = 2 });
        return lstRecruitment;
    }

    public int UpdateRecruitment(int numb, Recruitment updateRecruit)
    {
        List<Recruitment> lstRecruitment = new List<Recruitment>();
        lstRecruitment.Add(this);

        var foundRecruitment = lstRecruitment.FirstOrDefault(r => r.ContractNumber == numb);

        if (foundRecruitment == null)
            throw new KeyNotFoundException("Referencia vacía o nula de un elemento Contrato");

        // CORRECCIÓN: Lógica de actualización completa
        foundRecruitment.StartDate = updateRecruit.StartDate;
        foundRecruitment.EndDate = updateRecruit.EndDate;
        foundRecruitment.TypeContract = updateRecruit.TypeContract;
        foundRecruitment.ContractStatus = updateRecruit.ContractStatus;
        foundRecruitment.Workday = updateRecruit.Workday;

        return 1;
    }

    public int CancelRecruitment(int numb) // CORRECCIÓN: Método faltante
    {
        List<Recruitment> lstRecruitment = new List<Recruitment>();
        lstRecruitment.Add(this);

        var foundRecruitment = lstRecruitment.FirstOrDefault(r => r.ContractNumber == numb);

        if (foundRecruitment == null)
            throw new KeyNotFoundException("Referencia vacía o nula de un elemento Recruitment");

        lstRecruitment.Remove(foundRecruitment);
        return 1;
    }
}