using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipTestingExercises;

namespace DipTestingExercise.Testing.Mocking
{
    public class FakePerson : Person,IPerson
    {
        public FakePerson(string pFname, string pLname, string pGender):base(pFname,pLname,pGender)
        {
            
        }
    }
}
