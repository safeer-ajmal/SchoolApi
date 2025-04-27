namespace School.Domain.Entities;

    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
    }

