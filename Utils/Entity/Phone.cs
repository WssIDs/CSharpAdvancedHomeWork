namespace Utils.Entity
{
    public interface IPhone
    {
        string Name { get; set; }
        string Model { get; set; }
        string GetInfo();
    }

    public class Phone : IPhone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string GetInfo() => $"Наименование - {Name} (Модель - {Model})";
    }

    public class SmartPhone : IPhone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Os { get; set; }

        public string GetInfo() => $"Наименование: {Name} | (Модель: {Model}) | Операционная система - {Os}";
    }
}
