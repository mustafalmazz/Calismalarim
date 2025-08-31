namespace TurkcellDependencyInjection.Helpers
{
    public class Helper : IHelper
    {
        private bool _isConfiguration;
        private string  _context;

        public Helper(bool isConfiguration, string context)
        {
            _isConfiguration = isConfiguration;
            _context = context;

        }
        public string Upper(string text)
        {
            _context += "a";
            return text.ToUpper();
        }
    }
}
