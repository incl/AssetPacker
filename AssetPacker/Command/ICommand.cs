using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetPacker.Command
{
    public interface ICommand
    {
        bool Check();
        void Execute();
    }
}
