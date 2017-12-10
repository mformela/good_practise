using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp
{
    public interface IEmployee
    {
        string GetFirstName();
        Department GetDepartment();
        void SetDepratment(Department department);

    }
}
