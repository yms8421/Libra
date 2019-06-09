using System;

namespace BilgeAdam.DataTransferObjects
{
    public abstract class DTOBase
    {
        public DTOBase()
        {
            IsActive = true;
        }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
    }

    public abstract class BasicDTOBase : DTOBase
    {
        public int Id { get; set; }
    }

    public abstract class StringDTOBase : DTOBase
    {
        public string Id { get; set; }
    }

    public abstract class GuidDTOBase : DTOBase
    {
        public Guid Id { get; set; }
    }
}
