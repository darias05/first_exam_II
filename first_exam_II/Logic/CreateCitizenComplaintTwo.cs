using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_exam_II.DTO;
using first_exam_II.DAO;

namespace first_exam_II.Logic
{
    public class CreateCitizenComplaintTwo
    {
        public Dto_CitizenComplaintNode createCitizenComplaintTwo()
        {
            List<int> Code = new List<int>()
            {
                1, 2, 3, 4
            };

            List<string> PersonName = new List<string>()
            {
                "Mariana", "Luis", "Maria", "Ana"
            };

            List<int> Document = new List<int>()
            {
                789, 012, 156, 246
            };

            List<string> Date = new List<string>()
            {
                "05/03/2021", "15/03/2021", "25/04/2021",
                "10/11/2020"
            };

            List<string> Reason = new List<string>()
            {
                "Stole", "Murder", "Stole", "Abuse"
            };

            Dao_CitizenComplaint obj_dao_CitizenComplaint = new Dao_CitizenComplaint();
            Dto_CitizenComplaintNode citizenComplaintNode = obj_dao_CitizenComplaint.createCitizenComplaint(Code, PersonName, Document, Date, Reason);
            return citizenComplaintNode;
        }
    }
}
