using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCareerActivityProject.BLL.Services.Interfaces;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.BLL.Services.Repositories
{
    public class ConcertRepository : GenericRepository<Concert>, IConcertRepository
    {
    }
}
