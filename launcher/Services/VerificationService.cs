using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcher.Services
{
    public class VerificationService
    {
        public string _code { get; private set; }
        public int _attempts { get; private set; }
        public VerificationService() {
            _code = new Random().Next(100000, 999999).ToString();
            _attempts = 3;
        }
        public bool verify(string code)
        {
            if (_attempts > 0)
            {
                _attempts--;
                return _code.Equals(code);
            } else return false;
        }
    }
}
