namespace HomeWork9.Classes
{
    public class CustomComponent
    {
        [Custom(0)]
        public void ShowInfo()
        { }

        [Custom(1, Name = "Получение информации")]
        private string GetInfo()
        {
            return "Информация";
        }
    }
}
