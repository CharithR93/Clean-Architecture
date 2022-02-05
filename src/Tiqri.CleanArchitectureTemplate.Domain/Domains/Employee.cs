namespace Tiqri.CleanArchitectureTemplate.Domain
{
    public class Employee : AuditableEntity, ISoftDelete
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ContactNo { get; private set; }

        public bool IsSoftDeleted { get; set; } = false;

        public Employee( string code, string firstName, string lastName, string contactNo)
        {            
            Code = code;
            FirstName = firstName;
            LastName = lastName;
            ContactNo = contactNo;
        }
    }
}
