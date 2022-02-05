namespace Tiqri.CleanArchitectureTemplate.Domain
{
    public interface ISoftDelete
    {
        public bool IsSoftDeleted { get; set; }

        public void SoftDelete()
        {
            IsSoftDeleted = true;
        }

        public void RevertDelete()
        {
            IsSoftDeleted = false;
        }
    }
}
