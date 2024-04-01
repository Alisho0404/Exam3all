using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ParentService
{
    public interface IParentService
    {
        List<Parent> GetAllParents();
        Parent GetParentById(int id);
        string AdParent(Parent parent);
        string UpdateParent(Parent parent);
        bool DeleteParent(int id);
    }
}
