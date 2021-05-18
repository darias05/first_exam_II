using System;
using System.Collections.Generic;
using first_exam_II.DTO;
using first_exam_II.DAO;
using first_exam_II.Logic;

namespace first_exam_II
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCitizenComplaintOne createCitizenComplaintOne = new CreateCitizenComplaintOne();
            Dto_CitizenComplaintNode citizenComplaintNodeOne = createCitizenComplaintOne.createCitizenComplaintOne();

            CreateCitizenComplaintTwo createCountryListTwo = new CreateCitizenComplaintTwo();
            Dto_CitizenComplaintNode citizenComplaintNodeTwo = createCountryListTwo.createCitizenComplaintTwo();

            LogicFirstExamII logicFirstExamII = new LogicFirstExamII();
            Dto_CitizenComplaintNode countryListJoinedNode = logicFirstExamII.junctionOfNodes(citizenComplaintNodeOne, citizenComplaintNodeTwo);
        }
    }
}
