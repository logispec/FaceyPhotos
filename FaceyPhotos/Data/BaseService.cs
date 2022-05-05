namespace FaceyPhotos.Data
{
    public abstract class BaseService
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
