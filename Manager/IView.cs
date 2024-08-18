using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public interface IView
    {
        public string Item1 { get; }
        public string Item2 { get; }

        public string num { get; }
        
        public void GetResult(string result);

        public void SetPresenter(Presenter presenter);

        
    }
}
