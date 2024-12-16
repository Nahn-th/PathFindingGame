using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMovement
{
    public interface IResettableForm
    {
        void ResetGame();
        void NextGame();
        void ResumeGame();
    }
}
